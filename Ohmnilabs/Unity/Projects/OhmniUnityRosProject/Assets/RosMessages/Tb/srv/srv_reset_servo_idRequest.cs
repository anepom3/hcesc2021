//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Tb
{
    [Serializable]
    public class srv_reset_servo_idRequest : Message
    {
        public const string k_RosMessageName = "tb_msgs/srv_reset_servo_id";
        public override string RosMessageName => k_RosMessageName;

        public byte origin_sid;
        public byte target_sid;

        public srv_reset_servo_idRequest()
        {
            this.origin_sid = 0;
            this.target_sid = 0;
        }

        public srv_reset_servo_idRequest(byte origin_sid, byte target_sid)
        {
            this.origin_sid = origin_sid;
            this.target_sid = target_sid;
        }

        public static srv_reset_servo_idRequest Deserialize(MessageDeserializer deserializer) => new srv_reset_servo_idRequest(deserializer);

        private srv_reset_servo_idRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.origin_sid);
            deserializer.Read(out this.target_sid);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.origin_sid);
            serializer.Write(this.target_sid);
        }

        public override string ToString()
        {
            return "srv_reset_servo_idRequest: " +
            "\norigin_sid: " + origin_sid.ToString() +
            "\ntarget_sid: " + target_sid.ToString();
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
