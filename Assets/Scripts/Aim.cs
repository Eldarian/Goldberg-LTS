using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    GameController gameController;
    private void Start()
    {
        gameController = GameObject.Find("Game Manager").GetComponent<GameController>();
    }

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Projectile"))
        {
            gameController.OnWin();
            //Хочется, чтобы при касании достигший снаряд притягивало в центр цели и удерживало там на антиграве
            other.gameObject.GetComponent<Rigidbody>().useGravity = false;
            other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.zero, ForceMode.VelocityChange);
            //other.gameObject.GetComponent<Rigidbody>().AddForce(, ForceMode.Acceleration);
        }
    }
}
