using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeadDefineTaskAction : GAction
{

    public override bool PrePerform()
    {
        //GWorld.Instance.GetWorld().ModifyState("Waiting", 1);
        //GWorld.Instance.AddCustomer(this.gameObject);
        return true;
    }
    public override bool PostPerform()
    {
        GameObject r = GWorld.Instance.GetQueue("requirements").RemoveResource();
        Destroy(r, 1.0f);

        GameObject t = new GameObject("Task-" + Random.Range(0, 1000));
        GWorld.Instance.GetQueue("tasks").AddResource(t);

        GWorld.Instance.GetWorld().ModifyState("2-Tasks", 1);

        Debug.Log(r.name + " Addressed by Task "+t.name);

        return true;
    }
}
