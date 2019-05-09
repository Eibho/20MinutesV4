using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //use the character controller
    CharacterController cc;
    //speed
    public float speed = 5f;
    //gravity
    float ySpeed = 0;
    float gravity = -10f;
    //jump
    public float jumpSpeed;
    //camera
    public Transform fpsCamera;
    float pitch =0f;
    public float mouseSensitivity = 10f;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        Camera();
        Move();

    }
    private void Move()
    {
        //move
        float xInput = Input.GetAxis("Horizontal") * speed;
        float zInput = Input.GetAxis("Vertical") * speed;

        //move in the direction of the camera
        Vector3 move = new Vector3(xInput, 0, zInput);
        //clamp to a speed value
        move = Vector3.ClampMagnitude(move, speed);
        //transform how player is rotated
        move = transform.TransformVector(move);

        //sprint
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 15;
        }
        else if (Input.GetKey(KeyCode.RightShift))
        {
            speed = 15;
        }
        else
            speed = 10;


        //check if on the ground
        if (cc.isGrounded) //yes
        {
            //if you press jump key
            if (Input.GetButtonDown("Jump"))
            {
                //jump
                ySpeed = jumpSpeed;
            }
            else
            {
                ySpeed = gravity * Time.deltaTime;
            }
        }
        else //no
        {
            ySpeed += gravity * Time.deltaTime;
        }

        cc.Move((move + new Vector3(0, ySpeed, 0)) * Time.deltaTime);
    }
    void Camera()
    {
        //left and right
        float xMouse = Input.GetAxis("Mouse X") *mouseSensitivity;
        transform.Rotate(0, xMouse, 0);
        //up and down
        pitch -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        //clamp so you dont go upside down
        pitch = Mathf.Clamp(pitch, -45f, 45f);

        Quaternion camRot = Quaternion.Euler(pitch, 0, 0);
        fpsCamera.localRotation = camRot;
    }
}
