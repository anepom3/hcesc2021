//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Tb
{
    [Serializable]
    public class srv_set_servo_posResponse : Message
    {
        public const string k_RosMessageName = "tb_msgs/srv_set_servo_pos";
        public override string RosMessageName => k_RosMessageName;

        public byte sid;

        public srv_set_servo_posResponse()
        {
            this.sid = 0;
        }

        public srv_set_servo_posResponse(byte sid)
        {
            this.sid = sid;
        }

        public static srv_set_servo_posResponse Deserialize(MessageDeserializer deserializer) => new srv_set_servo_posResponse(deserializer);

        private srv_set_servo_posResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.sid);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.sid);
        }

        public override string ToString()
        {
            return "srv_set_servo_posResponse: " +
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
