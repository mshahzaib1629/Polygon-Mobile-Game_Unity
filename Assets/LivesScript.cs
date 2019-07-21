using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LivesScript : MonoBehaviour
{

    public static int life;

    public GameObject life1;
    public GameObject life2;
    public GameObject life3;

    public GameObject gameOverUI;
    public GameObject player;
    public GameObject LeftBtn;
    public GameObject RightBtn;
    public GameObject pauseButton;

    public Text finalScore;
    public Text highestScore;
    public TextMesh highestScoreOptionMenu;
    public Text currentlifeDisplay;
    public static bool isGameOver;


    void Start()
    {
        isGameOver = false;
        
        life = 3;
    }
    // Update is called once per frame
    void Update()
    {
     
        currentlifeDisplay.text = life.ToString();

        switch (life)
        {
            case 3:
                life1.SetActive(true);
                life2.SetActive(true);
                life3.SetActive(true);
                break;
           
            case 2:
                life1.SetActive(true);
                life2.SetActive(true);
                life3.SetActive(false);
                break;

            case 1:
                life1.SetActive(true);
                life2.SetActive(false);
                life3.SetActive(false);
                break;

            case 0:
                life1.SetActive(false);
                life2.SetActive(false);
                life3.SetActive(false);
                gameOverController();
                break;

        }
    }

    void gameOverController()
    {
        isGameOver = true;
        gameOverUI.SetActive(true);

        Destroy(player);
        LeftBtn.SetActive(false);
        RightBtn.SetActive(false);
        pauseButton.SetActive(false);
      
        finalScore.text = Spawner.score.ToString();
        highestScore.text = "Highest Score: " + HighestScoreScript.highestScore.ToString();
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
