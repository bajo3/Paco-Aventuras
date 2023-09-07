using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public Transform target;
    public Transform farBackground, middleBackground;
    public float minHeight, maxHeight;
    private Vector2 lastPos;

    void Start()
    {
        lastPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Corregir la asignación de posición
        transform.position = new Vector3(target.position.x, Mathf.Clamp(target.position.y, minHeight, maxHeight), transform.position.z);

        Vector2 amountToMove = new Vector2(transform.position.x - lastPos.x, transform.position.y - lastPos.y);

        farBackground.position = farBackground.position + new Vector3(amountToMove.x, amountToMove.y, 0f);

        middleBackground.position += new Vector3(amountToMove.x, 0f, 0f) * 0.5f;

        lastPos = new Vector2(transform.position.x, transform.position.y);
    }
}
