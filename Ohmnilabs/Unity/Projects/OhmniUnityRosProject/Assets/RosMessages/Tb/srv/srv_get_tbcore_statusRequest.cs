//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Tb
{
    [Serializable]
    public class srv_get_tbcore_statusRequest : Message
    {
        public const string k_RosMessageName = "tb_msgs/srv_get_tbcore_status";
        public override string RosMessageName => k_RosMessageName;

        // goal request definition

        public srv_get_tbcore_statusRequest()
        {
        }
        public static srv_get_tbcore_statusRequest Deserialize(MessageDeserializer deserializer) => new srv_get_tbcore_statusRequest(deserializer);

        private srv_get_tbcore_statusRequest(MessageDeserializer deserializer)
        {
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
        }

        public override string ToString()
        {
            return "srv_get_tbcore_statusRequest: ";
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
