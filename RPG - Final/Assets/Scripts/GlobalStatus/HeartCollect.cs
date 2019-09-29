using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartCollect : MonoBehaviour
{
    public int rotateSpeed = 2;
    public AudioSource collectSound;
    public GameObject heart;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }

    void OnCollisionEnter(Collision target)
    {
        if (target.gameObject.name == "player")
        {
            collectSound.Play();
            HealthMonitor.healthValue += 100;
            Destroy(this.heart);
            //print("Collision");
        }
    }
}
