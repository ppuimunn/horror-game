using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Puah Li Hao
public class PlayerLook : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera cam;
    private float xRotation = 0f;
    public float xSensitivity = 30f;
    public float ySensitivity = 30f;
    public void ProcessLook(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;
        //calculate cam rotation for up and down
        xRotation -= (mouseY * Time.deltaTime) * ySensitivity;
        xRotation = Mathf.Clamp(xRotation, -80, 80f);
        //apply to cam transform
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        //rotate player to look left,right
        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * xSensitivity);
    }
    
}
