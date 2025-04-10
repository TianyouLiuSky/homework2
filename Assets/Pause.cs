using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PauseMenuManager : MonoBehaviour
{
    public GameObject pauseMenu;
    public Button resumeButton;

    void Awake()
    {

        pauseMenu.SetActive(false);
        resumeButton.onClick.AddListener(OnResumePressed);

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

            pauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }

    void OnResumePressed()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
