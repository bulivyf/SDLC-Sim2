using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesterCompleteTestingAction : GAction
{

    public override bool PrePerform()
    {
        return true;
    }

    public override bool PostPerform()
    {
        GameObject d = GWorld.Instance.GetQueue("deliverables").RemoveResource();
        GWorld.Instance.GetWorld().ModifyState("4-Deliv'd", 1);
        Debug.Log(d.name + " is tested and passed");
        Destroy(d, 1.0f);

        return true;
    }
}
