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
    [SerializeField]
    LifeSystem lifeSystem;
    // Update is called once per frame
    private float fixedDeltaTime;

    public float fireRate = 0.5f;
    private float nextFire = 0.0f;

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
        if (lifeSystem.isAlive)
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
        
    }
    
    void Fire()
    {

         /*  GameObject projectilInstance=Instantiate(projectilePrefab);
         *  V1
        projectilInstance.transform.position = transform.position;  
        lastFire = Time.time;
        projectilInstance.gameObject.tag = "PlayerShoot";*/
         //V2
        if (Input.GetButton("Fire") && Time.time > nextFire)
        {
            lastFire = Time.time;
            nextFire = Time.time + fireRate;
            Instantiate(projectilePrefab, transform.position, transform.rotation);
            projectilePrefab.gameObject.tag = ("PlayerShoot");
            if ( lastFire == 3f)
            {
                Destroy(projectilePrefab);
            }
        }

    }
}
