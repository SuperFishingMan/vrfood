using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RoomMovement : MonoBehaviour
{
    public float moveSpeed = 17f;
    public List<Transform> items;
    private System.Random rand = new System.Random();
    private List<string> foods = new List<string>() { "food1", "food2", "food3", "food4", "food5" };

    void Update()
    {
        transform.Translate(-Vector3.forward*moveSpeed*Time.deltaTime);
        if (transform.position.z < -20)
        {
            foreach (Transform obj in items)
            {
                foreach (Transform children in obj)
                {
                    Destroy(children.gameObject);
                }

                var placeit = rand.Next(0, 50);
                if (placeit % 2 == 0)
                {
                    var randIndex = rand.Next(0, foods.Count);

                    string randomfood = foods[randIndex];
                    GameObject food = GameObject.Find(randomfood);
                    GameObject clone1 = (GameObject)Instantiate(food, obj.position, obj.rotation);
                    clone1.transform.parent = obj;
                }
                

            }
            transform.position = transform.position + new Vector3(0, 0, 80);
        }
    }
}