using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickSC : MonoBehaviour
{
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
    }
}
