using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene01Skip : MonoBehaviour
{
    public GameObject fadeIn;
    public GameObject spiderBoss;
    public GameObject spiderOne;
    public GameObject spiderTwo;
    public GameObject spiderThree;
    public GameObject spiderFour;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SkipScene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SkipScene()
    {
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
        spiderBoss.SetActive(false);
        spiderOne.SetActive(false);
        spiderTwo.SetActive(false);
        spiderThree.SetActive(false);
        spiderFour.SetActive(false);
    }
}
