//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Tb
{
    [Serializable]
    public class srv_ardock_calibRequest : Message
    {
        public const string k_RosMessageName = "tb_msgs/srv_ardock_calib";
        public override string RosMessageName => k_RosMessageName;

        // goal request definition
        public bool enable_ardock_calib;
        public bool is_save_result;
        public double timeout;
        // timeout in second
        public int min_marker_detected;
        // 

        public srv_ardock_calibRequest()
        {
            this.enable_ardock_calib = false;
            this.is_save_result = false;
            this.timeout = 0.0;
            this.min_marker_detected = 0;
        }

        public srv_ardock_calibRequest(bool enable_ardock_calib, bool is_save_result, double timeout, int min_marker_detected)
        {
            this.enable_ardock_calib = enable_ardock_calib;
            this.is_save_result = is_save_result;
            this.timeout = timeout;
            this.min_marker_detected = min_marker_detected;
        }

        public static srv_ardock_calibRequest Deserialize(MessageDeserializer deserializer) => new srv_ardock_calibRequest(deserializer);

        private srv_ardock_calibRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.enable_ardock_calib);
            deserializer.Read(out this.is_save_result);
            deserializer.Read(out this.timeout);
            deserializer.Read(out this.min_marker_detected);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.enable_ardock_calib);
            serializer.Write(this.is_save_result);
            serializer.Write(this.timeout);
            serializer.Write(this.min_marker_detected);
        }

        public override string ToString()
        {
            return "srv_ardock_calibRequest: " +
            "\nenable_ardock_calib: " + enable_ardock_calib.ToString() +
            "\nis_save_result: " + is_save_result.ToString() +
            "\ntimeout: " + timeout.ToString() +
            "\nmin_marker_detected: " + min_marker_detected.ToString();
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
