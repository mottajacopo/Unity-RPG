using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderBossAttack : MonoBehaviour
{
    public GameObject enemy;
    public int animController;
    public bool dealingDamage;

    // Start is called before the first frame update
    void Start()
    {
        dealingDamage = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(animController == 0)
        {
            enemy.GetComponent<Animation>().Play("walk");
        }

        if (animController == 1)
        {
            if (!dealingDamage)
            {
                enemy.GetComponent<Animation>().Play("attack");
                StartCoroutine(TakingDamage());
            }
        }
    }

    IEnumerator TakingDamage()
    {
        dealingDamage = true;
        yield return new WaitForSeconds(1f);

        // check if the spider is alive
        if (SpiderBossEnemy.globalSpider != 6)
        {
            print("Dealing Damage");
            HealthMonitor.healthValue -= 10;
        }

        yield return new WaitForSeconds(0.5f);
        dealingDamage = false;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "player")
            animController = 1;
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.name == "player")
        {
            animController = 0;
            dealingDamage = false;
        }
    }
}
