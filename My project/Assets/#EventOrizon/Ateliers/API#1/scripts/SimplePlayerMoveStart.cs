using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayerMoveStart : MonoBehaviour {
    [SerializeField]
    private SpriteRenderer renderer;

    [SerializeField]
    private float moveCoeff;
    // Start is called before the first frame update
    void Start () {
        renderer = GetComponent<SpriteRenderer> ();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey (KeyCode.LeftArrow)) {
            transform.Translate (Vector3.left * moveCoeff * Time.deltaTime);
            renderer.flipX = false;
        } else if (Input.GetKey (KeyCode.RightArrow)) {
            transform.Translate (Vector3.right * moveCoeff * Time.deltaTime);
            renderer.flipX = true;
        }

        if (Input.GetKey (KeyCode.UpArrow)) {
            transform.Translate (Vector3.up * moveCoeff * Time.deltaTime);
        } else if (Input.GetKey (KeyCode.DownArrow)) {
            transform.Translate (Vector3.down * moveCoeff * Time.deltaTime);
        }
    }

}