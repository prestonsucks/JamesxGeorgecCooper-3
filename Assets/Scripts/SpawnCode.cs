using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SpawnCode : MonoBehaviour
{
    
    public float Timer;
    public Transform Pos;
    public GameObject[] objectsToInstantiate;
    void Start()
    {
        Timer = 0;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer = Timer + Time.deltaTime;
        if (Timer > 3)
        {
            int n = Random.Range(0, objectsToInstantiate.Length);
            Instantiate(objectsToInstantiate[n], Pos.position, objectsToInstantiate[n].transform.rotation);
            Timer = 0;
        }
    }
}
