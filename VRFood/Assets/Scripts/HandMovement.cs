using UnityEngine;
using System.Collections;

public class HandMovement : MonoBehaviour
{

    public Transform camera;
    public Transform hand;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update ()
	{
	    hand.parent = camera;
	}
}
