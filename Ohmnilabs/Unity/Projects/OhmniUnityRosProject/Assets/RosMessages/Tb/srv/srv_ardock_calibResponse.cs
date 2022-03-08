//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Tb
{
    [Serializable]
    public class srv_ardock_calibResponse : Message
    {
        public const string k_RosMessageName = "tb_msgs/srv_ardock_calib";
        public override string RosMessageName => k_RosMessageName;

        // response
        public bool success;
        public int state_code;

        public srv_ardock_calibResponse()
        {
            this.success = false;
            this.state_code = 0;
        }

        public srv_ardock_calibResponse(bool success, int state_code)
        {
            this.success = success;
            this.state_code = state_code;
        }

        public static srv_ardock_calibResponse Deserialize(MessageDeserializer deserializer) => new srv_ardock_calibResponse(deserializer);

        private srv_ardock_calibResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.success);
            deserializer.Read(out this.state_code);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.success);
            serializer.Write(this.state_code);
        }

        public override string ToString()
        {
            return "srv_ardock_calibResponse: " +
            "\nsuccess: " + success.ToString() +
            "\nstate_code: " + state_code.ToString();
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
