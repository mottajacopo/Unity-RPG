using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HearthSpawn : MonoBehaviour
{
    public GameObject heartPrefab;
    private GameObject heart;
    private GameObject[] heartNumber;

    private int valueX;
    private int valueY;
    private int valueZ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        heartNumber = GameObject.FindGameObjectsWithTag("Heart");
        if(heartNumber.Length < 5)
        {
            heart = Instantiate(heartPrefab) as GameObject;

            valueX = Random.Range(850, 1050);
            valueY = Random.Range(3, 5);
            valueZ = Random.Range(850, 1050);
            heart.transform.position = new Vector3(valueX, valueY, valueZ);
        }
    }
}
