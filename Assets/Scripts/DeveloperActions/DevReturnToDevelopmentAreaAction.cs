using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevReturnToDevelopmentAreaAction : GAction
{

    public override bool PrePerform()
    {
        return true;
    }

    public override bool PostPerform()
    {
        return true;
    }
}
