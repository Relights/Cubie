using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreHolder : MonoBehaviour
{
    public Text score;
    public float scores;
    public float highScore;

    void Start()
    {
      scores = 0;

      highScore = PlayerPrefs.GetFloat("MyHighScoreKey", highScore);
    }

    // Update is called once per frame
    void Update()
    {
      score.text = "Score: " + scores;
      PlayerPrefs.SetFloat("MyScoreKey", scores);  
      if(scores > highScore){
        highScore = scores;
        PlayerPrefs.SetFloat("MyHighScoreKey", highScore);
      }

    }
}
