//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Tb
{
    [Serializable]
    public class srv_recalibResponse : Message
    {
        public const string k_RosMessageName = "tb_msgs/srv_recalib";
        public override string RosMessageName => k_RosMessageName;

        public bool calib_succeess;

        public srv_recalibResponse()
        {
            this.calib_succeess = false;
        }

        public srv_recalibResponse(bool calib_succeess)
        {
            this.calib_succeess = calib_succeess;
        }

        public static srv_recalibResponse Deserialize(MessageDeserializer deserializer) => new srv_recalibResponse(deserializer);

        private srv_recalibResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.calib_succeess);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.calib_succeess);
        }

        public override string ToString()
        {
            return "srv_recalibResponse: " +
            "\ncalib_succeess: " + calib_succeess.ToString();
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
