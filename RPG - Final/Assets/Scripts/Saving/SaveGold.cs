using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGold : MonoBehaviour
{
    public float loadGold;

    // Start is called before the first frame update
    void Start()
    {
        loadGold = PlayerPrefs.GetFloat("GoldAmountSave");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
