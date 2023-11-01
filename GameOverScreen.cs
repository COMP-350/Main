using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public void RestartButton()
    {
        //GameManager.score = 0;
        SceneManager.LoadScene(4);
    }

    public void QuitButton()
    {
        //GameManager.score = 0;
        SceneManager.LoadScene(0);
    }
}
