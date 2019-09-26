using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InventoryMenu : MonoBehaviour
{
    public bool isOpen;
    public GameObject inventoryMenu;
    public GameObject player;
    public GameObject playerCamera;

    public GameObject crossHorizontal;
    public GameObject crossVertical;

    public GameObject itemsPanel;
    public GameObject questPanel;
    public GameObject statsPanel;

    public GameObject showSword;
    public GameObject showShield;

    public GameObject realSword;
    public GameObject realShield;

    // exit button component
    public GameObject yesButton;
    public GameObject noButton;

    // Start is called before the first frame update
    void Start()
    {
        isOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("MenuOpen"))
        {
            if (!isOpen)
            {
                //Time.timeScale = 0;
                isOpen = true;
                Cursor.visible = true;
                crossHorizontal.SetActive(false);
                crossVertical.SetActive(false);
                player.GetComponent<MouseLook>().enabled = false;
                playerCamera.GetComponent<MouseLook>().enabled = false;
                inventoryMenu.SetActive(true);
            }
            else
            {
                inventoryMenu.SetActive(false);
                playerCamera.GetComponent<MouseLook>().enabled = true;
                player.GetComponent<MouseLook>().enabled = true;
                crossVertical.SetActive(true);
                crossHorizontal.SetActive(true);
                Cursor.visible = false;
                isOpen = false;
                // Time.timeScale = 1;              
            }
        }
    }

    // Panel Show function
    public void ShowItems()
    {
        itemsPanel.SetActive(true);
        questPanel.SetActive(false);
        statsPanel.SetActive(false);
        if (realSword.activeSelf)
        {
            print("show Sword");
            showSword.SetActive(true);
        }
        if (realShield.activeSelf)
        {
            print("show shield");
            showShield.SetActive(true);
        }
    }

    public void ShowQuests()
    {
        itemsPanel.SetActive(false);
        questPanel.SetActive(true);
        statsPanel.SetActive(false);
    }

    public void ShowStats()
    {
        itemsPanel.SetActive(false);
        questPanel.SetActive(false);
        statsPanel.SetActive(true);
    }


    // Quit Button functions
    public void QuitButton()
    {
        yesButton.SetActive(true);
        noButton.SetActive(true);
    }

    public void NoButtonPressed()
    {
        yesButton.SetActive(false);
        noButton.SetActive(false);
    }

    public void YesButtonPressed()
    {
        yesButton.SetActive(false);
        noButton.SetActive(false);
        SceneManager.LoadScene("MainMenu");
    }


}
