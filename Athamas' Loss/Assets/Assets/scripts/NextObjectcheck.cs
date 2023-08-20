using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextObjectcheck : MonoBehaviour
{
    

    public bool NextObjectchecking = false;

    


    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            NextObjectchecking = true;
            Debug.Log("next chek");
        }
    }

    


}
