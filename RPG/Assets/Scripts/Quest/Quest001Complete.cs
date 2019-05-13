﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest001Complete : MonoBehaviour
{
    public float distance;
    public GameObject actionDisplay; // E key
    public GameObject actionText;
    public GameObject questUI; // quest on screen readable in a full
    public GameObject player;
    public GameObject exMark;
    public GameObject completeTrigger;

    // Update is called once per frame
    void Update()
    {
        // constantly monitor the distance
        distance = PlayerCasting.distanceFromTarget;
    }

    void OnTriggerStay()
    {
        // check if we are gonna activate the trigger 
        if (distance <= 3)
        {
            actionDisplay.SetActive(true);
            actionText.SetActive(true);
            actionText.GetComponent<Text>().text = "Complete Quest";
        }

        // behaviour of pressing E key 
        if (Input.GetButtonDown("Action"))
        {
            if (distance <= 3) // check if the player is in range 
            {
                GlobalCash.goldAmount += 100;
                PlayerPrefs.SetFloat("GoldAmountSave", GlobalCash.goldAmount);
                QuestManager.activeQuestNumber = 2;
                QuestManager.subQuestNumber = 0;
                exMark.SetActive(false);
                GlobalExp.currentExp += 100;
                actionDisplay.SetActive(false);
                actionText.SetActive(false);
                completeTrigger.SetActive(false);
                MasterQuest.mainQuestInfo = MasterQuest.defaultQuest;
                MasterQuest.subQuestInfo = "";
            }
        }
    }

    void OnTriggerExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }
}
