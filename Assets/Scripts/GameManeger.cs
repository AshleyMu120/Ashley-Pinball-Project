using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManeger : MonoBehaviour
{
    [SerializeField] 
    private GameObject ballPrefab, startButton, scoreText, quitButton, restartButton;

    [SerializeField]private int score;
    private int multiplier;
    private int lives;

    [SerializeField] 
    private Vector3 startPos;

    private bool canPlay;

    private GameObject currentBall;

    public static GameManeger instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        InitializeGame();
    }

    private void InitializeGame()
    {
        Time.timeScale = 1;
        score = 0;
        multiplier = 1;
        canPlay = false;
        lives = 3; 

        startButton.SetActive(true);
        scoreText.SetActive(false);
        quitButton.SetActive(false);
        restartButton.SetActive(false);
    }

    public void UpdateScore(int point, int mullIncrease)
    {
        multiplier += mullIncrease;
        score += point * multiplier;
        scoreText.GetComponent<Text>().text = "Score : " + score;
    }

    public void GameEnd()
    {
        lives--; 
        if (currentBall != null)
        {
            Destroy(currentBall); 
        }

        if (lives > 0)
        {
           
            StartCoroutine(WaitAndInstantiateBall(1f)); // Wait for 1 second 
            canPlay = true;
        }
        else
        {
            // Show quit and restart buttons when lives are 0
            Time.timeScale = 0;
            quitButton.SetActive(true);
            restartButton.SetActive(true);
        }
    }

    private IEnumerator WaitAndInstantiateBall(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        currentBall = Instantiate(ballPrefab, startPos, Quaternion.identity);
    }

    public void GameStart()
    {
        Debug.Log("mouse detected");
        startButton.SetActive(false);
        scoreText.SetActive(true);
        currentBall = Instantiate(ballPrefab, startPos, Quaternion.identity);
        canPlay = true;
        lives = 3; 
    }

    public void GameQuit() 
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void GameRestart()
    {
        InitializeGame();
        GameStart();
    }
}

//refer to https://www.youtube.com/watch?v=iPJw8O_J9mk&t=2920s