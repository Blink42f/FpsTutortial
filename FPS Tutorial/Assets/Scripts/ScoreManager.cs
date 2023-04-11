using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms.Impl;
using System.ComponentModel;
using System;

public class ScoreManager : MonoBehaviour
{
    public float score;
    public float Highscore;

    public GameManager gameManager;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;

    void Update()
    {
        score += Time.deltaTime;
        scoreText.text = ("Score =",(int)score).ToString();
       
   
    }








































    /* public int[] highScores = new int[10];
     public TMP_Text highscoresText = null;
     public TextMeshPro scoreText;


     string currentDirectory;
     public string scoreFileName = "highscores.txt";




     // Start is called before the first frame update
     void Start()
     {
         currentDirectory = Application.dataPath; 
         LoadScoresFromFile();
     }

     // Update is called once per frame
     void Update()
     {
         scoreText.text = Score.ToString();  Time.deltaTime;
     }

     public void SaveScoresToFile()
     {
         StreamWriter fileWriter = new StreamWriter(currentDirectory + "\\" + scoreFileName);

         for(int i = 0; i < highScores.Length; i++)
         {
             fileWriter.WriteLine(highScores[i]);
         }
         fileWriter.Close();
     }

     public void AddScoreToHighScore(int newScore)
     {
         int desiredIndex = -1;
         for(int i = 0; i < highScores.Length;i++)
         {
             if (highScores[i] < newScore || highScores[i] == 0)
             {
                 desiredIndex = i;
                 break;
             }
         }

         if(desiredIndex < 0)
         {
             return;
         }

         for(int i = highScores.Length - 1; i > desiredIndex; i--)
         {
             highScores[i] = highScores[i - 1];
         }

         highScores[desiredIndex] = newScore;

     }

    public void LoadScoresFromFile()
     {
         bool fileExists = File.Exists(currentDirectory + "\\" + scoreFileName);

         if(fileExists)
         {
             Debug.Log("Found high score file" + scoreFileName);
         }
         else
         {
             Debug.Log("File does not exist. Scores will not be loaded");
             return;
         }

         highScores = new int[highScores.Length];

         StreamReader fileReader = new StreamReader(currentDirectory + "\\" + scoreFileName);

         int scoreCount = 0;

         while(fileReader.Peek() != 0 && scoreCount < highScores.Length) 
         {
             string fileLine = fileReader.ReadLine();

             int readScore = -1;
             bool didParse = int.TryParse(fileLine, out readScore);

             if(didParse)
             {
                 highScores[scoreCount] = readScore;
             }
             else
             {
                 Debug.Log("Score is invalid");
                 highScores[scoreCount] = 0;
             }

             scoreCount++;
         }

         fileReader.Close();
     } */


}
