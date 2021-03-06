//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Tb
{
    [Serializable]
    public class srv_enable_controllersResponse : Message
    {
        public const string k_RosMessageName = "tb_msgs/srv_enable_controllers";
        public override string RosMessageName => k_RosMessageName;

        public bool enable_controller;
        public bool pid_velocity_motor_left;
        public bool pid_velocity_motor_right;

        public srv_enable_controllersResponse()
        {
            this.enable_controller = false;
            this.pid_velocity_motor_left = false;
            this.pid_velocity_motor_right = false;
        }

        public srv_enable_controllersResponse(bool enable_controller, bool pid_velocity_motor_left, bool pid_velocity_motor_right)
        {
            this.enable_controller = enable_controller;
            this.pid_velocity_motor_left = pid_velocity_motor_left;
            this.pid_velocity_motor_right = pid_velocity_motor_right;
        }

        public static srv_enable_controllersResponse Deserialize(MessageDeserializer deserializer) => new srv_enable_controllersResponse(deserializer);

        private srv_enable_controllersResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.enable_controller);
            deserializer.Read(out this.pid_velocity_motor_left);
            deserializer.Read(out this.pid_velocity_motor_right);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.enable_controller);
            serializer.Write(this.pid_velocity_motor_left);
            serializer.Write(this.pid_velocity_motor_right);
        }

        public override string ToString()
        {
            return "srv_enable_controllersResponse: " +
            "\nenable_controller: " + enable_controller.ToString() +
            "\npid_velocity_motor_left: " + pid_velocity_motor_left.ToString() +
            "\npid_velocity_motor_right: " + pid_velocity_motor_right.ToString();
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
