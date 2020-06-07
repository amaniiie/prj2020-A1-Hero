using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    public int scoreToWin = 5;
    public Text winText;
    public Text gameOverText;
    public HealthSystem healthSystem;
    public GameObject gameOverPanel,winPanel;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreScript.scoreValue >= scoreToWin)
	    {
			winText.text = "You win!";
			winPanel.SetActive(true);
            gameOverPanel.SetActive(false);
		}

         if (healthSystem.health <= 0 && ScoreScript.scoreValue < scoreToWin){
            gameOverText.text = "Game Over";
	        gameOverPanel.SetActive(true);
            winPanel.SetActive(false);
	    }

    }
}
