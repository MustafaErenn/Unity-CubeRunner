using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMapGenerator : MonoBehaviour
{
    public GameObject obstacle1Prefab;
    public GameObject obstacle2Prefab;
    public GameObject obstacle3Prefab;
    public GameObject obstacle4Prefab;

    public GameObject gold1;
    public GameObject gold2;
    public GameObject gold3;
    

    public GameObject player;

    public int randomNumber;
    public int randomDistance;
    private int randomNumberOld;

    private int randomObstacleDistance;

    private Vector3 line1Vector;
    private Vector3 line2Vector;
    private Vector3 line3Vector;


    private float obstacle1DefaultY = 3.5f;
    private float obstacle2DefaultY = 1.5f;
    private float obstacle3DefaultY = 3.45f;
    private float obstacle4DefaultY = 3.35f;


    

    private float nextObstacleDistance = 5f;
    void Start()
    {
        player = GameObject.Find("Player");
       
    }

   
    void Update()
    {
        if(nextObstacleDistance<450)
        {
            line1();
            line2();
            line3();
            nextObstacleDistance += 10f;
        }
    }

    public void line1()
    {
        randomNumber = Random.Range(1, 5);
        randomDistance = Random.Range(8, 13);
        randomObstacleDistance = Random.Range(5, 15);
        //Debug.Log(randomDistance);
        if (randomNumber==1)//obstacle1 olma ihtimali
        {
            Instantiate(obstacle1Prefab, new Vector3(-4f, obstacle1DefaultY, nextObstacleDistance), Quaternion.identity);
            Instantiate(gold1, new Vector3(-4f, 1.2f, nextObstacleDistance + randomDistance), Quaternion.identity);
            nextObstacleDistance += randomObstacleDistance;
        }
        if(randomNumber == 2 )
        {
            Instantiate(obstacle2Prefab, new Vector3(-4f, obstacle2DefaultY, nextObstacleDistance), Quaternion.identity);
            Instantiate(gold1, new Vector3(-4f, 1.2f, nextObstacleDistance + randomDistance), Quaternion.identity);
            nextObstacleDistance += randomObstacleDistance;
        }
        if (randomNumber == 3)
        {
            Instantiate(obstacle3Prefab, new Vector3(-4f, obstacle3DefaultY, nextObstacleDistance), Quaternion.identity);
            Instantiate(gold1, new Vector3(-4f, 1.2f, nextObstacleDistance + randomDistance), Quaternion.identity);
            nextObstacleDistance += randomObstacleDistance;
        }
        if (randomNumber == 4)
        {
            Instantiate(obstacle4Prefab, new Vector3(-4f, obstacle4DefaultY, nextObstacleDistance), Quaternion.identity);
            Instantiate(gold1, new Vector3(-4f, 1.2f, nextObstacleDistance + randomDistance), Quaternion.identity);
            nextObstacleDistance += randomObstacleDistance;
        }

    }
    public void line2()
    {
        randomNumber = Random.Range(1, 5);
        randomDistance = Random.Range(8, 13);
        randomObstacleDistance = Random.Range(5, 15);
        if (randomNumber == 1)//obstacle1 olma ihtimali
        {
            Instantiate(obstacle1Prefab, new Vector3(0f, obstacle1DefaultY, nextObstacleDistance), Quaternion.identity);
            Instantiate(gold2, new Vector3(-0f, 1.2f, nextObstacleDistance + randomDistance), Quaternion.identity);
            nextObstacleDistance += randomObstacleDistance;
        }
        if (randomNumber == 2)
        {
            Instantiate(obstacle2Prefab, new Vector3(0f, obstacle2DefaultY, nextObstacleDistance), Quaternion.identity);
            Instantiate(gold2, new Vector3(-0f, 1.2f, nextObstacleDistance + randomDistance), Quaternion.identity);
            nextObstacleDistance += randomObstacleDistance;
        }
        if (randomNumber == 3)
        {
            Instantiate(obstacle3Prefab, new Vector3(0f, obstacle3DefaultY, nextObstacleDistance), Quaternion.identity);
            Instantiate(gold2, new Vector3(-0f, 1.2f, nextObstacleDistance + randomDistance), Quaternion.identity);
            nextObstacleDistance += randomObstacleDistance;
        }
        if (randomNumber == 4)
        {
            Instantiate(obstacle4Prefab, new Vector3(0f, obstacle4DefaultY, nextObstacleDistance), Quaternion.identity);
            Instantiate(gold2, new Vector3(-0f, 1.2f, nextObstacleDistance + randomDistance), Quaternion.identity);
            nextObstacleDistance += randomObstacleDistance;
        }
    }
    public void line3()
    {
        randomNumber = Random.Range(1, 5);
        randomDistance = Random.Range(8, 13);
        randomObstacleDistance = Random.Range(5, 15);
        if (randomNumber == 1)//obstacle1 olma ihtimali
        {
            Instantiate(obstacle1Prefab, new Vector3(4f, obstacle1DefaultY, nextObstacleDistance), Quaternion.identity);
            Instantiate(gold3, new Vector3(4f, 1.2f, nextObstacleDistance + randomDistance), Quaternion.identity);
            nextObstacleDistance += randomObstacleDistance;
        }
        if (randomNumber == 2)
        {
            Instantiate(obstacle2Prefab, new Vector3(4f, obstacle2DefaultY, nextObstacleDistance), Quaternion.identity);
            Instantiate(gold3, new Vector3(4f, 1.2f, nextObstacleDistance + randomDistance), Quaternion.identity);
            nextObstacleDistance += randomObstacleDistance;
        }
        if (randomNumber == 3)
        {
            Instantiate(obstacle3Prefab, new Vector3(4f, obstacle3DefaultY, nextObstacleDistance), Quaternion.identity);
            Instantiate(gold3, new Vector3(4f, 1.2f, nextObstacleDistance + randomDistance), Quaternion.identity);
            nextObstacleDistance += randomObstacleDistance;
        }
        if (randomNumber == 4)
        {
            Instantiate(obstacle4Prefab, new Vector3(4f, obstacle4DefaultY, nextObstacleDistance), Quaternion.identity);
            Instantiate(gold3, new Vector3(4f, 1.2f, nextObstacleDistance + randomDistance), Quaternion.identity);
            nextObstacleDistance += randomObstacleDistance;
        }
    }
}
