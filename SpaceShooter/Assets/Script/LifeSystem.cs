using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.EditorTools;
using UnityEngine;

public class LifeSystem : MonoBehaviour
{

    public float maxLife = 1;
    public float life = 1;
    public System.Action onKill, onDmg, onNpcKill;  
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
            if (maxLife == 1) {
                OnNpcKill();
            }
            else if (maxLife==2) {
                OnNpcKill();
            }
           
        }
    }
    public void ResetLife()
    {
        life = maxLife;

    }
    void OnNpcKill()
    {
        NpckilledUI.I.numberNpcKilled++;
    }
}
