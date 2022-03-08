//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Tb
{
    [Serializable]
    public class srv_get_pidRequest : Message
    {
        public const string k_RosMessageName = "tb_msgs/srv_get_pid";
        public override string RosMessageName => k_RosMessageName;

        public long pid_id;

        public srv_get_pidRequest()
        {
            this.pid_id = 0;
        }

        public srv_get_pidRequest(long pid_id)
        {
            this.pid_id = pid_id;
        }

        public static srv_get_pidRequest Deserialize(MessageDeserializer deserializer) => new srv_get_pidRequest(deserializer);

        private srv_get_pidRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.pid_id);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.pid_id);
        }

        public override string ToString()
        {
            return "srv_get_pidRequest: " +
            "\npid_id: " + pid_id.ToString();
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