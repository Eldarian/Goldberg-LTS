using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        LineRenderer laserRay;

        Ray ray = new Ray(transform.position, transform.forward*20);
        Physics.Raycast(ray, out hit);
        Debug.DrawRay(transform.position, transform.forward*20, Color.red);

        if (hit.collider != null)
        {
            if(hit.collider.gameObject.CompareTag("Projectile"))
            {
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
