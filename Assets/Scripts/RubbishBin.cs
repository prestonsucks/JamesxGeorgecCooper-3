using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RubbishBin : MonoBehaviour
{
    public float trashcount;
    public float timer;
    public bool yes;
    public GameObject confetti;
    public float score;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        trashcount = 0;
        timer = 0;
        yes = true;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer+ Time.deltaTime;
        if (timer > 1)
        {
            yes = true;
            
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "can" && yes == true)
        {
            Score.trashcount = Score.trashcount + score;
            confetti.GetComponent<ParticleSystem>().Play();
            timer = 0;
            yes = false;
            audioSource.Play();
        }
    }
}
