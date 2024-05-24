using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPCMovement : MonoBehaviour
{
    private Animator animator;
    private CameraPosition cameraPosition = CameraPosition.FacingCenter;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        if (Input.mousePosition.x < Screen.width / 6 && cameraPosition == CameraPosition.FacingCenter)
        {
            cameraPosition = CameraPosition.FacingLeft;
            animator.SetTrigger("Left");
        }
        if (Input.mousePosition.x < Screen.width / 6 && cameraPosition == CameraPosition.FacingRight)
        {
            cameraPosition = CameraPosition.FacingCenter;
            animator.SetTrigger("Left");
        }
        if (Input.mousePosition.x > Screen.width / 6 * 5 && cameraPosition == CameraPosition.FacingLeft)
        {
            cameraPosition = CameraPosition.FacingCenter;
            animator.SetTrigger("Right");
        }
        if (Input.mousePosition.x > Screen.width / 6 * 5 && cameraPosition == CameraPosition.FacingCenter)
        {
            cameraPosition = CameraPosition.FacingRight;
            animator.SetTrigger("Right");
        }
    }
}
public enum CameraPosition
{
    FacingRight,
    FacingLeft,
    FacingCenter
}