using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class UI : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject optionsMenu;
    public GameObject[] mainButtons;
    Resolution[] resolutions;
    private bool pause = false;
    public Dropdown resolutionDropdown;
    public AudioMixer audioMixer;
    private bool optionsOn;

    void Start()
    {
        resolutions = Screen.resolutions;
        resolutionDropdown.ClearOptions();
        List<string> options = new List<string>();
        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i] + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }
    private void Update()
    {
        if (Input.GetKeyUp("escape"))
        {
            Pause();
        }
    }

    public void LevelSelect(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Pause()
    {
        if (pause == false)
        {
            pauseMenu.SetActive(true);
            pause = true;
            Time.timeScale = 0;
        }
        else if (pause == true)
        {
            pauseMenu.SetActive(false);
            pause = false;
            Time.timeScale = 1;
        }
    }
    public void Options()
    {
        if (optionsOn == false)
        {
            optionsMenu.SetActive(true);
            foreach (GameObject button in mainButtons)
            {
                button.SetActive(false);
            }
            optionsOn = true;
        }
        else if (optionsOn == true)
        {
            {
                optionsMenu.SetActive(false);
                foreach (GameObject button in mainButtons)
                {
                    button.SetActive(true);
                }
                optionsOn = false;
            }
        }

    }
    public void SetFullscreen(bool Fullscreen)
    {
        Screen.fullScreen = Fullscreen;
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
}
