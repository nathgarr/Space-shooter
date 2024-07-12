using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NpckilledUI : MonoBehaviour
{
    public Text NpcKilled;
    // Start is called before the first frame update
    void Start()
    {
        NpcKilled.text = "x0";
    }

    // Update is called once per frame
    public void setTextNpc(int value)
    {
        NpcKilled.text = "x" + value.ToString();
    }
}
