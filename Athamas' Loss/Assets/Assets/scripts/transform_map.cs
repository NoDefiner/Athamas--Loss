using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transform_map : MonoBehaviour
{
    public string transferMapName;
    public string PerfectTransform;

    private player_move thePlayer;


    void Start()
    {
        thePlayer = FindObjectOfType<player_move>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        thePlayer.currentMapName = transferMapName;
        thePlayer.perfectMapName = PerfectTransform;

        if (collision.gameObject.name == "player")
        {
            SceneManager.LoadScene(transferMapName);


        }
    }
}
