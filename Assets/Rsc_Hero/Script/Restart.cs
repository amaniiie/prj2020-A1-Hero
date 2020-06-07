using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void RestartGame(){
        SceneManager.LoadScene("Starter2DScene");
        // Application.LoadLevel(Application.loadedLevel);
    }

    
    // void Update() {
    //     if (Input.GetKeyDown(KeyCode.Mouse0))
    //     {
    //         Application.LoadLevel(Application.loadedLevel);
    //     }
    // }
}
