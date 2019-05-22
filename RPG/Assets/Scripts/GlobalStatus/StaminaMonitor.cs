using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaminaMonitor : MonoBehaviour
{
    public static float staminaValue;
    public float internalStamina;

    public static bool isRecoveringStamina;


    public GameObject staminaBar;

    // Start is called before the first frame update
    void Start()
    {
        staminaValue = 300;
        isRecoveringStamina = false;
    }

    // Update is called once per frame
    void Update()
    {
        internalStamina = staminaValue;
        if (staminaValue >= 300)
            staminaValue = 300;

        staminaBar.GetComponent<RectTransform>().sizeDelta = new Vector2(staminaValue, 30);

        if(staminaValue == 0)
        {
            isRecoveringStamina = true;
            StartCoroutine(RecoverStamina());
        }
    }

    IEnumerator RecoverStamina()
    {
        yield return new WaitForSeconds(5f);
        isRecoveringStamina = false;
    }
}
