using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveByEvent : MonoBehaviour
{

    private void OnEnable()
    {
        Button.onPressed += SwitchActive;
    }
    private void OnDisable()
    {
        Button.onPressed -= SwitchActive;
    }

    void SwitchActive()
    {
        GameObject child = gameObject.transform.GetChild(0).gameObject;
        child.SetActive(!child.activeSelf);
    }
}
