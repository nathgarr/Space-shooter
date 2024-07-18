using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField]
    float speed = 20f;
    [SerializeField]
    GameObject projectilePrefab;

    float lastFire;
    [SerializeField]
    SpriteRenderer spriteRenderer;

    [SerializeField]
    List<Sprite> PlayerSprite;
    // Update is called once per frame
    private float fixedDeltaTime;
   
    
    void Update()
    {
        Move();
        if (Input.GetAxis("Fire")>0)
        {

            Fire();

        }
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
            if (xAxis < 0)
            {
                spriteRenderer.sprite = PlayerSprite[1];
            }
            else if (xAxis == 0)
            {
                spriteRenderer.sprite = PlayerSprite[0];
            }
            else if (xAxis > 0)
            {
                spriteRenderer.sprite = PlayerSprite[2];
            }
        }
        else if (LifeAndScore.gameover){
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameObject.Find("Player").GetComponent<LifeAndScore>().Replay();
            }
        }
        
    }
    
    void Fire()
    {
        GameObject projectilInstance=Instantiate(projectilePrefab);
        projectilInstance.transform.position = transform.position;  
        lastFire = Time.time;
        projectilInstance.gameObject.tag = "PlayerShoot";

        
    }
}
