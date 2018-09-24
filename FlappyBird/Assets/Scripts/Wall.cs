using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public float moveSpeed;
    public float moveRange;
    public float randRange;
    private GameObject obj;
    private Vector3 oldPosition;
    void Start()
    {
        obj = gameObject;
        oldPosition = obj.transform.position;
        moveSpeed = 5.0f;
        randRange = 3.0f;
        obj.transform.position = new Vector3(oldPosition.x, oldPosition.y + Random.Range(-randRange, randRange), oldPosition.z);
    }
    void Update()
    {
        obj.transform.Translate(new Vector3(-Time.deltaTime * moveSpeed, 0, 0));
        if (obj.transform.position.x < -7)
        {
            obj.transform.position = new Vector3(24, oldPosition.y + Random.Range(-randRange, randRange), oldPosition.z);
        }
    }
}
