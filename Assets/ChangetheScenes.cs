using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangetheScenes : MonoBehaviour
{
    // Start is called before the first frame update

    


    public void ChangeFirstScene()
    {
        SceneManager.LoadScene("1.FIRST");
        timer.Timee = 0.0f;
    }

    public void ChangeSecondScene()
    {
        SceneManager.LoadScene("2.MAIN");
    }

    public void ChangeThirdScene()
    {
        SceneManager.LoadScene("3.END");
    }

}
