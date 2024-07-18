using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcShoot : MonoBehaviour
{
    public float speed = 12f;
/*    float shoot = GameObject.CreatePrimitive(PrimitiveType type);
*/
    // Start is called before the first frame update
    /*  void Start()
      {

      }*/

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
