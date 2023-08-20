using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Day2_transform : MonoBehaviour
{
    public string transferMapName;
    public string PerfectTransform;

    private player_move theplayer;


    void Start()
    {
        theplayer = FindObjectOfType<player_move>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        theplayer.currentMapName = transferMapName;
        theplayer.perfectMapName = PerfectTransform;

        if (collision.gameObject.name == "player")
        {
            if (theplayer.nextobjectcheck == true)
            {
                /*Debug.Log("NextPage_transform");*/
                SceneManager.LoadScene(transferMapName);
            }
                


        }
    }
}
