using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class MissileControler : MonoBehaviour
{
    private SpriteRenderer playershoot ;
    public float speed = 10f;
    [SerializeField]
    private float ShootDmg = 1f;
    [SerializeField]
    Entity targetType;
    [SerializeField]
    Vector3 moveDirection = Vector3.up;
    [SerializeField]
    float lifeTime = 1f;
    /* float shoot = GameObject.CreatePrimitive(PrimitiveType type);*/


    // Start is called before the first frame update
    void Start()
    {
        playershoot = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Shoots();
        Move();
        lifeTime -= Time.deltaTime;
        if (lifeTime < 0) {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(targetType.ToString())){
            LifeSystem npcHp = collision.gameObject.GetComponent<LifeSystem>();
            if (npcHp != null) {
                
            }
            npcHp.SetDmg(ShootDmg);
        }
    }
    void Shoots()
    {
       
    }

    void Move()
    {
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }
}
public enum Entity { Player , Npc}