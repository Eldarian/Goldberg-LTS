using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuzzleController : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 10f, projectileForce = 10f;
    [SerializeField] GameObject projectilePrefab;
    public GameObject projectile;
    public bool isLaunched = false;

    private void Start()
    {
        projectile = Instantiate<GameObject>(projectilePrefab);
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.forward, rotationSpeed * verticalInput * Time.deltaTime);

        if (Input.GetButtonDown("Jump"))
        {
            isLaunched = true;
            projectile.GetComponent<Rigidbody>().AddForce(transform.up * projectileForce, ForceMode.Impulse);
        }
    }
}
