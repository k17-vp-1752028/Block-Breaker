using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitBtn : MonoBehaviour
{
    [SerializeField] string startScence = "Start Game";
    [SerializeField] string level1Scence = "Level 1";
    public void onClickQuit()
    {
        Application.Quit();
    }

    public void changeScence()
    {
        SceneManager.LoadScene(this.startScence);
    }

    public void changeLevel1Scence()
    {
        SceneManager.LoadScene(this.level1Scence);
    }
}
