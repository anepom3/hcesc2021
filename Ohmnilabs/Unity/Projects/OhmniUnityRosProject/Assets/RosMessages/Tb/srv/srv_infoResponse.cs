//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Tb
{
    [Serializable]
    public class srv_infoResponse : Message
    {
        public const string k_RosMessageName = "tb_msgs/srv_info";
        public override string RosMessageName => k_RosMessageName;

        public bool is_connected;
        public string port_name;
        public bool is_online;

        public srv_infoResponse()
        {
            this.is_connected = false;
            this.port_name = "";
            this.is_online = false;
        }

        public srv_infoResponse(bool is_connected, string port_name, bool is_online)
        {
            this.is_connected = is_connected;
            this.port_name = port_name;
            this.is_online = is_online;
        }

        public static srv_infoResponse Deserialize(MessageDeserializer deserializer) => new srv_infoResponse(deserializer);

        private srv_infoResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.is_connected);
            deserializer.Read(out this.port_name);
            deserializer.Read(out this.is_online);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.is_connected);
            serializer.Write(this.port_name);
            serializer.Write(this.is_online);
        }

        public override string ToString()
        {
            return "srv_infoResponse: " +
            "\nis_connected: " + is_connected.ToString() +
            "\nport_name: " + port_name.ToString() +
            "\nis_online: " + is_online.ToString();
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
