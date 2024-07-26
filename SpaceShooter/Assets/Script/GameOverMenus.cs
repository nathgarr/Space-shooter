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
  
    // Start is called before the first frame update
/*       void Start()
    {

    }
    public void LoadGame()
    {
        // chargement de la scene de jeux
        SceneManager.LoadScene(0);
    }
    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
#if UNITY_STANDALONE
        Application.Quit();
#endif
    }*/
}
