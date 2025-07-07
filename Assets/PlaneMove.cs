using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D otherObj)
    {
        if (otherObj.gameObject.tag == "Enemy")
        {
            Destroy(otherObj.gameObject);
            Counter.score += 100;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(12f / 1000, 0, 0);
        if (transform.position.x >= 53)
        {
            Destroy(gameObject);
        }
    }
}
