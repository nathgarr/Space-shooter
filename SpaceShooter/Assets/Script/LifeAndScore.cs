using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeAndScore : MonoBehaviour
{

    public int life = 3;
    public int NombreEnemieVaincu = 0;
    public GameObject[] LifesGO;
    public static bool gameover = false;
    
    public void Setlife(int value)
    {
        life += value;
        if (life >= 0)
        {
            LifesGO[life].SetActive(false);
            Debug.Log("life - 1");
        }
        else if (life < 0)
                {
            GameObject.Find("player").SetActive(false);
            gameover = true;
        }
    }
    public void replay ()
    {
        life = 3;
        restartlife();
        gameover = false;
    }

    private void restartlife()
    {
        for (int i = -1; i<LifesGO.Length; i++)
        {
            LifesGO [i].SetActive(true);
            GameObject.Find("player").SetActive(true);
        }
    }
}
