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

    //void Update()
    //{
    //    bool isRunning = Input.GetMouseButton(0);
    //    bool isDead = Input.GetMouseButtonDown(1);

    //    if (isRunning)
    //    {
    //        animator.SetBool(isRunningHash, true);
    //    }
    //    else if(!isRunning)
    //    {
    //        animator.SetBool(isRunningHash, false);
    //    }
    //    if (isDead)
    //    {
    //        animator.SetBool(isDeadHash, true);
    //    }
    //}
}
