using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCounter : MonoBehaviour
{
    public GameObject trashcounter;
    public int trashcount;
    // Start is called before the first frame update
    void Start()
    {
        trashcount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "bin")
        {
            trashcount = trashcount + 1;
        }

    }
}
