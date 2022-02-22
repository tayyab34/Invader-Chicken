using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int lives = 5;
    private int timer = 0;
    public TextMeshProUGUI Lives;
    public TextMeshProUGUI Timer;
    public int Spawn;
    public bool isGameActive;
    public GameObject pauseScreen;
    public GameObject DifficultyScreen;
    private bool paused;
    void Start()
    {
        Spawn = GameObject.Find("SpawnManager").GetComponent<SpawnManager>().enemiestospawn;
        Lives.text = "Lives: " + lives;
    }
    void Update()
    {
        //Check if the user has pressed the P key
        if (Input.GetKeyDown(KeyCode.P))
        {
            ChangePaused();
        }
    }

    public void StartGame(int difficulty)
    {
        isGameActive = true;
        Spawn *= difficulty;
        DifficultyScreen.gameObject.SetActive(false);
        StartCoroutine(Time());
    }
    IEnumerator Time()
    {
        //while (isGameActive)
        //{
            yield return new WaitForSeconds(60);
            timer = timer + 1;
            Timer.text = "Time: " + timer;
        //}
       
    }
    public  void AddLives(int livestoadd)
    {
        lives += livestoadd;
        Lives.text = "Lives: " + lives;

        if (lives == 0)
        {
            Destroy(gameObject);
        }
    }
    void ChangePaused()
    {
        if (!paused)
        {
            paused = true;
            pauseScreen.SetActive(true);
        }
        else
        {
            paused = false;
            pauseScreen.SetActive(false);
        }
    }
    private void GameOver()
    {
        isGameActive = false;
    }
}
