using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{
    public GameObject menuSlider;
    public GameObject anywhereButton;
    public GameObject anywhereText;

    public AudioSource menuMusic;
    public GameObject loadingGame;

    public void SlideMenu()
    {
        menuSlider.GetComponent<Animation>().Play("menuSlide");
        anywhereButton.SetActive(false);
        anywhereText.SetActive(false);
    }

    public void NewGame()
    {
        menuMusic.Stop();
        loadingGame.SetActive(true);
        SceneManager.LoadScene("MainScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
