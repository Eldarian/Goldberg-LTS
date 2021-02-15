using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] string id;
    public delegate void OnPressed();
    public static event OnPressed onPressed;


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Projectile"))
        {
            if(onPressed != null)
            {
                onPressed();
            }
        }
    }

   
}
