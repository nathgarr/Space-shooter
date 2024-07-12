using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField]
    float speed = 20f;
   /* float shoot = GameObject.CreatePrimitive(PrimitiveType type);*/
 

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        if (!LifeAndScore.gameover)
        {
             float xAxis = Input.GetAxis("Horizontal");
             float yAxix = Input.GetAxis("Vertical");
             Vector3 pos =transform.position;
             pos.x = pos.x + (xAxis * speed * Time.deltaTime);
             pos.y = pos.y + (yAxix * speed * Time.deltaTime);
             transform.position = pos;
        }
        else if (LifeAndScore.gameover){
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameObject.Find("player").GetComponent<LifeAndScore>().replay();
            }
        }
        
    }


}
