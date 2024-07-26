using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeAndScore : MonoBehaviour
{
    [SerializeField]
    LifeSystem lifeSystem;
    [SerializeField]
    GameObject gameOverMenus;
    public float numberNpcKilled = 0;

    public GameObject[] LifesGO;

    private void Awake()
    {
        lifeSystem.onKill = OnPlayerkill;
        lifeSystem.onDmg = OnDmg;
    }
    public void OnDmg()
    {
        if (lifeSystem.life >= 0)
        {
            LifesGO[(int)lifeSystem.life].SetActive(false);
        }
       
        
    }
    public void Replay ()
    {
        lifeSystem.ResetLife();
        Restartlife();
    }

    private void Restartlife()
    {
        for (int i = 0; i<LifesGO.Length; i++)
        {
            LifesGO [i].SetActive(true);
        }
    }
    void OnPlayerkill()
    {
        Debug.Log("Le joueur est mort");
        gameOverMenus.SetActive(true);
    }
}
