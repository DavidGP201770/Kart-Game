using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovSC : MonoBehaviour
{
    public float RotationSpeed = 10.0f;
    public Transform Target, Player;
    float MouseX, MouseY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CameraControl();
    }

    void CameraControl()
    {
        MouseX += Input.GetAxis("Mouse X") * RotationSpeed;
        //MouseY -= Input.GetAxis("Mouse Y") * RotationSpeed;
        //MouseY = Mathf.Clamp(MouseY, -35, 60);

        transform.LookAt(Target);

        Target.rotation = Quaternion.Euler(0, MouseX,0);
        Player.rotation = Quaternion.Euler(0, MouseX, 0);
    }
}
