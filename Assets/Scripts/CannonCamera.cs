using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonCamera : MonoBehaviour
{
    [SerializeField] GameObject cannon;
    GameObject projectile;
    Vector3 offset = new Vector3(-4, 2, 0);
    Vector3 projectileOffset = new Vector3(-4, 0, 0);
    MuzzleController muzzleController;

    private void Start()
    {
        muzzleController = cannon.transform.GetChild(1).GetComponent<MuzzleController>();
    }

    private void Update()
    {
        if (projectile == null)
        {
            projectile = muzzleController.projectile;
        }
        if (!muzzleController.isLaunched)
        {
            transform.position = cannon.transform.position + offset;
        } else
        {
            transform.position = projectile.transform.position + projectileOffset;
        }
    }
}
