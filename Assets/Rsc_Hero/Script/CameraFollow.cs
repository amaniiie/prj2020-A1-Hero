using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector2(player.position.x, player.position.y);
        if(player != null)
        {
            transform.position = new Vector2(Mathf.Clamp(player.position.x, -350f, 350f),
                                             Mathf.Clamp(player.position.y, -397f, 397f));
        }
    }
}
