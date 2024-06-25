using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static float trashcount;
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
}
