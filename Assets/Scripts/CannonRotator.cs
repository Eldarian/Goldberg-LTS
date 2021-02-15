﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonRotator : MonoBehaviour
{
    [SerializeField]
    float rotationSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, rotationSpeed * horizontalInput * Time.deltaTime);
    }
}
