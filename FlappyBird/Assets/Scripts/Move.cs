using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed;
    public float moveRange;
    private GameObject obj;
    private Vector3 oldPosition;
    void Start()
    {
        obj = gameObject;
        oldPosition = obj.transform.position;
        moveSpeed = 5.0f;
        moveRange = 20f;
    }
    void Update()
    {
        obj.transform.Translate(new Vector3(-Time.deltaTime * moveSpeed, 0, 0));
        if (oldPosition.x - obj.transform.position.x > moveRange)
        {
            obj.transform.position = oldPosition;
        }
    }
}
