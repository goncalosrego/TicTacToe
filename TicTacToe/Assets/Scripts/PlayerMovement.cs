using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] GameObject detectionZone;
    Transform cachedTransform;
    string horizontalName = "Horizontal";
    string verticalName = "Vertical";
    float moveSpeed = 5.0f;
    bool playerIsInside = false;
    float mouseSensitivity = 2.0f;
    float yaw;
    float pitch;

    // Start is called before the first frame update
    void Start()
    {
        cachedTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        RotatePlayer();
        RotateCamera();
        DetectPlayerCollision();
    }

    void MovePlayer()
    {
        float horizontal = Input.GetAxis(horizontalName);
        float vertical = Input.GetAxis(verticalName);

        Vector3 movement = new Vector3(horizontal, 0f, vertical);
        cachedTransform.Translate(movement * moveSpeed * Time.deltaTime);
    }

    void RotateCamera()
    {
        yaw += Input.GetAxis("Mouse X") * mouseSensitivity;
        pitch -= Input.GetAxis("Mouse Y") * mouseSensitivity;

        Camera.main.transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }

    void RotatePlayer()
    {
        yaw += Input.GetAxis("Mouse X") * mouseSensitivity;

        cachedTransform.eulerAngles = new Vector3(0.0f, yaw, 0.0f);
    }

    void DetectPlayerCollision()
    {
        if (detectionZone.gameObject.GetComponent<BoxCollider>().bounds.Contains(cachedTransform.position))
        {
            playerIsInside = true;
        }
        else
        {
            playerIsInside = false;
        }
    }

    public bool PlayerIsInside()
    {
        return playerIsInside;
    }
}
