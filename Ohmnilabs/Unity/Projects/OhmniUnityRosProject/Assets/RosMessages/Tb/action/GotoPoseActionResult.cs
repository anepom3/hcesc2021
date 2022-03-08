using System.Collections.Generic;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;
using RosMessageTypes.Std;
using RosMessageTypes.Actionlib;

namespace RosMessageTypes.Tb
{
    public class GotoPoseActionResult : ActionResult<GotoPoseResult>
    {
        public const string k_RosMessageName = "tb_msgs/GotoPoseActionResult";
        public override string RosMessageName => k_RosMessageName;


        public GotoPoseActionResult() : base()
        {
            this.result = new GotoPoseResult();
        }

        public GotoPoseActionResult(HeaderMsg header, GoalStatusMsg status, GotoPoseResult result) : base(header, status)
        {
            this.result = result;
        }
        public static GotoPoseActionResult Deserialize(MessageDeserializer deserializer) => new GotoPoseActionResult(deserializer);

        GotoPoseActionResult(MessageDeserializer deserializer) : base(deserializer)
        {
            this.result = GotoPoseResult.Deserialize(deserializer);
        }
        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.header);
            serializer.Write(this.status);
            serializer.Write(this.result);
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
