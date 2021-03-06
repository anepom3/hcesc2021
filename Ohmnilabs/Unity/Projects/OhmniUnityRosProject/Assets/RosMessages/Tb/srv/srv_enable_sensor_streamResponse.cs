//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Tb
{
    [Serializable]
    public class srv_enable_sensor_streamResponse : Message
    {
        public const string k_RosMessageName = "tb_msgs/srv_enable_sensor_stream";
        public override string RosMessageName => k_RosMessageName;

        // return current status
        public bool stream_enable;
        public bool tbcore;
        public bool servo_neck;
        public bool wheel_encoder;
        public bool servo_ext1;
        public bool servo_ext2;

        public srv_enable_sensor_streamResponse()
        {
            this.stream_enable = false;
            this.tbcore = false;
            this.servo_neck = false;
            this.wheel_encoder = false;
            this.servo_ext1 = false;
            this.servo_ext2 = false;
        }

        public srv_enable_sensor_streamResponse(bool stream_enable, bool tbcore, bool servo_neck, bool wheel_encoder, bool servo_ext1, bool servo_ext2)
        {
            this.stream_enable = stream_enable;
            this.tbcore = tbcore;
            this.servo_neck = servo_neck;
            this.wheel_encoder = wheel_encoder;
            this.servo_ext1 = servo_ext1;
            this.servo_ext2 = servo_ext2;
        }

        public static srv_enable_sensor_streamResponse Deserialize(MessageDeserializer deserializer) => new srv_enable_sensor_streamResponse(deserializer);

        private srv_enable_sensor_streamResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.stream_enable);
            deserializer.Read(out this.tbcore);
            deserializer.Read(out this.servo_neck);
            deserializer.Read(out this.wheel_encoder);
            deserializer.Read(out this.servo_ext1);
            deserializer.Read(out this.servo_ext2);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.stream_enable);
            serializer.Write(this.tbcore);
            serializer.Write(this.servo_neck);
            serializer.Write(this.wheel_encoder);
            serializer.Write(this.servo_ext1);
            serializer.Write(this.servo_ext2);
        }

        public override string ToString()
        {
            return "srv_enable_sensor_streamResponse: " +
            "\nstream_enable: " + stream_enable.ToString() +
            "\ntbcore: " + tbcore.ToString() +
            "\nservo_neck: " + servo_neck.ToString() +
            "\nwheel_encoder: " + wheel_encoder.ToString() +
            "\nservo_ext1: " + servo_ext1.ToString() +
            "\nservo_ext2: " + servo_ext2.ToString();
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
