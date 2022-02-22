using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject EnemyPrefab;
    private float minValueX=-9.93f;
    private float minValueY = -1.1f;
    private float space = 2.5f;
    public int enemiestospawn=5;
    private GameManager gamemanager;
    private int enemycount;
    void Start()
    {
        gamemanager = GameObject.Find("GameMnager").GetComponent<GameManager>();
        //if (gamemanager.isGameActive)
        //{
            for (int i = 0; i <= enemiestospawn; i++)
            {
                Instantiate(EnemyPrefab, RandomSpawnPosition(), EnemyPrefab.transform.rotation);
            }
        //}
           
    }
    void Update()
    {
        //if (gamemanager.isGameActive)
        //{
            enemycount = FindObjectsOfType<EnemyShoot>().Length;
            if (enemycount == 0)
            {
                for (int j = 0; j <= enemiestospawn * 2; j++)
                {
                    Instantiate(EnemyPrefab, RandomSpawnPosition(), EnemyPrefab.transform.rotation);
                }
            }
        //}
        
    }
    Vector3 RandomSpawnPosition()
    {
        float spawnPosX = minValueX + (Random.Range(0,9) * space);
        float spawnPosY = minValueY + (Random.Range(0,3) * space);

        Vector3 spawnPosition = new Vector3(spawnPosX, spawnPosY, 0);
        return spawnPosition;
    }
}
