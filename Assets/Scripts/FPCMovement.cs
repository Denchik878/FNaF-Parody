using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPCMovement : StateMachineBehaviour
{
    private Animator animator;
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (Input.mousePosition.x < Screen.width / 6)
        {
            animator.SetTrigger("Left");
        }
        if (Input.mousePosition.x > Screen.width / 6 * 5)
        {
            animator.SetTrigger("Right");
        }
    }
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.ResetTrigger("Right");
        animator.ResetTrigger("Left");
    }
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.ResetTrigger("Right");
        animator.ResetTrigger("Left");
    }
}