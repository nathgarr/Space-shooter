using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NpcT1Controler : MonoBehaviour
{
    [SerializeField]
    GameObject projectilePrefab;
    [SerializeField]
    LifeSystem lifeSystem;
    public GameObject start, end;
    public float decalX = 1f;
    public bool ToRight = true;
    public bool ToUp = true;
    public bool Isvertical = false;
    // Start is called before the first frame update
    private void Awake()
    {
        lifeSystem.onKill =OnNpcKilled;
    }
    void Start()
    {
        decalX = Random.Range(decalX,decalX+1f);
        StartCoroutine(FireCorout());
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
    IEnumerator FireCorout()
    {
        while (true)
        {
             float fireDelay = Random.Range(0.8f, 1.5f);
            yield return new WaitForSeconds(fireDelay);
            GameObject projectilInstance=Instantiate(projectilePrefab);
           
             projectilInstance.transform.position = transform.position;  
        }
    }
    void OnNpcKilled()
    {
        gameObject.SetActive(false);
    }
}
