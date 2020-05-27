using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveRequirementAction : GAction
{

    public override bool PrePerform()
    {
        Dictionary<string, int> states = GWorld.Instance.GetWorld().GetStates();
        if (states.ContainsKey("custPickedUp"))
            target = GameObject.Find("Meeting Area R");
        else
            return false;

        return true;
    }

    public override bool PostPerform()
    {
        GWorld.Instance.GetWorld().ModifyState("ReqDelivered", 1);
        beliefs.ModifyState("hasDefinedReq", 1);

        return true;
    }
}
