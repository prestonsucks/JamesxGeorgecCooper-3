using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RubbishBin : MonoBehaviour
{
    public float trashcount;
   
    public GameObject confetti;
    public float score;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        trashcount = 0;
      
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "can")
        {
            Score.trashcount = Score.trashcount + score;
            confetti.GetComponent<ParticleSystem>().Play();
           
            audioSource.Play();
        }
    }
}
