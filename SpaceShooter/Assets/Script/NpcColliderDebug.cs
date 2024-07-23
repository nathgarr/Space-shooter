using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcColliderDebug : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {

        Debug.Log("Collision avec" + collision.gameObject.name);
        if (collision.gameObject.tag == "PlayerShoot")
        {
            GetComponent<NpcT2hp>().SetNpcLife2(-1);
        }
        
    }
}
