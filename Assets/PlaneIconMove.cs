using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneIconMove : MonoBehaviour
{
    public GameObject planePrefab;
    float ypos;
    // Start is called before the first frame update
    void Start()
    {
        ypos = Random.Range(-12f, 12f);
    }

    void OnTriggerEnter2D(Collider2D otherObj)
    {
        if (otherObj.gameObject.tag == "Player")
        {
            float posX = transform.position.x;
            float posY = transform.position.y;
            Instantiate(planePrefab, new Vector3(posX, posY, 0), new Quaternion(0, 0, 0, 0));
            Destroy(gameObject);
        }
        else if (otherObj.gameObject.tag == "Bounce")
        {
            ypos *= -1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(12f / 1000, ypos / 1000, 0);
    }
}
