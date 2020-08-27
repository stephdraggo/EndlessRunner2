using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public static float speed;
    public float increase, spawnTimer, spawnRate, timer, min, max;
    //prefab object
    public GameObject prefab;
    void Start()
    {
        //speed reset to 0
        speed = 5;
        min = 2;
        max = 4;
    }

    void Update()
    {
        timer += Time.deltaTime;
        spawnTimer += Time.deltaTime;
        //speed increases by time in a small increment
        if(timer >= .5f)
        {
            speed += increase;
            if(min > .5f)
            {
                min -= 0.25f;
            }
            if(max > 1)
            {
                max -= .025f;
            }
            timer = 0;
        }
        if(spawnTimer >= spawnRate)
        {
            Spawn();
            spawnTimer = 0;
            spawnRate = Random.Range(min,max);
        }
    }

    void Spawn()
    {
        Instantiate(prefab,transform.position,Quaternion.identity);
    }
}
