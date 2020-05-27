using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToHomeAction : GAction
{

    public override bool PrePerform()
    {
        return true;
    }

    public override bool PostPerform()
    {
        Destroy(this.gameObject, 1.0f);
        return true;
    }

}
