﻿using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ResourceQueue
{

    public Queue<GameObject> que = new Queue<GameObject>();
    public string tag;
    public string modState;

    public ResourceQueue(string t, string ms, WorldStates w)
    {

        tag = t;
        modState = ms;
        if (tag != "")
        {

            GameObject[] resources = GameObject.FindGameObjectsWithTag(tag);

            foreach (GameObject r in resources)
            {

                que.Enqueue(r);
            }
        }

        if (modState != "")
        {

            w.ModifyState(modState, que.Count);
        }
    }

    // Add the resource
    public void AddResource(GameObject r)
    {

        que.Enqueue(r);
    }


    // Remove the resource
    public GameObject RemoveResource()
    {

        if (que.Count == 0) return null;

        return que.Dequeue();
    }

    // Overloaded RemoveResource
    public void RemoveResource(GameObject r)
    {

        // Put everything in a new queue except 'r' and copy it back to que
        que = new Queue<GameObject>(que.Where(p => p != r));
    }
}

public sealed class GWorld
{

    // Our GWorld instance
    private static readonly GWorld instance = new GWorld();
    // Our world states
    private static WorldStates world;
    // Queue of customers
    private static ResourceQueue customers;
    // Queue of requirements
    private static ResourceQueue requirements;
    // Queue of tasks
    private static ResourceQueue tasks;
    // Queue of deliverables
    private static ResourceQueue deliverables;



    // Storage for all
    private static Dictionary<string, ResourceQueue> resources = new Dictionary<string, ResourceQueue>();

    static GWorld()
    {

        // Create our world
        world = new WorldStates();
        // Create custoemrs array
        customers = new ResourceQueue("", "", world);
        // Add to the resources Dictionary
        resources.Add("customers", customers);
        // Create customers array
        requirements = new ResourceQueue("", "", world);
        // Add to the resources Dictionary
        resources.Add("requirements", requirements);
        // Create tasks array
        tasks = new ResourceQueue("", "", world);
        // Add to the resources Dictionary
        resources.Add("tasks", tasks);
        // Create deliverables array
        deliverables = new ResourceQueue("", "", world);
        // Add to the deliverables Dictionary
        resources.Add("deliverables", deliverables);

        // Set the time scale in Unity
        Time.timeScale = 5.0f;
    }

    public ResourceQueue GetQueue(string type)
    {

        return resources[type];
    }

    private GWorld()
    {

    }

    public static GWorld Instance
    {

        get { return instance; }
    }

    public WorldStates GetWorld()
    {

        return world;
    }
}
