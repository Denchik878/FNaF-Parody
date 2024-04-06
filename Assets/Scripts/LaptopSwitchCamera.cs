using System.Collections;
using Cinemachine;
using UnityEngine;

public class LaptopSwitchCamera : MonoBehaviour
{
    public CinemachineVirtualCamera FPC;
    public CinemachineVirtualCamera zoomFPC;
    public Camera laptopCamera;
    public GameObject cameraPanel;
    public float switchTime;

    private CinemachineVirtualCamera currentCamera;
    private bool isZoomed;
    private bool isBlending;
    private CinemachineBrain brain;

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
        currentCamera = laptopCamera.transform.GetComponentInParent<CinemachineVirtualCamera>();
        cameraPanel.SetActive(false);
        brain = Camera.main.GetComponent<CinemachineBrain>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!isZoomed & !isBlending)
            {
                isZoomed = true;
                StartCoroutine(BlendCameras());
            }
            if(isZoomed & !isBlending)
            {
                isZoomed = false;
                FPC.Priority = 20;
                currentCamera.Priority = 0;
                cameraPanel.SetActive(false);
            }
        }
    }
    private IEnumerator BlendCameras()
    {
        isBlending = true;
        brain.m_DefaultBlend.m_Time = switchTime;
        FPC.Priority = 0;
        zoomFPC.Priority = 20;
        yield return new WaitForSeconds(switchTime);
        brain.m_DefaultBlend.m_Time = 0;
        isBlending = false;
        zoomFPC.Priority= 0;
        currentCamera.Priority= 20;
        cameraPanel.SetActive(true);
    }
}
