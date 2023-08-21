using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonCamera : MonoBehaviour
{
    // camera attached to the player
    public Camera playerCamera;

    // container varuiables for th emouse detla values each frame
    public float deltaX;
    public float deltaY;

    // container vairables for the players rotation around the X and Y axis
    public float xRot;  // rotation around the x-axis in degrees
    public float yRot;  // rotation around the y-axis in degrees

    public float sensitivity;   //set mouse sensitivity
    // Start is called before the first frame update
    void Start()
    {
        playerCamera = Camera.main;     // set player camera
        Cursor.visible = false;     // hide the cursor
        
    }

    // Update is called once per frame
    void Update()
    {
        // keep track of the players x and y rotation
        yRot += deltaX;
        xRot -= deltaY;

        // keep the player's rotation clamped to [-90, 90] degrees
        xRot = Mathf.Clamp(xRot, -90f, 90f);

        // rotate the camera around the x-axis first
        playerCamera.transform.localRotation = Quaternion.Euler(xRot, 0, 0);
        transform.rotation = Quaternion.Euler(0, yRot, 0);
    }

    public void OnCameraLook(InputValue value) 
    {
        // reading the mouse deltas as a vetor 2 (delta X is the x coomponent and deltaY is the y component
        Vector2 inputVector = value.Get<Vector2>();
        sensitivity = 0.2f;
        deltaX = inputVector.x * sensitivity;
        deltaY = inputVector.y * sensitivity;
    }
}
