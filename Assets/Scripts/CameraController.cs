using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float panSpeed = 20f;

    public float panBorderThickness = 20f;

    public Vector2 panLimit;

    public float scrollSpeed = 20f;

    public float minY = 20f;

    public float maxY = 40f;

    private void Start()
    {
        Debug.Log("y: " + Screen.height);
        Debug.Log("x: " + Screen.width);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (
            Input.GetKey("w") ||
            Input.mousePosition.y >= Screen.height - panBorderThickness
        )
        {
            pos.z += panSpeed * Time.deltaTime;
        }

        if (Input.GetKey("s") || Input.mousePosition.y <= 0 + panBorderThickness
        )
        {
            pos.z -= panSpeed * Time.deltaTime;
        }

        if (
            Input.GetKey("d") ||
            Input.mousePosition.x >= Screen.width - panBorderThickness
        )
        {
            pos.x += panSpeed * Time.deltaTime;
        }

        if (Input.GetKey("a") || Input.mousePosition.x <= 0 + panBorderThickness
        )
        {
            pos.x -= panSpeed * Time.deltaTime;
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        pos.y -= scroll * scrollSpeed * Time.deltaTime * 100f;

        pos.x = Mathf.Clamp(pos.x, -panLimit.x, panLimit.x);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        pos.z = Mathf.Clamp(pos.z, -panLimit.y, panLimit.y);

        transform.position = pos;
    }
}
