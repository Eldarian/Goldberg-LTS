using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeCamera : MonoBehaviour
{
    public float speed = 20f;
    public float rotationSpeed = 100    ;
    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("CameraX");
        float yInput = Input.GetAxis("CameraY");
        float zInput = Input.GetAxis("CameraZ");
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");


        transform.Translate(Vector3.up * speed * yInput * Time.deltaTime);
        transform.Translate(transform.right * speed * xInput * Time.deltaTime);
        transform.Translate(transform.forward * speed * zInput * Time.deltaTime);

        transform.Rotate(Vector3.up, mouseX * rotationSpeed);
        transform.Rotate(Vector3.right, mouseY * -rotationSpeed);
    }
}
