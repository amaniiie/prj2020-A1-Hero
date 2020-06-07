using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepScore : MonoBehaviour
{
    public Text scoreText = null;

    // public ScoreScript scores;
    // Start is called before the first frame update
    void Start()
    {
        int thisscore = ScoreScript.scoreValue;
        scoreText.text = "Score " + thisscore;
    }
}
