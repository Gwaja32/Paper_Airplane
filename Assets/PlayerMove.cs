using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameController GameController;
    private Rigidbody2D pRigid;
    void Start()
    {
        pRigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        pRigid.AddForce(new Vector2(9f, -9f));
        if (Input.GetKey(KeyCode.A))
        {
            pRigid.AddForce(new Vector2(-18f, 0f));
            if (pRigid.velocity.x < -10f)
            {
                pRigid.velocity = new Vector2(-9f, pRigid.velocity.y);
            }
        }
        //--------------
        if (Input.GetKey(KeyCode.D))
        {
            pRigid.AddForce(new Vector2(3.5f, 0f));
            if (pRigid.velocity.x > 12f)
            {
                pRigid.velocity = new Vector2(12f, pRigid.velocity.y);
            }
        }
        else if(pRigid.velocity.x > 6f)
        {
            pRigid.AddForce(new Vector2(-13f, 0));
        }
        //--------------
        if (Input.GetKey(KeyCode.W))
        {
            pRigid.AddForce(new Vector2(0f, 18f));
            if (pRigid.velocity.y > 10f)
            {
                pRigid.velocity = new Vector2(pRigid.velocity.x, 9f);
            }
        }
        //--------------
        if (Input.GetKey(KeyCode.S))
        {
            pRigid.AddForce(new Vector2(0f, -3.5f));
            if (pRigid.velocity.y < -12f)
            {
                pRigid.velocity = new Vector2(pRigid.velocity.x, -12f);
            }
        }
        else if (pRigid.velocity.y < -6f)
        {
            pRigid.AddForce(new Vector2(0, 13f));
        }
    }
    void OnTriggerEnter2D(Collider2D otherObj)
    {
        if (otherObj.gameObject.tag == "Enemy")
        {
            Time.timeScale = 0;
            GameObject[] es = GameObject.FindGameObjectsWithTag("Enemy");
            GameObject[] its = GameObject.FindGameObjectsWithTag("Item");
            GameObject[] itis = GameObject.FindGameObjectsWithTag("ItemIcon");
            foreach (GameObject o in es) Destroy(o);
            foreach (GameObject o in its) Destroy(o);
            foreach (GameObject o in itis) Destroy(o);
            GameController.GameOver();
        }
    }
}
