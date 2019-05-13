using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MasterQuest : MonoBehaviour
{
    // this script is made to update the inventory menu Quest section 
    public GameObject mainQuestText;
    public GameObject subQuestText;
    public static string mainQuestInfo;
    public static string subQuestInfo;

    public static string defaultQuest = "Nothing to do. Go and Find a new Quest";


    // Start is called before the first frame update
    void Start()
    {
        mainQuestInfo = defaultQuest;
    }

    // Update is called once per frame
    void Update()
    {
        mainQuestText.GetComponent<Text>().text = mainQuestInfo;
        subQuestText.GetComponent<Text>().text = subQuestInfo;
    }
}
