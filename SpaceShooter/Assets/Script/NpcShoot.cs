using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcShoot : MonoBehaviour
{
    public float speed = 12f;
   
    void Update()
    {
        Move();
    }
    void Move()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
