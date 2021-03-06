using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RosMessageTypes.UnityRoboticsDemo;
using Unity.Robotics.ROSTCPConnector;

// Here in this example, Unity acts as the client making a service call to
// a ROS node acting as a server.

// We make a request for a new destination by letting them know our current position.
// Once they receive our message we then receive a new destination.
// Once we reach that destination and it's been greater than our update time (1s),
// we ask for a new destination.

public class RosServiceCallExample : MonoBehaviour
{
    ROSConnection ros;
    
    public string serviceName = "pos_srv";

    public GameObject cube;

    // Cube movement conditions
    public float delta = 1.0f;
    public float speed = 2.0f;
    private Vector3 destination;

    float awaitingResponseUntilTimestamp = -1;

    // Start is called before the first frame update
    void Start()
    {
        ros = ROSConnection.GetOrCreateInstance();
        ros.RegisterRosService<PositionServiceRequest, PositionServiceResponse>(serviceName);
        destination = cube.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Move our position a step closer to the target.
        float step = speed * Time.deltaTime; // Calculate distance to move
        cube.transform.position = Vector3.MoveTowards(cube.transform.position, destination, step);
        
        // If we have made it to our destination, we then send a new service request with our current position.
        if(Vector3.Distance(cube.transform.position,destination) < delta && Time.time > awaitingResponseUntilTimestamp)
        {
            Debug.Log("Destination reached.");

            PosRotMsg cubePos = new PosRotMsg(
                cube.transform.position.x,
                cube.transform.position.y,
                cube.transform.position.z,
                cube.transform.rotation.x,
                cube.transform.rotation.y,
                cube.transform.rotation.z,
                cube.transform.rotation.w);
            
            PositionServiceRequest positionServiceRequest = new PositionServiceRequest(cubePos);

            // Send message to ROS and return the response
            ros.SendServiceMessage<PositionServiceResponse>(serviceName, positionServiceRequest, Callback_Destination);
            // Don't send again for 1 second, or until we receive a response
            awaitingResponseUntilTimestamp = Time.time + 1.0f;
        }
    }

    // Once we get a response with the the new destination, we then log the response from the server
    // running ROS
    void Callback_Destination(PositionServiceResponse response)
    {
        awaitingResponseUntilTimestamp = -1;
        destination = new Vector3(response.output.pos_x,
                                  response.output.pos_y,
                                  response.output.pos_z);
        Debug.Log("New Destination: " + destination);
    }
}
