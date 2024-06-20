using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RubbishBin : MonoBehaviour
{
    public float trashcount;
    public GameObject trashcounter;
    // Start is called before the first frame update
    void Start()
    {
        trashcount = 0;
    }

    // Update is called once per frame
    void Update()
    {
       trashcounter.GetComponent<TextMeshPro>().text = "trash count:" + trashcount;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "can")
        {
            trashcount = +1;
        }
    }
}
