using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    
    // Start is called before the first frame update
 /*   void Start()
    {
        
    }*/

     void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.tag);

        Debug.Log("Collision avec" + collision.gameObject.name);
        if (collision.gameObject.tag == "Npc")
        {
            GetComponent<LifeAndScore>().Setlife(-1);
            Debug.Log("Collision avec Npc");
          
        }
        else if (collision.gameObject.tag == "NpcShoot")
        {
            GetComponent<LifeAndScore>().Setlife(-1);
            Debug.Log("Collision avec NpcShoot");
        }
    }
      /* private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collision Trigger avec" + other.gameObject.name);
        if (other.gameObject.name ==" NpcShoot") Destroy(other.gameObject,0.05f);

        GetComponent<LifeAndScore>().NombreEnemieVaincu ++;
        GameObject.Find("UI").GetComponent<NpckilledUI>().setTextNpc(GetComponent<LifeAndScore>().NombreEnemieVaincu);
    }*/
}
