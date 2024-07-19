using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcHp : MonoBehaviour
{
    public int NpcT1Life = 1;
    /*public int NpcT2Life = 2;
    public int NpcT3Life = 3;*/
    public void SetNpcLife(int value) {
        NpcT1Life += value;
        if (NpcT1Life > 0)
        {
            NpcT1Life = (NpcT1Life - value);
        }
        else if (NpcT1Life == 0)
        {
            GameObject.Find("NpcT1").SetActive(false);
            /*SetTextNpc(-1);*/
        }
        
        /*if (NpcT1Life > 0)
        {
            NpcT1Life = (NpcT1Life - value);
        }
        else if (NpcT1Life == 0)
        {
            GameObject.Find("NpcT2").SetActive(false);
        }
        if (NpcT1Life > 0)
        {
            NpcT1Life = (NpcT1Life - value);
        }
        else if (NpcT1Life == 0)
        {
            GameObject.Find("NpcT3").SetActive(false);
        }*/

    }
    public void NpcRevive()
    {
        NpcT1Life = 1;
        
    }
}
