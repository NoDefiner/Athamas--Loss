using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextObjectcheck_bed : MonoBehaviour
{
    private player_move theplayer;

    [Header("VisualQue")]
    [SerializeField] private GameObject VisualQue;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    private bool playerInRange;
    public bool nextbedDialogue = false;

    private void Awake()
    {
        theplayer = FindObjectOfType<player_move>();

        playerInRange = false;
        VisualQue.SetActive(false);
    }

    public void Update()
    {
        

        if (theplayer.nextobjectcheck == true) // 참가서 들고있음 유무 판단.
        {
            
            if (playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying)
            {
                VisualQue.SetActive(true);

                /*if (InputManager.GetInstance().GetInteractPressed())
                {
                    DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
                }*/
                if (Input.GetKeyDown("i"))
                {
                    Debug.Log("nextbed_check");
                    DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
                    nextbedDialogue = true;
                }
            }
            else
            {
                VisualQue.SetActive(false);
            }
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = false;
        }
    }
}
