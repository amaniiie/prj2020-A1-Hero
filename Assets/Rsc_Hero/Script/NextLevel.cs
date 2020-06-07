using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public void StartNewGame(){
        SceneManager.LoadScene("Starter2DSceneLV2");
        // Application.LoadLevel(Application.loadedLevel);
    }

    
    // void Update() {
    //     if (Input.GetKeyDown(KeyCode.Mouse0))
    //     {
    //         Application.LoadLevel(Application.loadedLevel);
    //     }
    // }
}
