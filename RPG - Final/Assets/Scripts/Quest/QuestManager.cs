using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    // assign to each quest in the game a number 
    public static int activeQuestNumber;
    public int internalQuestNumber;
    public static int subQuestNumber;
    public int internalSubQuestNumber;

    // variable needed for the pointer
    public GameObject pointer;
    public GameObject mainMark; // place where the arrow will point to
    public GameObject objective01Mark; // start Quest001
    public GameObject objective02Mark;
    public GameObject objective03Mark;
    public GameObject objective04Mark; // complete Quest001

    public GameObject objective05Mark; // start Quest002
    public GameObject objective06Mark; // kill spider
    public GameObject objective07Mark; // complete Quest002

    void Start()
    {
        pointer.SetActive(false);
    }

    void Update()
    {
        internalQuestNumber = activeQuestNumber;
        internalSubQuestNumber = subQuestNumber;
        pointer.transform.LookAt(mainMark.transform);

        if (internalSubQuestNumber == 0)
        {
            pointer.SetActive(false);
        }

        else
        {
            pointer.SetActive(true);
        }

        if (activeQuestNumber == 1)
        {
            if (internalSubQuestNumber == 1)
            {
                mainMark.transform.position = objective01Mark.transform.position;
            }

            else if (internalSubQuestNumber == 2)
            {
                mainMark.transform.position = objective02Mark.transform.position;
            }

            else if (internalSubQuestNumber == 3)
            {
                mainMark.transform.position = objective03Mark.transform.position;
            }

            else if (internalSubQuestNumber == 4)
            {
                mainMark.transform.position = objective04Mark.transform.position;
            }
        }

        if (activeQuestNumber == 2)
        {
            if (internalSubQuestNumber == 0)
            {
                mainMark.transform.position = objective05Mark.transform.position;
            }

            else if (internalSubQuestNumber == 1)
            {
                mainMark.transform.position = objective06Mark.transform.position;
            }

            else
            {
                mainMark.transform.position = objective07Mark.transform.position;
            }
        }
    }
}
