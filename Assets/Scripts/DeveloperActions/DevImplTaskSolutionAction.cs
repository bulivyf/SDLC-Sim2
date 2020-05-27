using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevImplTaskSolutionAction : GAction
{

    public override bool PrePerform()
    {
        //GWorld.Instance.GetWorld().ModifyState("Waiting", 1);
        //GWorld.Instance.AddCustomer(this.gameObject);
        return true;
    }

    public override bool PostPerform()
    {
        GameObject t = GWorld.Instance.GetQueue("tasks").RemoveResource();
        Destroy(t, 1.0f);

        GameObject d = new GameObject("Delivery-" + Random.Range(1000, 10000));
        GWorld.Instance.GetQueue("deliverables").AddResource(d);
        GWorld.Instance.GetWorld().ModifyState("3-Impl'd", 1);

        Debug.Log(t.name + " is addressed and logged as deliverable " + d.name);
        return true;
    }
}
