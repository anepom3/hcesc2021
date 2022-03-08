//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Tb
{
    [Serializable]
    public class srv_cancel_all_goalRequest : Message
    {
        public const string k_RosMessageName = "tb_msgs/srv_cancel_all_goal";
        public override string RosMessageName => k_RosMessageName;

        // goal request definition
        public bool enable_cancel_all_goal;

        public srv_cancel_all_goalRequest()
        {
            this.enable_cancel_all_goal = false;
        }

        public srv_cancel_all_goalRequest(bool enable_cancel_all_goal)
        {
            this.enable_cancel_all_goal = enable_cancel_all_goal;
        }

        public static srv_cancel_all_goalRequest Deserialize(MessageDeserializer deserializer) => new srv_cancel_all_goalRequest(deserializer);

        private srv_cancel_all_goalRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.enable_cancel_all_goal);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.enable_cancel_all_goal);
        }

        public override string ToString()
        {
            return "srv_cancel_all_goalRequest: " +
            "\nenable_cancel_all_goal: " + enable_cancel_all_goal.ToString();
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
