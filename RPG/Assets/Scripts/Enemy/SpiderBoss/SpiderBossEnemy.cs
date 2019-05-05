using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderBossEnemy : MonoBehaviour
{
    public int enemyHealth = 20;
    public GameObject spiderBoss;
    public int spiderStatus;
    public float baseExp = 10;
    public float calculatedExp;
    public SpiderBossAI spiderAiScript;
    public SpiderBossAttack spiderAttackScript;

    public GameObject oldNPC;
    public GameObject newNPC;

    public static float globalSpider;

    void Start()
    {
        spiderAiScript = GetComponent<SpiderBossAI>();
        spiderAttackScript = GetComponent<SpiderBossAttack>();
    }

    void DeductPoints(int damageAmount)
    {
        enemyHealth -= damageAmount;
    }

    // Update is called once per frame
    void Update()
    {
        globalSpider = spiderStatus;

        if (enemyHealth <= 0)
        {
            if(spiderStatus == 0)
            StartCoroutine(DeathSpider());
        }
    }

    IEnumerator DeathSpider()
    {
        spiderAiScript.enabled = false;
        spiderAttackScript.enabled = false;
        spiderStatus = 6;
        calculatedExp = baseExp / GlobalLevel.currentLevel;
        GlobalExp.currentExp +=  calculatedExp;
        yield return new WaitForSeconds(0.5f);
        spiderBoss.GetComponent<Animation>().Play("death");
        yield return new WaitForSeconds(1);
        spiderBoss.GetComponent<Animation>().enabled = false;
        oldNPC.SetActive(false);
        newNPC.SetActive(true);
    }
}
