using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TrashDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    public TrashCounter Trashcount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Trash Count = " + Trashcount.trashcount;
    }
}
