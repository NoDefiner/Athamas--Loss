using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cameracontrol : MonoBehaviour
{
    static public Cameracontrol instance;

    public GameObject target;
    public float moveSpeed;
    private Vector3 targetPosition;

    

    void Start()
    {
        if(instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
            instance = this;
            targetPosition.Set(target.transform.position.x, target.transform.position.y, this.transform.position.z);
        }
       
        
       
    }

    // Update is called once per frame
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "SampleScene")
        {
            return;
        }
        else if (target.gameObject != null)
        {
            targetPosition.Set(target.transform.position.x, target.transform.position.y, this.transform.position.z);
            this.transform.position = Vector3.MoveTowards(this.transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }


        /*if (target.gameObject != null)
        {
            targetPosition.Set(target.transform.position.x, target.transform.position.y, this.transform.position.z);

            this.transform.position = Vector3.MoveTowards(this.transform.position, targetPosition, moveSpeed * Time.deltaTime);

        }*/




    }
}
