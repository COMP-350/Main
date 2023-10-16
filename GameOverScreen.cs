using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public void RestartButton()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitButton()
    {
        SceneManager.LoadScene(0);
    }
}
