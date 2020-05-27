using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToMeetingRoomAction : GAction
{
    // Resource in this case = cubicle
    GameObject resource;

    public override bool PrePerform()
    {
        return true;
    }

    public override bool PostPerform()
    {

        GWorld.Instance.GetWorld().ModifyState("custPickedUp", -1);

        GameObject req = new GameObject("Requ-" + Random.Range(float.MinValue, float.MaxValue));
        GWorld.Instance.GetQueue("requirements").AddResource(req);

        return true;
    }

}
