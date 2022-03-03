using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RosMessageTypes.UnityRoboticsDemo;
using Unity.Robotics.ROSTCPConnector;
using Unity.Robotics.ROSTCPConnector.ROSGeometry;

public class RosServiceExample : MonoBehaviour
{
    [SerializeField]
    string m_ServiceName = "obj_pose_srv";
    // Start is called before the first frame update
    void Start()
    {
        ROSConnection.GetOrCreateInstance().ImplementService<ObjectPoseServiceRequest,
                                                             ObjectPoseServiceResponse>
                                                             (m_ServiceName, GetObjectPose);
    }

    /// <summary>
    ///  Callback to respond to the request
    /// </summary>
    /// <param name="request">service request containing the object name</param>
    /// <returns>service response containing the object pose (or 0 if object not found)</returns>
    private ObjectPoseServiceResponse GetObjectPose(ObjectPoseServiceRequest request)
    {
        // process the service request
        Debug.Log("Recieved request for object: " + request.object_name);

        // prepare a response
        ObjectPoseServiceResponse objectPoseResponse = new ObjectPoseServiceResponse();

        // Find a game object with the request name
        GameObject gameObject = GameObject.Find(request.object_name);

        if (gameObject)
        {
            // Fill-in the repsonse with the object pose converted from Unity Coordinate
            // to ROS coordinate system
            objectPoseResponse.object_pose.position = gameObject.transform.position.To<FLU>();
            objectPoseResponse.object_pose.orientation = gameObject.transform.rotation.To<FLU>();
        }
        return objectPoseResponse;
    }

}
