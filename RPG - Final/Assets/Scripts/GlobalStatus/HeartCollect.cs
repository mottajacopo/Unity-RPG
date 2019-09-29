using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartCollect : MonoBehaviour
{
    public int rotateSpeed = 2;
    public GameObject heart;
    private AudioSource collectSound;
    private Collider collider;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        collider = GetComponent<Collider>();
        transform.Rotate(0, rotateSpeed, 0, Space.World);
        collectSound = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision target)
    {
        if (target.gameObject.name == "player")
        {
            collider.enabled = false;
            collectSound.Play();
            HealthMonitor.healthValue += 100;
            StartCoroutine(DestroyHeart());
        }
    }

    IEnumerator DestroyHeart()
    {
        yield return new WaitForSeconds(0.3f);
        Destroy(this.heart);
    }
}