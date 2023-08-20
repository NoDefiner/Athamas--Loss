using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class DialogueTrigger : MonoBehaviour
{
    [Header("VisualQue")]
    [SerializeField] private GameObject VisualQue;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    private bool playerInRange;

    AudioSource audioSource;

    private void Awake()
    {
        playerInRange = false;
        VisualQue.SetActive(false);
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying)
        {
            VisualQue.SetActive(true);
            
            /*if (InputManager.GetInstance().GetInteractPressed())
            {
                DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
            }*/
            if(Input.GetKeyDown("i"))
            {
                DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
                if (!audioSource.isPlaying) {
                    audioSource.Play();
                }
            }
        }
        else
        {
            VisualQue.SetActive(false);
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
