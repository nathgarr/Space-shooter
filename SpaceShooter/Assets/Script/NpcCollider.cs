using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcCollider : MonoBehaviour
{
 
    void OnTriggerEnter2D(Collider2D collision)
    {

        Debug.Log("Collision avec" + collision.gameObject.name);
        if (collision.gameObject.tag == "PlayerShoot")
        {
            GetComponent<NpcHp>().SetNpcLife(-1);
           /* GetComponent<NpcT2hp>().SetNpcLife2(-1);*/

            /*GetComponent<NpckilledUI>().NombreEnemieVaincu++;
            GameObject.Find("UI").GetComponent<NpckilledUI>.SetTextNpc(GetComponent<NpckilledUI>().NombreEnemieVaincu);*/
        }
        /*else if ()
        {

        }*/
    }
}
