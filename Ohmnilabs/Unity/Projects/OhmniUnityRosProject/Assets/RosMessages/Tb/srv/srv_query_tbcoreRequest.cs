//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Tb
{
    [Serializable]
    public class srv_query_tbcoreRequest : Message
    {
        public const string k_RosMessageName = "tb_msgs/srv_query_tbcore";
        public override string RosMessageName => k_RosMessageName;

        // goal request definition
        public bool enable_query_tbcore;

        public srv_query_tbcoreRequest()
        {
            this.enable_query_tbcore = false;
        }

        public srv_query_tbcoreRequest(bool enable_query_tbcore)
        {
            this.enable_query_tbcore = enable_query_tbcore;
        }

        public static srv_query_tbcoreRequest Deserialize(MessageDeserializer deserializer) => new srv_query_tbcoreRequest(deserializer);

        private srv_query_tbcoreRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.enable_query_tbcore);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.enable_query_tbcore);
        }

        public override string ToString()
        {
            return "srv_query_tbcoreRequest: " +
            "\nenable_query_tbcore: " + enable_query_tbcore.ToString();
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
