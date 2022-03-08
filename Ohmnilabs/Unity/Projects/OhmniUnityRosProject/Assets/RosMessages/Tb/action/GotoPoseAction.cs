using System.Collections.Generic;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;


namespace RosMessageTypes.Tb
{
    public class GotoPoseAction : Action<GotoPoseActionGoal, GotoPoseActionResult, GotoPoseActionFeedback, GotoPoseGoal, GotoPoseResult, GotoPoseFeedback>
    {
        public const string k_RosMessageName = "tb_msgs/GotoPoseAction";
        public override string RosMessageName => k_RosMessageName;


        public GotoPoseAction() : base()
        {
            this.action_goal = new GotoPoseActionGoal();
            this.action_result = new GotoPoseActionResult();
            this.action_feedback = new GotoPoseActionFeedback();
        }

        public static GotoPoseAction Deserialize(MessageDeserializer deserializer) => new GotoPoseAction(deserializer);

        GotoPoseAction(MessageDeserializer deserializer)
        {
            this.action_goal = GotoPoseActionGoal.Deserialize(deserializer);
            this.action_result = GotoPoseActionResult.Deserialize(deserializer);
            this.action_feedback = GotoPoseActionFeedback.Deserialize(deserializer);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.action_goal);
            serializer.Write(this.action_result);
            serializer.Write(this.action_feedback);
        }

    }
}
