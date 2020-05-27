using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCustomerAction : GAction
{

    public override bool PrePerform()
    {
        string names = string.Empty;
        // List customers
        foreach(GameObject c in GWorld.Instance.GetQueue("customers").que)
        {
            names += " "+c.name;
        }
        target = GWorld.Instance.GetQueue("customers").RemoveResource();

        Debug.Log("Customers: " + names); //  +", target = "+target.name);

        //Debug.Log("Customers waiting (after pickup) = " + GWorld.Instance.GetQueue("customers").que.Count);

        // Check that we did indeed get a customer
        if (target == null)
            //    // No customers so return false
            return false;

        GWorld.Instance.GetWorld().ModifyState("Waiting", -1);
        
        Dictionary<string, int> states = GWorld.Instance.GetWorld().GetStates();
        return true;
    }

    public override bool PostPerform()
    {
        GWorld.Instance.GetWorld().ModifyState("custPickedUp", 1);
        return true;
    }



}
