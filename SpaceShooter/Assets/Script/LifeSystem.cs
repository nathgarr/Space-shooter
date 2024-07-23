using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSystem : MonoBehaviour
{

    public float maxLife = 1;
    public float life = 1;
    public System.Action onKill, onDmg;
    public bool isAlive {
        get { return life > 0; }
    }

    public void Awake()
    {
        ResetLife();
    }
    public void SetDmg(float value)
    {
        life -= value;
        if (life < 0) { 

            life = 0;
        }
        if (onDmg != null)
        {
            onDmg();
        }
        if (life <= 0)
        {
            onKill();
        }


    }
    public void ResetLife()
    {
        life = maxLife;

    }
}
