using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public float spawnRate = 0f;

    public GameObject hexagonPrefab;

    public float nextTimeToSpawn = 0f;
    
    public static int score;
    public Text displayScore;

    void Start()
    {
        score = 0;
        Screen.SetResolution((int)Screen.width, (int)Screen.height, true);
    }

    // Update is called once per frame
    void Update()
    {
       
        if (score > HighestScoreScript.highestScore)
            HighestScoreScript.highestScore = score;

        Debug.Log("highest score: " + HighestScoreScript.highestScore);
        displayScore.text = score.ToString();

        if (Time.time > nextTimeToSpawn)
        {
            Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity);
            if (score <=5)
            { nextTimeToSpawn = Time.time + 5f; }
            else if(score>5 && score <= 15)
            {
                nextTimeToSpawn = Time.time + 3f;

            }
            else if(score > 15 && score <= 30)
            {
                nextTimeToSpawn = Time.time + 2f;

            }
            else
            {
                nextTimeToSpawn = Time.time + 1f;
            }


        }
    }
}
