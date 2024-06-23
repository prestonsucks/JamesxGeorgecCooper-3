using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RubbishBin : MonoBehaviour
{
    public float trashcount;
    public GameObject trashcounter;
    public float timer;
    public bool yes;
    // Start is called before the first frame update
    void Start()
    {
        trashcount = 0;
        timer = 0;
        yes = true;
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer+ Time.deltaTime;
       trashcounter.GetComponent<TextMeshPro>().text = "trash count:" + trashcount;
        if (timer > 1)
        {
            yes = true;
            
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "can" && yes == true)
        {
            trashcount = trashcount + 1;
            yes = false;
            timer = 0;
        }
    }
}
