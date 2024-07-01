using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Xml.Linq;
public class GameManager : MonoBehaviour
{
    public float gametimer;
    public static bool gameover;

    public TextMeshPro time;
    public TextMeshPro GameOvertext;
    public GameObject GameOver;
    public GameObject timer;
    public GameObject score;
    public GameObject slingshot;
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

        if (gametimer <= 0)
        {
            Debug.Log("is runnhing");
            gametimer = 0;
            gameover = true;
            GameOvertext.text = ("Game Over!    Score - " + Score.trashcount);
            GameOver.SetActive(true);
            timer.SetActive(false);
            score.SetActive(false);
            slingshot.SetActive(false);
        }
    }
}
