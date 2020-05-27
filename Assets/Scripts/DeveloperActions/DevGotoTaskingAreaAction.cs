using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevGotoTaskingAreaAction : GAction
{

    public override bool PrePerform()
    {
        if (GWorld.Instance.GetQueue("tasks").que.Count <= 0)
            return false;
        return true;
    }

    public override bool PostPerform()
    {
        return true;
    }
}
