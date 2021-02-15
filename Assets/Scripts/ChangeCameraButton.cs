using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCameraButton : MonoBehaviour
{

    public Camera[] cameras;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ChangeCamera()
    {
        Debug.Log("Clicked!");
        foreach (Camera camera in cameras)
        {
            camera.enabled = !camera.enabled;
        }
    }
}
