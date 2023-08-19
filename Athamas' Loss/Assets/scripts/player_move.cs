using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class player_move : MonoBehaviour
{
    static public player_move instance;

    public string currentMapName; // transferMapName 변수의 값을 저장 
    public string perfectMapName; // PerfectTransform 저장. 

    public float moveSpeed;
    public int walkCount;
    private int currentWalkCount;

    private Vector3 vector;

    private BoxCollider2D boxCollider;

    public float runSpeed;
    private float applyRunSpeed;
    private bool applyRunFlag = false;
    private bool canMove = true;

    public Gamemanager manager;
    private Animator anim;
    
    void Start()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(this.gameObject);
            
            anim = GetComponent<Animator>();
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        

    }


    /*void Update()
    {
        if(Input.GetAxisRaw("Horizontal") > 0 || Input.GetAxisRaw("Horizontal")<0)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
        }
        
        if(Input.GetAxisRaw("Vertical")>0 || Input.GetAxisRaw("Vertical") < 0)
        {
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
        }


        anim.SetFloat("DirX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("DirY", Input.GetAxisRaw("Vertical"));
        anim.SetBool("Walking", true);


    }*/

    IEnumerator MoveCoroutine()
    {
        while (Input.GetAxisRaw("Vertical") != 0 || Input.GetAxisRaw("Horizontal") != 0)
        {

           /* if (Input.GetKey(KeyCode.LeftShift))
            {
                applyRunSpeed = runSpeed;
                applyRunFlag = true;
            }
            else
            {
                applyRunSpeed = 0;
                applyRunFlag = false;
            }*/


            vector.Set(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), transform.position.z);

            if (vector.x != 0)
                vector.y = 0;


            anim.SetFloat("DirX", vector.x);
            anim.SetFloat("DirY", vector.y);
            anim.SetBool("Walking", true);

            while (currentWalkCount < walkCount)
            {
                if (Input.GetAxisRaw("Horizontal") > 0 || Input.GetAxisRaw("Horizontal") < 0)
                {
                    transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
                }

                if (Input.GetAxisRaw("Vertical") > 0 || Input.GetAxisRaw("Vertical") < 0)
                {
                    transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
                }

                /*if (applyRunFlag)
                    currentWalkCount++;*/
                currentWalkCount++;
                yield return new WaitForSeconds(0.01f);
            }
            currentWalkCount = 0;

        }
        anim.SetBool("Walking", false);
        canMove = true;

    }

    // Update is called once per frame
    void Update()
    {

        /*if (canMove)
        {
            if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
            {
                canMove = false;
                StartCoroutine(MoveCoroutine());
            }
        }*/

    }

    private void FixedUpdate()
    {
        if (canMove)
        {
            if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
            {
                canMove = false;
                StartCoroutine(MoveCoroutine());
            }
        }

        if (DialogueManager.GetInstance().dialogueIsPlaying)
        { 
            moveSpeed = 0;
            return;
        }
        else if (!DialogueManager.GetInstance().dialogueIsPlaying)
        {
            moveSpeed = 4;
        }


    }




}
