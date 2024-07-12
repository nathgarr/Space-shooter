using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item2DStart : MonoBehaviour
{
    [SerializeField]
    private int scoreItem;

    public int getScoreItem () {
        return scoreItem;
    }
}
