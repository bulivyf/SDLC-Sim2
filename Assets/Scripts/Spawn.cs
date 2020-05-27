using UnityEngine;

public class Spawn : MonoBehaviour
{

    // Grab our prefab
    public GameObject customerPrefab;
    // Number of patients to spawn
    public int numCustomers;
    // A bool to control if you want spawning or not
    public bool keepSpawning = false;
    private int incValue = 0;

    void Start()
    {

        for (int i = 0; i < numCustomers; ++i)
        {
            incValue = i;
            // Instantiate numCustomers at the spawner
            GameObject g = (GameObject)Instantiate(customerPrefab, this.transform.position, Quaternion.identity);
            g.name = "Customer " + incValue;
        }
        // Call the SpawnCustomer method for the first time
        if (keepSpawning)
        {

            Invoke("SpawnCustomer", 20f);
        }
    }

    void SpawnCustomer()
    {
        incValue++;
        // Instantiate numCustomers at the spawner
        GameObject g = (GameObject)Instantiate(customerPrefab, this.transform.position, Quaternion.identity);
        g.name = "Customer " + incValue;
        // Invoke this method at random intervals
        Invoke("SpawnCustomer", Random.Range(70.0f, 100.0f));
    }
}
