using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.UI;

public class GameOverMenus : MonoBehaviour
{

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
