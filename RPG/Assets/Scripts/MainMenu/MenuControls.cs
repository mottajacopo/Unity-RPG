using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControls : MonoBehaviour
{
    public GameObject menuSlider;
    public GameObject anywhereButton;
    public GameObject anywhereText;

    public void SlideMenu()
    {
        menuSlider.GetComponent<Animation>().Play("menuSlide");
        anywhereButton.SetActive(false);
        anywhereText.SetActive(false);
    }
}
