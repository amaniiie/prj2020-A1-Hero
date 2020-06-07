using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackLevel : MonoBehaviour
{
    public void StartNewGame(){
        SceneManager.LoadScene("Starter2DScene");
    }
}
