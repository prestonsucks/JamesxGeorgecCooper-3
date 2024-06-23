using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public float gametimer;
    public bool gameover;
<<<<<<< Updated upstream
    public TextMeshPro time;
=======
    public TextMeshProUGUI time;
    public GameObject Effects;
>>>>>>> Stashed changes
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
        if (gametimer < 0)
        {
            gameover = true;
        }
<<<<<<< Updated upstream
        time.text = ("Time Remaining:" + gametimer.ToString("F2"));
=======
        time.text = ("Time Remaining:" + gametimer);
        if (gameover == true)
        {

        }
>>>>>>> Stashed changes
    }
}
