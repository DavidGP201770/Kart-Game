using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickSC : MonoBehaviour
{
    public float RotationSpeed = 10.0f;
    public Transform Player;
    float MouseX;
    // Start is called before the first frame update
    protected Joystick joystick;

    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        var rbody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        var rbody = GetComponent<Rigidbody>();
        rbody.velocity = new Vector3(joystick.Horizontal * 7f, rbody.velocity.y, joystick.Vertical * 7f);
        CameraControl();
    }

    void CameraControl()
    {
        MouseX += Input.GetAxis("Mouse X") * RotationSpeed;
        Player.rotation = Quaternion.Euler(0, MouseX, joystick.Vertical);
    }
}
