using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyMove : MonoBehaviour
{
    private Rigidbody2D eRigid;
    //public GameObject target;
    private float x = -12f;
    private float y;
    void Start()
    {
        /*
        eRigid = GetComponent<Rigidbody2D>();
        if (transform.rotation.x > 0)
        {
            eRigid.velocity = new Vector2(-5f, transform.rotation.eulerAngles.z / 240f);
        }
        else
        {
            eRigid.velocity = new Vector2(-5f, -transform.rotation.eulerAngles.z / 240f);
        }
        */
        y = Random.Range(-3f, 3f);
        float rz = Mathf.Acos(x / Mathf.Sqrt(x * x + y * y)) * 4;
        if (y < 0) rz *= -1;
        transform.Rotate(0, 0, rz);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(x/1000, y/1000, 0);
    }
}
