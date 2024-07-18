using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcT2hp : MonoBehaviour
{
    public int NpcT2Life = 1;
    public void SetNpcLife2(int value)
    {
        NpcT2Life += value;
        if (NpcT2Life > 0)
        {
            NpcT2Life = (NpcT2Life - value);
        }
        else if (NpcT2Life == 0)
        {
            GameObject.Find("NpcT2").SetActive(false);
        }
    }
}
