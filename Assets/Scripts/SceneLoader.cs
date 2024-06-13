using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene()
    {
        SceneManager.LoadScene("DemoDay");
    }
    public void LoadScene2()
    {
        SceneManager.LoadScene("Slingshot");
    }
    public void LoadScene3()
    {
        SceneManager.LoadScene("MainMenu2");
    }
}
