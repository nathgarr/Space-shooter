using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private SpriteRenderer playershoot ;
    public float speed = 10f;
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
    }

    void Shoots()
    {
       
    }

    void Move()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
