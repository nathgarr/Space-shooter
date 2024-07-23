using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcT2hp : MonoBehaviour
{
    public int NpcT1VariantLife = 1;
    /*public int NpcT2Life = 2;
    public int NpcT3Life = 3;*/
    public void SetNpcLife2(int value)
    {
        NpcT1VariantLife += value;
        if (NpcT1VariantLife > 0)
        {
            NpcT1VariantLife = (NpcT1VariantLife - value);
        }
        else if (NpcT1VariantLife == 0)
        {
            GameObject.Find("NpcT1Variant").SetActive(false);


            /*SetTextNpc(1);*/
        }
         }
    }
