using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHitBox : MonoBehaviour
{
    BoxCollider2D playerDead;
    // Start is called before the first frame update
    void Start()
    {
        playerDead = GetComponent<BoxCollider2D>();
    }

    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Player")) {
            SceneManager.LoadScene("Game_Over");
        }
    }
}
