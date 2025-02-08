using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    public float startTime;
    public float endTime;
    public float spawnRate;




    void Start()
    {
        
    }
    void Spawn()
    {
        InvokeRepeating("Spawn", startTime, spawnRate);
        Invoke("CancelInvoke", endTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
