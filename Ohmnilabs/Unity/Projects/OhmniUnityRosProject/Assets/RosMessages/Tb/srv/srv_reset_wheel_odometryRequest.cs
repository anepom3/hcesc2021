//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Tb
{
    [Serializable]
    public class srv_reset_wheel_odometryRequest : Message
    {
        public const string k_RosMessageName = "tb_msgs/srv_reset_wheel_odometry";
        public override string RosMessageName => k_RosMessageName;

        // wheel odometry is drift overtime, so we need to reset it to an external value
        public bool reset_xM;
        public bool reset_yM;
        public bool reset_yaw;
        // xM, yM: meter. yaw: rad
        public double xM;
        public double yM;
        public double yaw;

        public srv_reset_wheel_odometryRequest()
        {
            this.reset_xM = false;
            this.reset_yM = false;
            this.reset_yaw = false;
            this.xM = 0.0;
            this.yM = 0.0;
            this.yaw = 0.0;
        }

        public srv_reset_wheel_odometryRequest(bool reset_xM, bool reset_yM, bool reset_yaw, double xM, double yM, double yaw)
        {
            this.reset_xM = reset_xM;
            this.reset_yM = reset_yM;
            this.reset_yaw = reset_yaw;
            this.xM = xM;
            this.yM = yM;
            this.yaw = yaw;
        }

        public static srv_reset_wheel_odometryRequest Deserialize(MessageDeserializer deserializer) => new srv_reset_wheel_odometryRequest(deserializer);

        private srv_reset_wheel_odometryRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.reset_xM);
            deserializer.Read(out this.reset_yM);
            deserializer.Read(out this.reset_yaw);
            deserializer.Read(out this.xM);
            deserializer.Read(out this.yM);
            deserializer.Read(out this.yaw);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.reset_xM);
            serializer.Write(this.reset_yM);
            serializer.Write(this.reset_yaw);
            serializer.Write(this.xM);
            serializer.Write(this.yM);
            serializer.Write(this.yaw);
        }

        public override string ToString()
        {
            return "srv_reset_wheel_odometryRequest: " +
            "\nreset_xM: " + reset_xM.ToString() +
            "\nreset_yM: " + reset_yM.ToString() +
            "\nreset_yaw: " + reset_yaw.ToString() +
            "\nxM: " + xM.ToString() +
            "\nyM: " + yM.ToString() +
            "\nyaw: " + yaw.ToString();
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