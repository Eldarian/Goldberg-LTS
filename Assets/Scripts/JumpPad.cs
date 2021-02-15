using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    [SerializeField] float jumpForce = 10f;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Projectile"))
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * jumpForce, ForceMode.Impulse);
        }
    }
}
