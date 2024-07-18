using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NpcT1Controler : MonoBehaviour
{
    public GameObject start, end;
    public float decalX = 1f;
    public bool ToRight = true;
    public bool ToUp = true;
    public bool Isvertical = false;
    // Start is called before the first frame update
    void Start()
    {
        decalX = Random.Range(decalX,decalX+1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (!Isvertical)
        {
            if (ToRight)
            {
                if (transform.position.x < end.transform.position.x)
                {
                    transform.Translate(new Vector3(Random.Range(decalX, decalX + 1f) * Time.deltaTime, 0, 0));
                }
                else {
                    ToRight = false;
                }
            }
            else {
                if (transform.position.x > start.transform.position.x)
                {
                    transform.Translate(new Vector3(Random.Range(decalX, decalX + 1f) * Time.deltaTime * -1, 0, 0));
                }
                else
                {
                    ToRight = true;
                }
            }
        }
        else  {
            if (ToUp){
                if (transform.position.y < end.transform.position.y)
                {
                    transform.Translate(new Vector3(0 ,Random.Range(decalX, decalX + 1f) * Time.deltaTime, 0));
                }
                else { 
                    ToUp = false;
                }
            }
            else
            {
                if (transform.position.y > start.transform.position.y)
                {
                    transform.Translate(new Vector3(0 ,Random.Range(decalX, decalX + 1f) * Time.deltaTime * -1, 0));
                }
                else
                {
                    ToUp = true;
                }
            }
        }
    }
    
}
