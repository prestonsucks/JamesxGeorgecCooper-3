using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public float gametimer;
    public bool gameover;

    public TextMeshPro time;

    public GameObject Effects;
    // Start is called before the first frame update
    void Start()
    {
        gametimer = 60;
        gameover = false;
    }

    // Update is called once per frame
    void Update()
    {
        gametimer -= Time.deltaTime;
    
        time.text = ("Time Remaining:" + gametimer.ToString("F2"));

        if (gametimer < 0)
        {
            gameover = true;
        }
    }
}
