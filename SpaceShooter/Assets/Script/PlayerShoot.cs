using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private SpriteRenderer playershoot ;
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        playershoot = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        shoot();
        Move();
    }

    void shoot()
    {
       
    }

    void Move()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
