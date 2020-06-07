using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumHealth : MonoBehaviour
{
    public Text numText = null;
   

    public HealthSystem healthSystem;
    
    
    void Update()
    {
        int thisnumber = healthSystem.health;
        numText.text = ""+thisnumber;

    }
}
