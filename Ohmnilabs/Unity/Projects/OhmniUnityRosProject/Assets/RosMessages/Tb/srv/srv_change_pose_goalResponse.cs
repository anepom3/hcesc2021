//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Tb
{
    [Serializable]
    public class srv_change_pose_goalResponse : Message
    {
        public const string k_RosMessageName = "tb_msgs/srv_change_pose_goal";
        public override string RosMessageName => k_RosMessageName;

        // response
        public bool success;

        public srv_change_pose_goalResponse()
        {
            this.success = false;
        }

        public srv_change_pose_goalResponse(bool success)
        {
            this.success = success;
        }

        public static srv_change_pose_goalResponse Deserialize(MessageDeserializer deserializer) => new srv_change_pose_goalResponse(deserializer);

        private srv_change_pose_goalResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.success);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.success);
        }

        public override string ToString()
        {
            return "srv_change_pose_goalResponse: " +
            "\nsuccess: " + success.ToString();
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize, MessageSubtopic.Response);
        }
    }
}
