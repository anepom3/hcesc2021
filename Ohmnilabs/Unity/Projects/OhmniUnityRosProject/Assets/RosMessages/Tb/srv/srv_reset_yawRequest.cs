//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Tb
{
    [Serializable]
    public class srv_reset_yawRequest : Message
    {
        public const string k_RosMessageName = "tb_msgs/srv_reset_yaw";
        public override string RosMessageName => k_RosMessageName;

        // yaw is drift overtime, so we need to reset it to an external value
        public double yaw_reset_rad;

        public srv_reset_yawRequest()
        {
            this.yaw_reset_rad = 0.0;
        }

        public srv_reset_yawRequest(double yaw_reset_rad)
        {
            this.yaw_reset_rad = yaw_reset_rad;
        }

        public static srv_reset_yawRequest Deserialize(MessageDeserializer deserializer) => new srv_reset_yawRequest(deserializer);

        private srv_reset_yawRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.yaw_reset_rad);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.yaw_reset_rad);
        }

        public override string ToString()
        {
            return "srv_reset_yawRequest: " +
            "\nyaw_reset_rad: " + yaw_reset_rad.ToString();
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
