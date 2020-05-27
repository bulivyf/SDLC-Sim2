using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeadGotoTaskingAreaAction : GAction
{

    public override bool PrePerform()
    {
        //GWorld.Instance.GetWorld().ModifyState("Waiting", 1);
        //GWorld.Instance.AddCustomer(this.gameObject);
        return true;
    }

    public override bool PostPerform()
    {
        return true;
    }
}
