using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startpoint : MonoBehaviour
{
    public string startpoint;
    public string PerfectStart; // detail of the SceneTransform

    private player_move thePlayer;
    private Cameracontrol theCamera;

    void Start()
    {
        theCamera = FindObjectOfType<Cameracontrol>();
        thePlayer = FindObjectOfType<player_move>();

        if (startpoint == thePlayer.currentMapName)
        {
            if(PerfectStart == thePlayer.perfectMapName)
            {
                theCamera.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, theCamera.transform.position.z);
                thePlayer.transform.position = this.transform.position;
            }
            
        }

    }


}
