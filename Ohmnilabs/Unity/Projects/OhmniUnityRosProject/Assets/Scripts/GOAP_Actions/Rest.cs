using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rest : GAction
{
    public override bool PrePerform()
    {
        GWorld.Instance.GetWorld().ModifyState("Cured", 1);
        return true;
    }
    public override bool PostPerform()
    {
        beliefs.RemoveState("exhausted");
        return true;
        
    }
}
