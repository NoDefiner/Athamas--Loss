using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class player_move : MonoBehaviour
{
    public string currentMapName; // transferMapName ������ ���� ���� 

    public float moveSpeed;
    public Gamemanager manager;


    private Animator anim;
    
    void Start()
    {
        DontDestroyOnLoad(this.gameObject); 

        anim = GetComponent<Animator>();

    }

  
    void Update()
    {
        if(Input.GetAxisRaw("Horizontal") > 0 || Input.GetAxisRaw("Horizontal")<0)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
        }
        
        if(Input.GetAxisRaw("Vertical")>0 || Input.GetAxisRaw("Vertical") < 0)
        {
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
        }

        anim.SetFloat("Move X", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("Move Y", Input.GetAxisRaw("Vertical"));


    }

    private void FixedUpdate()
    {
        if (DialogueManager.GetInstance().dialogueIsPlaying)
        { 
            moveSpeed = 0;
            return;
        }
        else if(!DialogueManager.GetInstance().dialogueIsPlaying)
        {
            moveSpeed = 2;
        }
        
        
        


    }




}
