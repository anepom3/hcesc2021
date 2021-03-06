//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;
using RosMessageTypes.Std;

namespace RosMessageTypes.Tb
{
    [Serializable]
    public class Robot_stateMsg : Message
    {
        public const string k_RosMessageName = "tb_msgs/robot_state";
        public override string RosMessageName => k_RosMessageName;

        public HeaderMsg header;
        // From IMU
        public double accel_linear_xB;
        public double accel_linear_yB;
        public double accel_linear_zB;
        public double accel_amplitude;
        // From IMU and wheel encoder
        public double velo_linear_xB_m_wheelLeft_gyroZ;
        public double velo_linear_xB_m_wheelRight_gyroZ;
        // Frome wheel encoder only
        public double velo_linear_xB_m_wheel;
        public double velo_angular_zB_m_wheel;
        public double wheel_left_velo_rad;
        public double wheel_right_velo_rad;
        // Best result
        public double vel_xM;
        public double vel_yM;
        public double vel_zM;
        public double pos_xM;
        public double pos_yM;
        public double pos_zM;
        public double roll;
        public double pitch;
        public double yaw;

        public Robot_stateMsg()
        {
            this.header = new HeaderMsg();
            this.accel_linear_xB = 0.0;
            this.accel_linear_yB = 0.0;
            this.accel_linear_zB = 0.0;
            this.accel_amplitude = 0.0;
            this.velo_linear_xB_m_wheelLeft_gyroZ = 0.0;
            this.velo_linear_xB_m_wheelRight_gyroZ = 0.0;
            this.velo_linear_xB_m_wheel = 0.0;
            this.velo_angular_zB_m_wheel = 0.0;
            this.wheel_left_velo_rad = 0.0;
            this.wheel_right_velo_rad = 0.0;
            this.vel_xM = 0.0;
            this.vel_yM = 0.0;
            this.vel_zM = 0.0;
            this.pos_xM = 0.0;
            this.pos_yM = 0.0;
            this.pos_zM = 0.0;
            this.roll = 0.0;
            this.pitch = 0.0;
            this.yaw = 0.0;
        }

        public Robot_stateMsg(HeaderMsg header, double accel_linear_xB, double accel_linear_yB, double accel_linear_zB, double accel_amplitude, double velo_linear_xB_m_wheelLeft_gyroZ, double velo_linear_xB_m_wheelRight_gyroZ, double velo_linear_xB_m_wheel, double velo_angular_zB_m_wheel, double wheel_left_velo_rad, double wheel_right_velo_rad, double vel_xM, double vel_yM, double vel_zM, double pos_xM, double pos_yM, double pos_zM, double roll, double pitch, double yaw)
        {
            this.header = header;
            this.accel_linear_xB = accel_linear_xB;
            this.accel_linear_yB = accel_linear_yB;
            this.accel_linear_zB = accel_linear_zB;
            this.accel_amplitude = accel_amplitude;
            this.velo_linear_xB_m_wheelLeft_gyroZ = velo_linear_xB_m_wheelLeft_gyroZ;
            this.velo_linear_xB_m_wheelRight_gyroZ = velo_linear_xB_m_wheelRight_gyroZ;
            this.velo_linear_xB_m_wheel = velo_linear_xB_m_wheel;
            this.velo_angular_zB_m_wheel = velo_angular_zB_m_wheel;
            this.wheel_left_velo_rad = wheel_left_velo_rad;
            this.wheel_right_velo_rad = wheel_right_velo_rad;
            this.vel_xM = vel_xM;
            this.vel_yM = vel_yM;
            this.vel_zM = vel_zM;
            this.pos_xM = pos_xM;
            this.pos_yM = pos_yM;
            this.pos_zM = pos_zM;
            this.roll = roll;
            this.pitch = pitch;
            this.yaw = yaw;
        }

        public static Robot_stateMsg Deserialize(MessageDeserializer deserializer) => new Robot_stateMsg(deserializer);

        private Robot_stateMsg(MessageDeserializer deserializer)
        {
            this.header = HeaderMsg.Deserialize(deserializer);
            deserializer.Read(out this.accel_linear_xB);
            deserializer.Read(out this.accel_linear_yB);
            deserializer.Read(out this.accel_linear_zB);
            deserializer.Read(out this.accel_amplitude);
            deserializer.Read(out this.velo_linear_xB_m_wheelLeft_gyroZ);
            deserializer.Read(out this.velo_linear_xB_m_wheelRight_gyroZ);
            deserializer.Read(out this.velo_linear_xB_m_wheel);
            deserializer.Read(out this.velo_angular_zB_m_wheel);
            deserializer.Read(out this.wheel_left_velo_rad);
            deserializer.Read(out this.wheel_right_velo_rad);
            deserializer.Read(out this.vel_xM);
            deserializer.Read(out this.vel_yM);
            deserializer.Read(out this.vel_zM);
            deserializer.Read(out this.pos_xM);
            deserializer.Read(out this.pos_yM);
            deserializer.Read(out this.pos_zM);
            deserializer.Read(out this.roll);
            deserializer.Read(out this.pitch);
            deserializer.Read(out this.yaw);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.header);
            serializer.Write(this.accel_linear_xB);
            serializer.Write(this.accel_linear_yB);
            serializer.Write(this.accel_linear_zB);
            serializer.Write(this.accel_amplitude);
            serializer.Write(this.velo_linear_xB_m_wheelLeft_gyroZ);
            serializer.Write(this.velo_linear_xB_m_wheelRight_gyroZ);
            serializer.Write(this.velo_linear_xB_m_wheel);
            serializer.Write(this.velo_angular_zB_m_wheel);
            serializer.Write(this.wheel_left_velo_rad);
            serializer.Write(this.wheel_right_velo_rad);
            serializer.Write(this.vel_xM);
            serializer.Write(this.vel_yM);
            serializer.Write(this.vel_zM);
            serializer.Write(this.pos_xM);
            serializer.Write(this.pos_yM);
            serializer.Write(this.pos_zM);
            serializer.Write(this.roll);
            serializer.Write(this.pitch);
            serializer.Write(this.yaw);
        }

        public override string ToString()
        {
            return "Robot_stateMsg: " +
            "\nheader: " + header.ToString() +
            "\naccel_linear_xB: " + accel_linear_xB.ToString() +
            "\naccel_linear_yB: " + accel_linear_yB.ToString() +
            "\naccel_linear_zB: " + accel_linear_zB.ToString() +
            "\naccel_amplitude: " + accel_amplitude.ToString() +
            "\nvelo_linear_xB_m_wheelLeft_gyroZ: " + velo_linear_xB_m_wheelLeft_gyroZ.ToString() +
            "\nvelo_linear_xB_m_wheelRight_gyroZ: " + velo_linear_xB_m_wheelRight_gyroZ.ToString() +
            "\nvelo_linear_xB_m_wheel: " + velo_linear_xB_m_wheel.ToString() +
            "\nvelo_angular_zB_m_wheel: " + velo_angular_zB_m_wheel.ToString() +
            "\nwheel_left_velo_rad: " + wheel_left_velo_rad.ToString() +
            "\nwheel_right_velo_rad: " + wheel_right_velo_rad.ToString() +
            "\nvel_xM: " + vel_xM.ToString() +
            "\nvel_yM: " + vel_yM.ToString() +
            "\nvel_zM: " + vel_zM.ToString() +
            "\npos_xM: " + pos_xM.ToString() +
            "\npos_yM: " + pos_yM.ToString() +
            "\npos_zM: " + pos_zM.ToString() +
            "\nroll: " + roll.ToString() +
            "\npitch: " + pitch.ToString() +
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
