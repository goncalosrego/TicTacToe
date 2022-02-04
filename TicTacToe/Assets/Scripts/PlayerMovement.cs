using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Transform cachedTransform;
    string horizontalName = "Horizontal";
    string verticalName = "Vertical";
    string detectionZoneTag = "DetectionZone";
    float moveSpeed = 5.0f;
    bool playerCollided = false;

    // Start is called before the first frame update
    void Start()
    {
        cachedTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerCollided() == false)
        {
            MovePlayer();
        }
    }

    void MovePlayer()
    {
        float horizontal = Input.GetAxis(horizontalName);
        float vertical = Input.GetAxis(verticalName);

        Vector3 movement = new Vector3(horizontal, 0f, vertical);
        cachedTransform.Translate(movement * moveSpeed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == detectionZoneTag)
        {
            playerCollided = true;
        }
        else
        {
            playerCollided = false;
        }
    }

    public bool PlayerCollided()
    {
        return playerCollided;
    }
}
