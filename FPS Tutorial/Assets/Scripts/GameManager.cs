using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public ScoreManager scoreManager;
    public string Scene = string.Empty;

    public List<GameObject> targets = new List<GameObject>();

    float gameTimer;

    enum GameState { Start, Playing, Gameover};
    GameState gameState;



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start was called");
        Cursor.visible = false;
        
        Cursor.lockState = CursorLockMode.Locked;
        Screen.fullScreen = true;
        gameState = GameState.Start;
    }

    // Update is called once per frame
    void Update()
    {
        switch (gameState)
        {
            case GameState.Start:
                gameTimer = 0;
                gameState = GameState.Playing;

                break;
            case GameState.Playing:
                gameTimer += Time.deltaTime;

                int seconds = Mathf.RoundToInt(gameTimer);

                bool gameOver = true;

                for(int i = 0; i < targets.Count; i++)
                {
                    if (targets[i].activeSelf == true)
                    {
                        gameOver = false;
                    }
                }
                if(gameOver)
                {
                    gameState = GameState.Gameover;
                    /*scoreManager.AddScoreToHighScore(seconds);
                    scoreManager.SaveScoresToFile(); */
                }
                break;

            case GameState.Gameover:
                Time.timeScale = 0.2f;
                StartCoroutine(WAIT());
                break;
        }

        
        if(Input.GetKey(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.lockState = CursorLockMode.Confined;
        }
       
        IEnumerator WAIT()
        {
            yield return new WaitForSeconds(0.2f);
            Debug.Log("Waited");
            Application.LoadLevel(Scene);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.lockState = CursorLockMode.Confined;
            Time.timeScale = 1.0f; 
        }

        
    }
}
