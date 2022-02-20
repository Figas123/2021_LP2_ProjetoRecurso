using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Madelinette.Common;

public class MovePiece : MonoBehaviour
{
    private Vector2 currentPosition;
    private Vector2 newPosition;

    void Start()
    {
        currentPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        currentPosition = newPosition;
    }
}
