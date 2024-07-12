using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NpcT1Controler : MonoBehaviour
{

    [SerializeField]
    float speed = -1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        //fonction deplacement enemi verticale automatiser
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
