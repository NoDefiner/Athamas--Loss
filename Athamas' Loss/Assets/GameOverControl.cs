using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverControl : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        Color color = player.GetComponent<SpriteRenderer>().color;
        color.a = 0;
        player.GetComponent<SpriteRenderer>().color = color;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R)) {
            player = GameObject.Find("player");
            Color color = player.GetComponent<SpriteRenderer>().color;
            color.a = 255;
            player.GetComponent<SpriteRenderer>().color = color;
            SceneManager.LoadScene("SampleScene");
        }
        if (Input.GetKey(KeyCode.Q)) {
            Application.Quit();
        }
    }
}
