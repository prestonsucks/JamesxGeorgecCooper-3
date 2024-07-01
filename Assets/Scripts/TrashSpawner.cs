using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSpawner : MonoBehaviour
{
    public GameObject[] list;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            SpawnTrash();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnTrash()
    {
        Instantiate(list[Random.Range(0, list.Length)], new Vector3(Random.Range(-36.0f,36.0f), 10, Random.Range(-44.0f,34.0f)), gameObject.transform.rotation);
    }
}
