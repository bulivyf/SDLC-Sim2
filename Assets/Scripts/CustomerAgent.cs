using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerAgent : GAgent
{
    // Start is called before the first frame update
    new void Start()
    {
        base.Start();
        SubGoal s1 = new SubGoal("isWaiting", 1, true);
        goals.Add(s1, 3);
        //SubGoal s2 = new SubGoal("isMeeting", 1, true);
        //goals.Add(s2, 3);
        SubGoal s3 = new SubGoal("hasDeliveredReq", 1, true);
        goals.Add(s3, 3);
        SubGoal s4 = new SubGoal("isHome", 1, true);
        goals.Add(s4, 3);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
