//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Tb
{
    [Serializable]
    public class srv_change_pose_goalRequest : Message
    {
        public const string k_RosMessageName = "tb_msgs/srv_change_pose_goal";
        public override string RosMessageName => k_RosMessageName;

        // goal request definition
        public Geometry.PoseWithCovarianceStampedMsg goal_pose;

        public srv_change_pose_goalRequest()
        {
            this.goal_pose = new Geometry.PoseWithCovarianceStampedMsg();
        }

        public srv_change_pose_goalRequest(Geometry.PoseWithCovarianceStampedMsg goal_pose)
        {
            this.goal_pose = goal_pose;
        }

        public static srv_change_pose_goalRequest Deserialize(MessageDeserializer deserializer) => new srv_change_pose_goalRequest(deserializer);

        private srv_change_pose_goalRequest(MessageDeserializer deserializer)
        {
            this.goal_pose = Geometry.PoseWithCovarianceStampedMsg.Deserialize(deserializer);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.goal_pose);
        }

        public override string ToString()
        {
            return "srv_change_pose_goalRequest: " +
            "\ngoal_pose: " + goal_pose.ToString();
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize);
        }
    }
}
