using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HearthSpawn : MonoBehaviour
{
    public GameObject heartPrefab;
    private GameObject heart;
    private GameObject[] hearts;
    public GameObject hero;
    

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
        hearts = GameObject.FindGameObjectsWithTag("Heart");

        if (hearts.Length < 5)
        {
            heart = Instantiate(heartPrefab) as GameObject;
            float heroX = hero.transform.position.x;
            float heroY = hero.transform.position.y;
            float heroZ = hero.transform.position.z;


            valueX = Random.Range(-50, 50);
            valueY = Random.Range(0, 0);
            valueZ = Random.Range(-100, 100);
            heart.transform.position = new Vector3(heroX + valueX, heroY + valueY, heroZ + valueZ);
        }

        else if(Time.time % 20 > 0 && Time.time % 20 < 1)
        {
            Debug.Log("[RESPAWN]");
            foreach (GameObject h in hearts)
            {
                GameObject.Destroy(h);
            }
        }

    }
}
