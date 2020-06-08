using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReScene : MonoBehaviour
{
    public void RestartGame(){
        SceneManager.LoadScene("Starter2DSceneLV2");
        // Application.LoadLevel(Application.loadedLevel);
    }

}
