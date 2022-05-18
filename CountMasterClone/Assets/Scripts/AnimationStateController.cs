using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    Animator animator;
    int isRunningHash;
    int isDeadHash;
    void Start()
    {
        animator = GetComponent<Animator>();

        isRunningHash = Animator.StringToHash("isRunning");
        isDeadHash = Animator.StringToHash("isDead");
    }

    // Update is called once per frame
    void Update()
    {
        bool isRunning = Input.GetKey("w");
        bool isDead = Input.GetKey("s");

        if (isRunning)
        {
            animator.SetBool(isRunningHash, true);
        }
        else if(!isRunning)
        {
            animator.SetBool(isRunningHash, false);
        }
        if (isDead)
        {
            animator.SetBool(isDeadHash, true);
        }
    }
}
