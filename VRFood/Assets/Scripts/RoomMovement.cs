using UnityEngine;
using System.Collections;

public class RoomMovement : MonoBehaviour
{
    public float moveSpeed = 8f;

    
    void Update()
    {
        transform.Translate(-Vector3.forward*moveSpeed*Time.deltaTime);
        if (transform.position.z < -20)
        {
            transform.position = transform.position + new Vector3(0, 0, 80);
        }
    }
}