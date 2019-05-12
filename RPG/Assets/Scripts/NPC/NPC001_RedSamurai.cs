using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC001_RedSamurai : MonoBehaviour
{
    public float distance;
    public GameObject actionDisplay; // E key
    public GameObject actionText;
    public GameObject textBox;
    public GameObject NPCName;
    public GameObject NPCText;
    public GameObject player;
    public GameObject smallSpider;
    public GameObject smallSpiderOne;
    public GameObject bossSpider;


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

            actionText.GetComponent<Text>().text = "Talk";
            actionDisplay.SetActive(true);
            actionText.SetActive(true);
        }

        // behaviour of pressing E key 
        if (Input.GetButtonDown("Action"))
        {
            if (distance <= 3) // check if the player is in range 
            {
                //Cursor.lockState = CursorLockMode.None;
                //Cursor.visible = true;
                actionDisplay.SetActive(false);
                actionText.SetActive(false);
                //player.SetActive(false);
                StartCoroutine(NPC001Active());
            }
        }
    }

    void OnTriggerExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }

    IEnumerator NPC001Active()
    {
        if(QuestManager.activeQuestNumber == 2)
        {
            if (QuestManager.subQuestNumber == 2)
            {
                textBox.SetActive(true);
                NPCName.GetComponent<Text>().text = "Giorgio";
                NPCName.SetActive(true);
                NPCText.GetComponent<Text>().text = "Thank you very much for your help. There is a cave outside the village, please go and explore";
                NPCText.SetActive(true);
                smallSpider.SetActive(false);
                smallSpiderOne.SetActive(false);
                bossSpider.SetActive(false);
                yield return new WaitForSeconds(5.5f);
                textBox.SetActive(false);
                NPCName.SetActive(false);
                NPCText.SetActive(false);
                actionDisplay.SetActive(true);
                actionText.SetActive(true);
                QuestManager.activeQuestNumber = 3;
                QuestManager.subQuestNumber = 0;
            }
            else if (QuestManager.subQuestNumber == 1)
            {
                textBox.SetActive(true);
                NPCName.GetComponent<Text>().text = "Giorgio";
                NPCName.SetActive(true);
                NPCText.GetComponent<Text>().text = "We have a spiders problem. Can you kill the spiders and their boss in the forest?";
                NPCText.SetActive(true);
                smallSpider.SetActive(true);
                smallSpiderOne.SetActive(true);
                bossSpider.SetActive(true);
                yield return new WaitForSeconds(5.5f);
                textBox.SetActive(false);
                NPCName.SetActive(false);
                NPCText.SetActive(false);
                QuestManager.subQuestNumber = 1;
            }
            else
            {
                textBox.SetActive(true);
                NPCName.GetComponent<Text>().text = "Giorgio";
                NPCName.SetActive(true);
                NPCText.GetComponent<Text>().text = "Please complete the quest and come back";
                NPCText.SetActive(true);
                yield return new WaitForSeconds(5.5f);
                textBox.SetActive(false);
                NPCName.SetActive(false);
                NPCText.SetActive(false);
            }
        }
        else
        {
            textBox.SetActive(true);
            NPCName.GetComponent<Text>().text = "Giorgio";
            NPCName.SetActive(true);
            NPCText.GetComponent<Text>().text = "Hello friend, I may have a quest for you if you wish to accept it. Please come back later on this afternoon";
            NPCText.SetActive(true);
            yield return new WaitForSeconds(5.5f);
            textBox.SetActive(false);
            NPCName.SetActive(false);
            NPCText.SetActive(false);
        }
    }
}
