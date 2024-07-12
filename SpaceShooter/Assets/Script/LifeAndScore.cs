using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeAndScore : MonoBehaviour
{

    public int life = 3;
    public int NombreEnemieVaincu = 0;
    public GameObject[] LifesGO;

    
    public void Setlife(int value)
    {
        life += value;
        if (life > 0)
        {
            LifesGO[life].SetActive(false);
            Debug.Log("life - 1");
        }
        else if (life == 0)
                {
            GameObject.Find("player").SetActive(false);
        }
    }
}
