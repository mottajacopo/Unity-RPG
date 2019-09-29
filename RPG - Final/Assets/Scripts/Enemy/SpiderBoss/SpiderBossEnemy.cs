﻿using System.Collections;
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
    public Rigidbody rb;

    public static float globalSpider;

    void Start()
    {
        spiderAiScript = GetComponent<SpiderBossAI>();
        spiderAttackScript = GetComponent<SpiderBossAttack>();
        rb = GetComponent<Rigidbody>();

    }

    void DeductPoints(int damageAmount)
    {
        print("boss has been attacked");
        enemyHealth -= damageAmount;
    }

    // Update is called once per frame
    void Update()
    {
        globalSpider = spiderStatus;

        if(spiderStatus == 6)
        {
            StartCoroutine(DeathSpider());
        }

        if (enemyHealth <= 0)
        {
            print("Boss is dead");
            if (spiderStatus == 0)
            {
                QuestManager.subQuestNumber = 3;
                StartCoroutine(DeathSpider());
            }
        }
    }

    IEnumerator DeathSpider()
    {
        spiderAiScript.enabled = false;
        spiderAttackScript.enabled = false;
        spiderStatus = 6;
        calculatedExp = baseExp / GlobalLevel.currentLevel;
        rb.isKinematic = true;
        GlobalExp.currentExp +=  calculatedExp;
        yield return new WaitForSeconds(0.5f);
        //spiderBoss.GetComponent<Animation>().Play("death");
        //yield return new WaitForSeconds(1);
        spiderBoss.GetComponent<Animation>().enabled = false;
    }
}
