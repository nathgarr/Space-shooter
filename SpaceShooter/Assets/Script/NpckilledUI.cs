using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NpckilledUI : MonoBehaviour
{
    public Text NpcKilled;
    public static NpckilledUI I;
    public float numberNpcKilled = 0;

    // Start is called before the first frame update
    void Start()
    {
        NpcKilled.text = "x0 Npc Killed";
        I = this;
    }

    private void Update()
    {
        SetTextNpc();
    }

    // Update is called once per frame
    public void SetTextNpc()
    {
        NpcKilled.text = "x" + numberNpcKilled.ToString() + "Npc Killed";
    }
}
