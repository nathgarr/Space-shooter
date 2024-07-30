using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEditor.EditorTools;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class LifeSystem : MonoBehaviour
{

    public float maxLife = 1;
    public float life = 1;
    public System.Action onKill, onDmg, onNpcKill;
    public GameObject Player;
    public float onHit = 0.5f;
    private float nextHit = 0.0f;
    float lastHit;
    public bool isAlive
    {
        get { return life > 0; }
    }

    public void Awake()
    {
        ResetLife();
    }
    public void SetDmg(float value)
    {
        life -= value;
        if (life < 0)
        {

            life = 0;
        }
        if (onDmg != null)
        {
            onDmg();
            OnHit();
        }
        if (life <= 0)
        {
            onKill();
            /* OnExplode();*/
            if (maxLife == 1)
            {
                OnNpcKill();

            }
            else if (maxLife == 2)
            {
                OnNpcKill();
            }
            else if (maxLife == 3)
            {
                gameObject.SetActive(false);
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
    void OnHit()
    {
        var PlayerRenderer = Player.GetComponent<Renderer>();
        int delayMilisec = 1;
        lastHit = Time.time;
        nextHit = Time.time + delayMilisec;
        if (Time.time < nextHit)
        {
            GetComponent<Renderer>();
            Color customColor = new Color(1f, 1f, 1f, 0.6f);
            PlayerRenderer.material.SetColor("_Color", customColor);
        }
        if (Time.time == nextHit)
        {
            Color playerBase = new Color(1f, 1f, 1f, 1f);
            PlayerRenderer.material.SetColor("_Color", playerBase);
        }
    }
    /*void OnExplode()
    {
        GetComponent<Renderer>();
        Renderer.Instantiate(gameObject);
    }*/
    // Create a new RGBA color using the Color constructor and store it in a variable
    // Call SetColor using the shader property name "_Color" and setting the color to the custom color you created
}
