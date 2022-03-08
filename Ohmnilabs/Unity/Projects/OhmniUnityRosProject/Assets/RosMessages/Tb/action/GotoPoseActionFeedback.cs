using System.Collections.Generic;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;
using RosMessageTypes.Std;
using RosMessageTypes.Actionlib;

namespace RosMessageTypes.Tb
{
    public class GotoPoseActionFeedback : ActionFeedback<GotoPoseFeedback>
    {
        public const string k_RosMessageName = "tb_msgs/GotoPoseActionFeedback";
        public override string RosMessageName => k_RosMessageName;


        public GotoPoseActionFeedback() : base()
        {
            this.feedback = new GotoPoseFeedback();
        }

        public GotoPoseActionFeedback(HeaderMsg header, GoalStatusMsg status, GotoPoseFeedback feedback) : base(header, status)
        {
            this.feedback = feedback;
        }
        public static GotoPoseActionFeedback Deserialize(MessageDeserializer deserializer) => new GotoPoseActionFeedback(deserializer);

        GotoPoseActionFeedback(MessageDeserializer deserializer) : base(deserializer)
        {
            this.feedback = GotoPoseFeedback.Deserialize(deserializer);
        }
        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.header);
            serializer.Write(this.status);
            serializer.Write(this.feedback);
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
