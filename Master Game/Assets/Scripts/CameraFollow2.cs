using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow2 : MonoBehaviour
{
    private const float y_angle_min = 10.0f;
    private const float y_angle_max = 70.0f;
    public Transform lookat;
    public Transform camTransform;
    private Camera mycamera;
    private float distance = 10.0f;
    private float currentX = 0.0f;
    private float currentY = 0.0f;
    private float sensitivityX = 4.0f;
    private float sensitivityY = 1.0f;
    private float speed = 10.0f;
    public float zoomSpeed = 20f;
    public float normal = 60f;
    private bool isZoomed = false;
    public float smooth = 5f;


    // Start is called before the first frame update
    void Start()
    {
        camTransform = transform;
        mycamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            currentX += Input.GetAxis("Mouse X") * speed;
            currentY += Input.GetAxis("Mouse Y") * speed;
            currentY = Mathf.Clamp(currentY, y_angle_min, y_angle_max);
        }
    }

    private void LateUpdate()
    {
        Vector3 dir = new Vector3(0, 100, -distance);
        Quaternion rotation = Quaternion.Euler(30 + currentY, -90 + currentX, 0);
        camTransform.position = lookat.position + rotation * dir;
        camTransform.LookAt(lookat.position);
    }

    private void HandleZoom()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            isZoomed = !isZoomed;
        }

        if (isZoomed)
        {
            mycamera.fieldOfView = Mathf.Lerp(mycamera.fieldOfView, zoomSpeed, Time.deltaTime * smooth);
        }

        else
        {
            mycamera.fieldOfView = Mathf.Lerp(mycamera.fieldOfView, normal, Time.deltaTime * smooth);
        }

    }
}