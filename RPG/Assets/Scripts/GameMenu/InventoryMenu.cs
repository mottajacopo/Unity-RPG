using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryMenu : MonoBehaviour
{
    public bool isOpen;
    public GameObject inventoryMenu;
    public GameObject player;
    public GameObject playerCamera;

    public GameObject itemsPanel;
    public GameObject questPanel;
    public GameObject statsPanel;

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
                player.GetComponent<MouseLook>().enabled = false;
                playerCamera.GetComponent<MouseLook>().enabled = false;
                inventoryMenu.SetActive(true);
            }
            else
            {
                inventoryMenu.SetActive(false);
                Cursor.visible = false;
                player.GetComponent<MouseLook>().enabled = true;
                playerCamera.GetComponent<MouseLook>().enabled = true;
                isOpen = false;
                // Time.timeScale = 1;
                
            }
        }
    }

    public void ShowItems()
    {
        itemsPanel.SetActive(true);
        questPanel.SetActive(false);
        statsPanel.SetActive(false);
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


}
