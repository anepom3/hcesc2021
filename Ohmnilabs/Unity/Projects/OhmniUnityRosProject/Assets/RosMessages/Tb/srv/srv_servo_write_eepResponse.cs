//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Tb
{
    [Serializable]
    public class srv_servo_write_eepResponse : Message
    {
        public const string k_RosMessageName = "tb_msgs/srv_servo_write_eep";
        public override string RosMessageName => k_RosMessageName;

        public byte sid;

        public srv_servo_write_eepResponse()
        {
            this.sid = 0;
        }

        public srv_servo_write_eepResponse(byte sid)
        {
            this.sid = sid;
        }

        public static srv_servo_write_eepResponse Deserialize(MessageDeserializer deserializer) => new srv_servo_write_eepResponse(deserializer);

        private srv_servo_write_eepResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.sid);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.sid);
        }

        public override string ToString()
        {
            return "srv_servo_write_eepResponse: " +
            "\nsid: " + sid.ToString();
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
