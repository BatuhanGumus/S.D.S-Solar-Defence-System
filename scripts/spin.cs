using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour {
    /*
    float f_lastX = 0.0f;
    float f_difX = 0.5f;
    float f_steps = 0.0f;
    int i_direction = 1;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            f_difX = 0.0f;
        }
        else if (Input.GetMouseButton(0))
        {
            f_difX = Mathf.Abs(f_lastX - Input.GetAxis("Mouse Z"));

            if (f_lastX < Input.GetAxis("Mouse Z"))
            {
                i_direction = -1;
                transform.Rotate(Vector3.right, -f_difX);
            }

            if (f_lastX > Input.GetAxis("Mouse Z"))
            {
                i_direction = 1;
                transform.Rotate(Vector3.back, f_difX);
            }

            f_lastX = -Input.GetAxis("Mouse Z");
        }
        else
        {
            if (f_difX > 0.5f) f_difX -= 0.05f;
            if (f_difX < 0.5f) f_difX += 0.05f;

            transform.Rotate(Vector3.up, f_difX * i_direction);
        }
    }*/

    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            // Get movement of the finger since last frame
            Vector3 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

           // rb.AddTorque(Camera.main.transform.forward * -touchDeltaPosition.x);
            rb.AddTorque(Camera.main.transform.forward * touchDeltaPosition.z);
        }
    }
}