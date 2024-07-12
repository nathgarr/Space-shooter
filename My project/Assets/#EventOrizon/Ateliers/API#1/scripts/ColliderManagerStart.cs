using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderManagerStart : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.CompareTag("Bonus")){
            Debug.Log(" contact avec Bonus");
        }
    }
}
