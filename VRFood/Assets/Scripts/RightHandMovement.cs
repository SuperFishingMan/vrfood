using System;
using UnityEngine;
using System.Collections;

public class RightHandMovement : MonoBehaviour
{

    public Transform camera;
    public Transform hand;

    private Vector3 copypos;
    private Quaternion copyrot;

    // Use this for initialization
    void Start()
    {
        copypos = hand.transform.position;
        copyrot = hand.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (camera.rotation.y >= 0)
        {
            hand.parent = camera;

        }
        else
        {
            hand.parent = null;
            hand.transform.rotation = copyrot;
            hand.transform.position = copypos;
        }
      
    }
}
