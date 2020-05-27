using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeveloperAgent : GAgent
{
    // Start is called before the first frame update
    new void Start()
    {
        base.Start();
        SubGoal s1 = new SubGoal("CodeImplemented", 1, false);
        goals.Add(s1, 3);
        //SubGoal s2 = new SubGoal("isWaiting", 1, true);
        //goals.Add(s2, 3);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
