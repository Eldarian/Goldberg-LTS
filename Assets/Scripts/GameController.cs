using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI winMessage;
    public Camera[] cameras;

    private void Start()
    {
        cameras[0].enabled = true;
        for(int i = 1; i < cameras.Length; i++)
        cameras[1].enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            ChangeCamera();
        }
    }
    public void OnWin()
    {
        winMessage.gameObject.SetActive(true);
    }

    public void ChangeCamera()
    {
        for (int i = 0; i < cameras.Length; i++)
        {
            if (cameras[i].enabled)
            {
                if (cameras.Length == i + 1)
                {
                    cameras[0].enabled = true;
                }
                else
                {
                    cameras[i + 1].enabled = true;
                }
                cameras[i].enabled = false;
                break;
            }
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
