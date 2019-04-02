using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private const float y_angle_min = 0.0f;
    private const float y_angle_max = 70.0f;
    [Header("Assigned Variables")]
    public Transform player;
    public Camera mycamera;
    [Header("Camera movement variables")]
    public float zoomSpeed = 20f;
    public float normal = 60f;
    private bool isZoomed = false;
    public float smooth = 5f;
    public float turnSpeed = 4.0f;    
    public float panSpeed = 4.0f;     
    public float zoomSpeedPan = 4.0f;
    public float camx = 13;
    public float camy = 130;
    public float camz = 130;
    private float speed = 10.0f;
    private Vector3 mouseOrigin;
    private bool isPanning; 
    private bool isRotating; 
    private bool isZooming;
    public Transform lookat;
    public Transform camTransform;



    private void Start()
    {
        camTransform = transform;
        mycamera = Camera.main;
        mycamera = transform.GetComponent<Camera>();
    }
     


    void Update()
    {
        HandleMovement();
        HandleZoom();
        
        if (Input.GetMouseButtonDown(1))
        {
            mouseOrigin = Input.mousePosition;
            isRotating = true;
        }
        
        if (Input.GetMouseButtonDown(2))
        {
            mouseOrigin = Input.mousePosition;
            isZooming = true;
        }
        if (!Input.GetMouseButton(1)) isRotating = false;
        //if (!Input.GetMouseButton(1)) isPanning = false;
        if (!Input.GetMouseButton(2)) isZooming = false;
        
        if (isRotating)
        {
            Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);

            transform.RotateAround(player.transform.position, transform.right, -pos.y);
            transform.RotateAround(player.transform.position, Vector3.up, pos.x);
        }
        
        if (isPanning)
        {
            //Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);
            Vector3 pos = player.transform.position; 

            Vector3 move = new Vector3(pos.x * panSpeed, pos.y * panSpeed, 0);
            transform.Translate(move, Space.Self);
        }
        if (isZooming)
        {
            Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);

            Vector3 move = pos.y * zoomSpeedPan * transform.forward;
            transform.Translate(move, Space.World);
        }
    }





    private void HandleMovement()
    {
        Vector3 cameraFollowPosition = player.transform.position;
        cameraFollowPosition.x = cameraFollowPosition.x - camx;
        cameraFollowPosition.y = cameraFollowPosition.y + camy;
        cameraFollowPosition.z = cameraFollowPosition.z - camz;

        Vector3 cameraMoveDir = (cameraFollowPosition - transform.position).normalized;
        float distance = Vector3.Distance(cameraFollowPosition, transform.position);
        float cameraMoveSpeed = 3f;

        if (distance > 0)
        {
            Vector3 newCameraPosition = transform.position + cameraMoveDir * distance * cameraMoveSpeed * Time.deltaTime;

            float distanceAfterMoving = Vector3.Distance(newCameraPosition, cameraFollowPosition);

            if (distanceAfterMoving > distance)
            {
                newCameraPosition = cameraFollowPosition;
            }

            transform.position = newCameraPosition;
        }
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
