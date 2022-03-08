//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Tb
{
    [Serializable]
    public class srv_set_servo_zero_offsetRequest : Message
    {
        public const string k_RosMessageName = "tb_msgs/srv_set_servo_zero_offset";
        public override string RosMessageName => k_RosMessageName;

        public byte sid;
        public double servo_add_offset_rad;

        public srv_set_servo_zero_offsetRequest()
        {
            this.sid = 0;
            this.servo_add_offset_rad = 0.0;
        }

        public srv_set_servo_zero_offsetRequest(byte sid, double servo_add_offset_rad)
        {
            this.sid = sid;
            this.servo_add_offset_rad = servo_add_offset_rad;
        }

        public static srv_set_servo_zero_offsetRequest Deserialize(MessageDeserializer deserializer) => new srv_set_servo_zero_offsetRequest(deserializer);

        private srv_set_servo_zero_offsetRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.sid);
            deserializer.Read(out this.servo_add_offset_rad);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.sid);
            serializer.Write(this.servo_add_offset_rad);
        }

        public override string ToString()
        {
            return "srv_set_servo_zero_offsetRequest: " +
            "\nsid: " + sid.ToString() +
            "\nservo_add_offset_rad: " + servo_add_offset_rad.ToString();
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