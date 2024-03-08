using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class LaptopSwitchCamera : MonoBehaviour
{
    public CinemachineVirtualCamera FPC;
    public Camera laptopCamera;
    private CinemachineVirtualCamera currentCamera;
    private bool isZoomed;
    public GameObject cameraPanel;
    public void SwitchCamera(CinemachineVirtualCamera camera)
    {
        laptopCamera.transform.SetParent(camera.transform);
        laptopCamera.transform.localPosition = Vector3.zero;
        laptopCamera.transform.localRotation = Quaternion.identity;
        currentCamera.Priority = 0;
        camera.Priority = 10;
        currentCamera = camera;
    }
    private void Start()
    {
        currentCamera = FPC;
        cameraPanel.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isZoomed)
            {
                isZoomed = false;
                cameraPanel.SetActive(true);
                FPC.Priority = 0;
            }
            else
            {
                isZoomed = true;
                FPC.Priority = 20;
                cameraPanel.SetActive(false);
            }
        }
    }
}
