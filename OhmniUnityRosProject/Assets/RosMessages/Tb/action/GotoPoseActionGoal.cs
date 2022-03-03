using System.Collections.Generic;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;
using RosMessageTypes.Std;
using RosMessageTypes.Actionlib;

namespace RosMessageTypes.Tb
{
    public class GotoPoseActionGoal : ActionGoal<GotoPoseGoal>
    {
        public const string k_RosMessageName = "tb_msgs/GotoPoseActionGoal";
        public override string RosMessageName => k_RosMessageName;


        public GotoPoseActionGoal() : base()
        {
            this.goal = new GotoPoseGoal();
        }

        public GotoPoseActionGoal(HeaderMsg header, GoalIDMsg goal_id, GotoPoseGoal goal) : base(header, goal_id)
        {
            this.goal = goal;
        }
        public static GotoPoseActionGoal Deserialize(MessageDeserializer deserializer) => new GotoPoseActionGoal(deserializer);

        GotoPoseActionGoal(MessageDeserializer deserializer) : base(deserializer)
        {
            this.goal = GotoPoseGoal.Deserialize(deserializer);
        }
        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.header);
            serializer.Write(this.goal_id);
            serializer.Write(this.goal);
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
