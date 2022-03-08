//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Tb
{
    [Serializable]
    public class srv_autodockResponse : Message
    {
        public const string k_RosMessageName = "tb_msgs/srv_autodock";
        public override string RosMessageName => k_RosMessageName;

        // response

        public srv_autodockResponse()
        {
        }
        public static srv_autodockResponse Deserialize(MessageDeserializer deserializer) => new srv_autodockResponse(deserializer);

        private srv_autodockResponse(MessageDeserializer deserializer)
        {
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
        }

        public override string ToString()
        {
            return "srv_autodockResponse: ";
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
