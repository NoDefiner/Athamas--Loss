using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startpoint : MonoBehaviour
{
    public string startpoint;
    private player_move thePlayer;


    void Start()
    {
        thePlayer = FindObjectOfType<player_move>();
        if (startpoint == thePlayer.currentMapName)
        {
            thePlayer.transform.position = this.transform.position;
        }
    }


}
