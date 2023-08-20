using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimationSwitch : MonoBehaviour
{
    public Animator animator;
    bool isChasing;

    // Start is called before the first frame update
    void Start()
    {
        isChasing = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isChasing) {
            animator.SetTrigger("StartChase");
        }
    }

    public bool ChaseStart() {
        return isChasing = true;
    }
}
