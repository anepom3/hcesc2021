//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Tb
{
    [Serializable]
    public class srv_vo_resetRequest : Message
    {
        public const string k_RosMessageName = "tb_msgs/srv_vo_reset";
        public override string RosMessageName => k_RosMessageName;

        public bool request_enable;

        public srv_vo_resetRequest()
        {
            this.request_enable = false;
        }

        public srv_vo_resetRequest(bool request_enable)
        {
            this.request_enable = request_enable;
        }

        public static srv_vo_resetRequest Deserialize(MessageDeserializer deserializer) => new srv_vo_resetRequest(deserializer);

        private srv_vo_resetRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.request_enable);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.request_enable);
        }

        public override string ToString()
        {
            return "srv_vo_resetRequest: " +
            "\nrequest_enable: " + request_enable.ToString();
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
