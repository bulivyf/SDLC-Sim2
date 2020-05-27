using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReqManagerAgent : GAgent
{
    // Start is called before the first frame update
    new void Start()
    {
        base.Start();

        SubGoal s1 = new SubGoal("gatherReq", 1, false);
        goals.Add(s1, 3);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
