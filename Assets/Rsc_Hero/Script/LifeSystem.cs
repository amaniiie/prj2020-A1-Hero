using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeSystem : MonoBehaviour
{
    public int startingLives;
    public int lifeCounter;
    private Text theText;

    // Start is called before the first frame update
    void Start()
    {
        theText = GetComponent<Text>();
        lifeCounter = startingLives;
    }

    // Update is called once per frame
    void Update()
    {
        theText.text = "x " + lifeCounter;
    }

    public void giveLife()
    {
        lifeCounter++;
    }

    public void takeLife()
    {
        lifeCounter--;
    }
}
