using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityDestroy : MonoBehaviour
{
    void Start()
    {
    }
    
    void OnTriggerEnter2D(Collider2D otherObj)
    {
        if (otherObj.gameObject.tag == "Enemy")
        {
            Destroy(otherObj.gameObject);
        }
        else if (otherObj.gameObject.tag == "Item")
        {
            Destroy(otherObj.gameObject);
        }
        else if (otherObj.gameObject.tag == "ItemIcon")
        {
            Destroy(otherObj.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
