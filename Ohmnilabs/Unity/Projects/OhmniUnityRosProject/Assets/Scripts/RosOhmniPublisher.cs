#if ENABLE_INPUT_SYSTEM 
using UnityEngine.InputSystem;
#endif

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Robotics.ROSTCPConnector;
using RosMessageTypes.Geometry;

public class RosOhmniPublisher : MonoBehaviour
{
    ROSConnection ros;
    public string topicName = "tb_cmd_vel";

    // Publish the cube's position and roation ever N seconds
    public float publishMessageFrequency = 0.5f;

    // Used to determine how much time has elapsed since the last message was published
    private float timeElapsed;

    public float maxLinearSpeed = 0.7f; // m/s
    public float maxRotationalSpeed = 2; //rad/s 

#if ENABLE_INPUT_SYSTEM
    InputAction movement;
#endif

    // Start is called before the first frame update
    void Start()
    {
        // start the ROS connection
        ros = ROSConnection.GetOrCreateInstance();
        ros.RegisterPublisher<TwistMsg>(topicName);

#if ENABLE_INPUT_SYSTEM
        movement = new InputAction("PlayerMovement", binding: "<Gamepad>/leftStick");
        movement.AddCompositeBinding("Dpad")
            .With("Up", "<Keyboard>/w")
            .With("Down", "<Keyboard>/s")
            .With("Left", "<Keyboard>/a")
            .With("Right", "<Keyboard>/d");
        movement.Enable();
#endif
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed > publishMessageFrequency)
        {
            float moveDirection;
            float turnDirection;
            float inputSpeed;
            float inputRotationSpeed;
#if ENABLE_INPUT_SYSTEM
            var delta = movement.ReadValue<Vector2>();
            moveDirection = delta.y;
            turnDirection = delta.x;
#else
            moveDirection = Input.GetAxis("Vertical");
            turnDirection = Input.GetAxis("Horizontal");
#endif
            if (moveDirection > 0)
            {
                inputSpeed = maxLinearSpeed;
            }
            else if (moveDirection < 0)
            {
                inputSpeed = maxLinearSpeed * -1;
            }
            else
            {
                inputSpeed = 0;
            }


            if (turnDirection > 0)
            {
                inputRotationSpeed = maxRotationalSpeed *-1;
            }
            else if (turnDirection < 0)
            {
                inputRotationSpeed = maxRotationalSpeed;
            }
            else
            {
                inputRotationSpeed = 0;
            }


            // Then creates a new PosRotMsg to be published
            Vector3Msg linear = new Vector3Msg(inputSpeed, 0.0f, 0.0f);
            Vector3Msg angular = new Vector3Msg(0.0f, 0.0f, inputRotationSpeed);
            TwistMsg tb_cmd_vel = new TwistMsg(linear, angular);

            // Finally send the message to the server_endpoint.py running in ROS
            ros.Publish(topicName, tb_cmd_vel);

            // Reset timeElapsed back to zero
            timeElapsed = 0;
        }
    }
}
