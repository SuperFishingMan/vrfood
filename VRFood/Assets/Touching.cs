using UnityEngine;
using System.Collections;
using System;

public class Touching : MonoBehaviour {

    public TextMesh hp;
    // Use this for initialization
    void Start () {
	
	}
	

    void OnTriggerEnter(Collider obj)
    {
        foreach (Transform item in obj.transform)
        {
            Debug.Log(item.name);
            int currentHp = Int32.Parse(hp.text);
            currentHp += 1;
            hp.text = currentHp.ToString();
            Destroy(item.gameObject);
        }
    }
	// Update is called once per frame
	void Update () {
	
	}
}
