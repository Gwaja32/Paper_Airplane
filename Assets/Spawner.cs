using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Spawner : MonoBehaviour
{
    float currTime;
    float currItemTime;
    float randTime;
    float itemTime;
    public GameObject birdPrefab;
    public GameObject planePrefab;
    private BoxCollider2D area;
    Vector2 basePosition;
    Vector2 size;
    int log;

    void Start()
    {
        area = GetComponent<BoxCollider2D>();
        randTime = 3;
        itemTime = 7;
        basePosition = transform.position;
        size = area.size;
        log = 10;
    }
    
    void Update()
    {
        currTime += Time.deltaTime;
        currItemTime += Time.deltaTime;
        if (currTime > randTime)
        {
            log += 5;
            currTime = 0;
            for(int i = 0; i < Mathf.Log(log, 2); i++)
            {
                float posX = basePosition.x + Random.Range(-size.x / 2f, size.x / 2f);
                float randY = Random.Range(-size.y / 2f, size.y / 2f);
                float posY = basePosition.y + randY;
                //float rand = Random.Range(-size.y / 2f - (randY / (size.y / 2f)) * 30, size.y / 2f - (randY / (size.y / 2f)) * 30);
                Instantiate(birdPrefab, new Vector3(posX, posY, 0), new Quaternion(0, 180, 0, 0));
            }
            randTime = Random.Range(1.5f, 3f);
        }
        if (currItemTime > itemTime)
        {
            currItemTime = 0;
            float posX = basePosition.x + Random.Range(-size.x / 3f, size.x / 3f);
            float posY = basePosition.y + Random.Range(-size.y / 3f, size.y / 3f);
            Instantiate(planePrefab, new Vector3(posX, posY, 0), new Quaternion(0, 180, 0, 0));
            itemTime = 7;
        }
    }
}
