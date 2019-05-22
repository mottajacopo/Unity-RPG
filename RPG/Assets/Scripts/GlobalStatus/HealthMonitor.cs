using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthMonitor : MonoBehaviour
{
    public static float healthValue;
    public float internalHealth;
    // public GameObject hearth1;
    // public GameObject hearth2;
    // public GameObject hearth3;

    public GameObject healthBar;

    // Start is called before the first frame update
    void Start()
    {
        healthValue = 300;
    }

    // Update is called once per frame
    void Update()
    {
        internalHealth = healthValue;

        if (healthValue <= 0)
        {
            // hearth1.SetActive(true);
            SceneManager.LoadScene("GameOver");
        }

        if (healthValue >= 300)
            healthValue = 300;

        healthBar.GetComponent<RectTransform>().sizeDelta = new Vector2(healthValue,30);

        /*
        if (healthValue == 1)
        {
            hearth1.SetActive(true);
            hearth2.SetActive(false);
        }

        if (healthValue == 2)
        {
            hearth2.SetActive(true);
            hearth3.SetActive(false);
        }

        if (healthValue == 3)
        {
            hearth3.SetActive(true);
        }*/
    }
}
