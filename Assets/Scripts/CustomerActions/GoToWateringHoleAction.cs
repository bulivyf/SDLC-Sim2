using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToWateringHoleAction : GAction
{


    public override bool PrePerform()
    {
        // Inject waiting state to world states
        GWorld.Instance.GetWorld().ModifyState("Waiting", 1);
        return true;
    }
    public override bool PostPerform()
    {


        //// Customer adds himself to the queue
        GWorld.Instance.GetQueue("customers").AddResource(this.gameObject);

        // Inject a state into the agent' beliefs
        beliefs.ModifyState("atOffice", 1);


        Debug.Log("Customers waiting = " + GWorld.Instance.GetQueue("customers").que.Count);
        return true;
    }
}
