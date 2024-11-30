using UnityEngine;

public class FightController : MonoBehaviour
{
    public GameObject Captain;
    public GameObject Engineer;
    public GameObject HR;
    public GameObject Survivor;
    public GameObject enemyOne;
    public GameObject enemyTwo;
    public GameObject enemyThree;
    public GameObject enemyFour;
    public GameObject enemyFive;

    public int numberOfEnemies;
    public int numberOfAllies;

    public int attackTarget;

    public int nextAttackAttackDamage;

    public Captain CaptainScr;
    public Engineer EngineerScr;
    public HR HRScr;
    public Survivor SurvivorScr;
    public Gleeble Gleeble1;
    public Gleeble Gleeble2;
    public Gleeble Gleeble3;
    public Gleeble Gleeble4;
    public Gleeble Gleeble5;

    public GameObject CaptainAttackButton;
    public GameObject EngineerAttackButton;
    public GameObject HRAttackButton;
    public GameObject SurvivorAttackButton;
    public GameObject Gleeble1AttackButton;
    public GameObject Gleeble2AttackButton;
    public GameObject Gleeble3AttackButton;
    public GameObject Gleeble4AttackButton;
    public GameObject Gleeble5AttackButton;

    public bool aTurnActive = false;

    void Start()
    {
        if (Captain.GetComponent("Captain") != null)
        {
            CaptainScr = Captain.GetComponent<Captain>();
            CaptainAttackButton = GameObject.Find("CaptainAttack");
            CaptainAttackButton.SetActive(false);
            numberOfAllies++;
        }
        if (Engineer.GetComponent("Engineer") != null)
        {
            EngineerScr = Engineer.GetComponent<Engineer>();
            EngineerAttackButton = GameObject.Find("EngineerAttack");
            EngineerAttackButton.SetActive(false);
            numberOfAllies++;
        }
        else
        {
            EngineerAttackButton = GameObject.Find("EngineerAttack");
            EngineerAttackButton.SetActive(false);
        }
        if (HR.GetComponent("HR") != null)
        {
            HRScr = HR.GetComponent<HR>();
            HRAttackButton = GameObject.Find("HRAttack");
            HRAttackButton.SetActive(false);
            numberOfAllies++;
        }
        else
        {
            HRAttackButton = GameObject.Find("HRAttack");
            HRAttackButton.SetActive(false);
        }
        if (Survivor.GetComponent("Survivor") != null)
        {
            SurvivorScr = Survivor.GetComponent<Survivor>();
            SurvivorAttackButton = GameObject.Find("SurvivorAttack");
            SurvivorAttackButton.SetActive(false);
            numberOfAllies++;
        }
        else
        {
            SurvivorAttackButton = GameObject.Find("SurvivorAttack");
            SurvivorAttackButton.SetActive(false);
        }

        if (enemyOne.GetComponent("Gleeble") != null)
        {
            Gleeble1 = enemyOne.GetComponent<Gleeble>();
            Gleeble1AttackButton = GameObject.Find("GleebleAttack1");
            Gleeble1AttackButton.SetActive(false);
            numberOfEnemies++;
        }
        else
        {
            Gleeble1AttackButton = GameObject.Find("GleebleAttack1");
            Gleeble1AttackButton.SetActive(false);
        }
        if (enemyTwo.GetComponent("Gleeble") != null)
        {
            Gleeble2 = enemyTwo.GetComponent<Gleeble>();
            Gleeble2AttackButton = GameObject.Find("GleebleAttack2");
            Gleeble2AttackButton.SetActive(false);
            numberOfEnemies++;
        }
        else
        {
            Gleeble2AttackButton = GameObject.Find("GleebleAttack2");
            Gleeble2AttackButton.SetActive(false);
        }
        if (enemyThree.GetComponent("Gleeble") != null)
        {
            Gleeble3 = enemyThree.GetComponent<Gleeble>();
            Gleeble3AttackButton = GameObject.Find("GleebleAttack3");
            Gleeble3AttackButton.SetActive(false);
            numberOfEnemies++;
        }
        else
        {
            Gleeble3AttackButton = GameObject.Find("GleebleAttack3");
            Gleeble3AttackButton.SetActive(false);
        }
        if (enemyFour.GetComponent("Gleeble") != null)
        {
            Gleeble4 = enemyFour.GetComponent<Gleeble>();
            Gleeble4AttackButton = GameObject.Find("GleebleAttack4");
            Gleeble4AttackButton.SetActive(false);
            numberOfEnemies++;
        }
        else
        {
            Gleeble4AttackButton = GameObject.Find("GleebleAttack4");
            Gleeble4AttackButton.SetActive(false);
        }
        if (enemyFive.GetComponent("Gleeble") != null)
        {
            Gleeble5 = enemyFive.GetComponent<Gleeble>();
            Gleeble5AttackButton = GameObject.Find("GleebleAttack5");
            Gleeble5AttackButton.SetActive(false);
            numberOfEnemies++;
        }
        else
        {
            Gleeble5AttackButton = GameObject.Find("GleebleAttack5");
            Gleeble5AttackButton.SetActive(false);
        }
    }

    void Update()
    {
        if (CaptainScr.captainHealth <= 0)
        {
            Debug.Log("Unlucky You Lose.");
        }

        if (EngineerScr != null)
        {
            if (EngineerScr.engineerHealth <= 0)
            {
                Debug.Log("Unlucky Engineer");
                Destroy(EngineerScr);
                numberOfAllies--;
            }
        }
        if (HRScr != null)
        {
            if (HRScr.HRHealth <= 0)
            {
                Debug.Log("Unlucky HR");
                Destroy(HRScr);
                numberOfAllies--;
            }
        }
        if (SurvivorScr != null)
        {
            if (SurvivorScr.survivorHealth <= 0)
            {
                Debug.Log("Unlucky Survivor");
                Destroy(SurvivorScr);
                numberOfAllies--;
            }
        }

        if (Gleeble1 != null)
        {
            if (Gleeble1.gleebleHealth <= 0)
            {
                Debug.Log("Unlucky Gleeble 1");
                Destroy(Gleeble1);
                numberOfEnemies--;
            }
        }
        if (Gleeble2 != null)
        {
            if (Gleeble2.gleebleHealth <= 0)
            {
                Debug.Log("Unlucky Gleeble 2");
                Destroy(Gleeble2);
                numberOfEnemies--;
            }
        }
        if (Gleeble3 != null)
        {
            if (Gleeble3.gleebleHealth <= 0)
            {
                Debug.Log("Unlucky Gleeble 3");
                Destroy(Gleeble3);
                numberOfEnemies--;
            }
        }
        if (Gleeble4 != null)
        {
            if (Gleeble4.gleebleHealth <= 0)
            {
                Debug.Log("Unlucky Gleeble 4");
                Destroy(Gleeble4);
                numberOfEnemies--;
            }
        }
        if (Gleeble5 != null)
        {
            if (Gleeble5.gleebleHealth <= 0)
            {
                Debug.Log("Unlucky Gleeble 5");
                Destroy(Gleeble5);
                numberOfEnemies--;
            }
        }

        if (numberOfEnemies == 0)
        {
            Debug.Log("You Win");
        }
    }

    public void CaptainAttack()
    {
        CaptainScr.myTurnEnd();
        if (Gleeble1 != null)
        {
            Gleeble1AttackButton.gameObject.SetActive(true);
        }
        if (Gleeble2 != null)
        {
            Gleeble2AttackButton.gameObject.SetActive(true);
        }
        if (Gleeble3 != null)
        {
            Gleeble3AttackButton.gameObject.SetActive(true);
        }
        if (Gleeble4 != null)
        {
            Gleeble4AttackButton.gameObject.SetActive(true);
        }
        if (Gleeble5 != null)
        {
            Gleeble5AttackButton.gameObject.SetActive(true);
        }
        CaptainAttackButton.SetActive(false);
        nextAttackAttackDamage = CaptainScr.captainAttack;
    }

    public void EngineerAttack()
    {
        EngineerScr.myTurnEnd();
        if (Gleeble1 != null)
        {
            Gleeble1AttackButton.gameObject.SetActive(true);
        }
        if (Gleeble2 != null)
        {
            Gleeble2AttackButton.gameObject.SetActive(true);
        }
        if (Gleeble3 != null)
        {
            Gleeble3AttackButton.gameObject.SetActive(true);
        }
        if (Gleeble4 != null)
        {
            Gleeble4AttackButton.gameObject.SetActive(true);
        }
        if (Gleeble5 != null)
        {
            Gleeble5AttackButton.gameObject.SetActive(true);
        }
        EngineerAttackButton.SetActive(false);
        nextAttackAttackDamage = EngineerScr.engineerAttack;
    }

    public void HRAttack()
    {
        HRScr.myTurnEnd();
        if (Gleeble1 != null)
        {
            Gleeble1AttackButton.gameObject.SetActive(true);
        }
        if (Gleeble2 != null)
        {
            Gleeble2AttackButton.gameObject.SetActive(true);
        }
        if (Gleeble3 != null)
        {
            Gleeble3AttackButton.gameObject.SetActive(true);
        }
        if (Gleeble4 != null)
        {
            Gleeble4AttackButton.gameObject.SetActive(true);
        }
        if (Gleeble5 != null)
        {
            Gleeble5AttackButton.gameObject.SetActive(true);
        }
        HRAttackButton.SetActive(false);
        nextAttackAttackDamage = HRScr.HRAttack;
    }

    public void SurvivorAttack()
    {
        SurvivorScr.myTurnEnd();
        if (Gleeble1 != null)
        {
            Gleeble1AttackButton.gameObject.SetActive(true);
        }
        if (Gleeble2 != null)
        {
            Gleeble2AttackButton.gameObject.SetActive(true);
        }
        if (Gleeble3 != null)
        {
            Gleeble3AttackButton.gameObject.SetActive(true);
        }
        if (Gleeble4 != null)
        {
            Gleeble4AttackButton.gameObject.SetActive(true);
        }
        if (Gleeble5 != null)
        {
            Gleeble5AttackButton.gameObject.SetActive(true);
        }
        SurvivorAttackButton.SetActive(false);
        nextAttackAttackDamage = SurvivorScr.survivorAttack;
    }

    public void Target1()
    {
        if (Gleeble1 != null)
        {
            Gleeble1.gleebleHealth = Gleeble1.gleebleHealth - nextAttackAttackDamage;
        }
        Debug.Log("Attacks for " + nextAttackAttackDamage);
        nextAttackAttackDamage = 0;
        Gleeble1AttackButton.gameObject.SetActive(false);
        Gleeble2AttackButton.gameObject.SetActive(false);
        Gleeble3AttackButton.gameObject.SetActive(false);
        Gleeble4AttackButton.gameObject.SetActive(false);
        Gleeble5AttackButton.gameObject.SetActive(false);
        aTurnActive = false;
    }

    public void Target2()
    {
        if (Gleeble2 != null)
        {
            Gleeble2.gleebleHealth = Gleeble2.gleebleHealth - nextAttackAttackDamage;
        }
        Debug.Log("Attacks for " + nextAttackAttackDamage);
        nextAttackAttackDamage = 0;
        Gleeble1AttackButton.gameObject.SetActive(false);
        Gleeble2AttackButton.gameObject.SetActive(false);
        Gleeble3AttackButton.gameObject.SetActive(false);
        Gleeble4AttackButton.gameObject.SetActive(false);
        Gleeble5AttackButton.gameObject.SetActive(false);
        aTurnActive = false;
    }

    public void Target3()
    {
        if (Gleeble3 != null)
        {
            Gleeble3.gleebleHealth = Gleeble3.gleebleHealth - nextAttackAttackDamage;
        }
        Debug.Log("Attacks for " + nextAttackAttackDamage);
        nextAttackAttackDamage = 0;
        Gleeble1AttackButton.gameObject.SetActive(false);
        Gleeble2AttackButton.gameObject.SetActive(false);
        Gleeble3AttackButton.gameObject.SetActive(false);
        Gleeble4AttackButton.gameObject.SetActive(false);
        Gleeble5AttackButton.gameObject.SetActive(false);
        aTurnActive = false;
    }

    public void Target4()
    {
        if (Gleeble4 != null)
        {
            Gleeble4.gleebleHealth = Gleeble4.gleebleHealth - nextAttackAttackDamage;
        }
        Debug.Log("Attacks for " + nextAttackAttackDamage);
        nextAttackAttackDamage = 0;
        Gleeble1AttackButton.gameObject.SetActive(false);
        Gleeble2AttackButton.gameObject.SetActive(false);
        Gleeble3AttackButton.gameObject.SetActive(false);
        Gleeble4AttackButton.gameObject.SetActive(false);
        Gleeble5AttackButton.gameObject.SetActive(false);
        aTurnActive = false;
    }

    public void Target5()
    {
        if (Gleeble5 != null)
        {
            Gleeble5.gleebleHealth = Gleeble5.gleebleHealth - nextAttackAttackDamage;
        }
        Debug.Log("Attacks for " + nextAttackAttackDamage);
        nextAttackAttackDamage = 0;
        Gleeble1AttackButton.gameObject.SetActive(false);
        Gleeble2AttackButton.gameObject.SetActive(false);
        Gleeble3AttackButton.gameObject.SetActive(false);
        Gleeble4AttackButton.gameObject.SetActive(false);
        Gleeble5AttackButton.gameObject.SetActive(false);
        aTurnActive = false;
    }

    public void Gleeble1Attack()
    {
        Gleeble1.gleebleAttack = Random.Range(15, 26);
        attackTarget = Random.Range(1, numberOfAllies + 1);
        if (attackTarget == 1)
        {
            Debug.Log("Captain would hurt");
            CaptainScr.captainHealth = CaptainScr.captainHealth - Gleeble1.gleebleAttack;
        }
        if (attackTarget == 2)
        {
            if (EngineerScr != null)
            {
                Debug.Log("Engineer would hurt");
                EngineerScr.engineerHealth = EngineerScr.engineerHealth - Gleeble1.gleebleAttack;
            }
            else if (HRScr != null)
            {
                Debug.Log("HR would hurt");
                HRScr.HRHealth = HRScr.HRHealth - Gleeble1.gleebleAttack;
            }
            else
            {
                Debug.Log("Survivor would hurt");
                SurvivorScr.survivorHealth = SurvivorScr.survivorHealth - Gleeble1.gleebleAttack;
            }
        }
        if (attackTarget == 3)
        {
            if (HRScr != null)
            {
                Debug.Log("HR would hurt");
                HRScr.HRHealth = HRScr.HRHealth - Gleeble1.gleebleAttack;
            }
            else
            {
                Debug.Log("Survivor would hurt");
                SurvivorScr.survivorHealth = SurvivorScr.survivorHealth - Gleeble1.gleebleAttack;
            }
        }
        if (attackTarget == 4)
        {
            Debug.Log("Survivor would hurt");
            SurvivorScr.survivorHealth = SurvivorScr.survivorHealth - Gleeble1.gleebleAttack;
        }
        Gleeble1.myTurnEnd();
        Debug.Log("Gleeble attacks for " + Gleeble1.gleebleAttack);
        aTurnActive = false;
    }
     
    public void Gleeble2Attack()
    {
        Gleeble2.gleebleAttack = Random.Range(15, 26);
        attackTarget = Random.Range(1, numberOfAllies + 1);
        if (attackTarget == 1)
        {
            Debug.Log("Captain would hurt");
            CaptainScr.captainHealth = CaptainScr.captainHealth - Gleeble2.gleebleAttack;
        }
        if (attackTarget == 2)
        {
            if (EngineerScr != null)
            {
                Debug.Log("Engineer would hurt");
                EngineerScr.engineerHealth = EngineerScr.engineerHealth - Gleeble2.gleebleAttack;
            }
            else if (HRScr != null)
            {
                Debug.Log("HR would hurt");
                HRScr.HRHealth = HRScr.HRHealth - Gleeble2.gleebleAttack;
            }
            else
            {
                Debug.Log("Survivor would hurt");
                SurvivorScr.survivorHealth = SurvivorScr.survivorHealth - Gleeble2.gleebleAttack;
            }
        }
        if (attackTarget == 3)
        {
            if (HRScr != null)
            {
                Debug.Log("HR would hurt");
                HRScr.HRHealth = HRScr.HRHealth - Gleeble2.gleebleAttack;
            }
            else
            {
                Debug.Log("Survivor would hurt");
                SurvivorScr.survivorHealth = SurvivorScr.survivorHealth - Gleeble2.gleebleAttack;
            }
        }
        if (attackTarget == 4)
        {
            Debug.Log("Survivor would hurt");
            SurvivorScr.survivorHealth = SurvivorScr.survivorHealth - Gleeble2.gleebleAttack;
        }
        Gleeble2.myTurnEnd();
        Debug.Log("Gleeble attacks for " + Gleeble2.gleebleAttack);
        aTurnActive = false;
    }

    public void Gleeble3Attack()
    {
        Gleeble3.gleebleAttack = Random.Range(15, 26);
        attackTarget = Random.Range(1, numberOfAllies + 1);
        if (attackTarget == 1)
        {
            Debug.Log("Captain would hurt");
            CaptainScr.captainHealth = CaptainScr.captainHealth - Gleeble3.gleebleAttack;
        }
        if (attackTarget == 2)
        {
            if (EngineerScr != null)
            {
                Debug.Log("Engineer would hurt");
                EngineerScr.engineerHealth = EngineerScr.engineerHealth - Gleeble3.gleebleAttack;
            }
            else if (HRScr != null)
            {
                Debug.Log("HR would hurt");
                HRScr.HRHealth = HRScr.HRHealth - Gleeble3.gleebleAttack;
            }
            else
            {
                Debug.Log("Survivor would hurt");
                SurvivorScr.survivorHealth = SurvivorScr.survivorHealth - Gleeble3.gleebleAttack;
            }
        }
        if (attackTarget == 3)
        {
            if (HRScr != null)
            {
                Debug.Log("HR would hurt");
                HRScr.HRHealth = HRScr.HRHealth - Gleeble3.gleebleAttack;
            }
            else
            {
                Debug.Log("Survivor would hurt");
                SurvivorScr.survivorHealth = SurvivorScr.survivorHealth - Gleeble3.gleebleAttack;
            }
        }
        if (attackTarget == 4)
        {
            Debug.Log("Survivor would hurt");
            SurvivorScr.survivorHealth = SurvivorScr.survivorHealth - Gleeble3.gleebleAttack;
        }
        Gleeble3.myTurnEnd();
        Debug.Log("Gleeble attacks for " + Gleeble3.gleebleAttack);
        aTurnActive = false;
    }

    public void Gleeble4Attack()
    {
        Gleeble4.gleebleAttack = Random.Range(15, 26);
        attackTarget = Random.Range(1, numberOfAllies + 1);
        if (attackTarget == 1)
        {
            Debug.Log("Captain would hurt");
            CaptainScr.captainHealth = CaptainScr.captainHealth - Gleeble4.gleebleAttack;
        }
        if (attackTarget == 2)
        {
            if (EngineerScr != null)
            {
                Debug.Log("Engineer would hurt");
                EngineerScr.engineerHealth = EngineerScr.engineerHealth - Gleeble4.gleebleAttack;
            }
            else if (HRScr != null)
            {
                Debug.Log("HR would hurt");
                HRScr.HRHealth = HRScr.HRHealth - Gleeble4.gleebleAttack;
            }
            else
            {
                Debug.Log("Survivor would hurt");
                SurvivorScr.survivorHealth = SurvivorScr.survivorHealth - Gleeble4.gleebleAttack;
            }
        }
        if (attackTarget == 3)
        {
            if (HRScr != null)
            {
                Debug.Log("HR would hurt");
                HRScr.HRHealth = HRScr.HRHealth - Gleeble4.gleebleAttack;
            }
            else
            {
                Debug.Log("Survivor would hurt");
                SurvivorScr.survivorHealth = SurvivorScr.survivorHealth - Gleeble4.gleebleAttack;
            }
        }
        if (attackTarget == 4)
        {
            Debug.Log("Survivor would hurt");
            SurvivorScr.survivorHealth = SurvivorScr.survivorHealth - Gleeble4.gleebleAttack;
        }
        Gleeble4.myTurnEnd();
        Debug.Log("Gleeble attacks for " + Gleeble4.gleebleAttack);
        aTurnActive = false;
    }

    public void Gleeble5Attack()
    {
        Gleeble5.gleebleAttack = Random.Range(15, 26);
        attackTarget = Random.Range(1, numberOfAllies + 1);
        if (attackTarget == 1)
        {
            Debug.Log("Captain would hurt");
            CaptainScr.captainHealth = CaptainScr.captainHealth - Gleeble5.gleebleAttack;
        }
        if (attackTarget == 2)
        {
            if (EngineerScr != null)
            {
                Debug.Log("Engineer would hurt");
                EngineerScr.engineerHealth = EngineerScr.engineerHealth - Gleeble5.gleebleAttack;
            }
            else if (HRScr != null)
            {
                Debug.Log("HR would hurt");
                HRScr.HRHealth = HRScr.HRHealth - Gleeble5.gleebleAttack;
            }
            else
            {
                Debug.Log("Survivor would hurt");
                SurvivorScr.survivorHealth = SurvivorScr.survivorHealth - Gleeble5.gleebleAttack;
            }
        }
        if (attackTarget == 3)
        {
            if (HRScr != null)
            {
                Debug.Log("HR would hurt");
                HRScr.HRHealth = HRScr.HRHealth - Gleeble5.gleebleAttack;
            }
            else
            {
                Debug.Log("Survivor would hurt");
                SurvivorScr.survivorHealth = SurvivorScr.survivorHealth - Gleeble5.gleebleAttack;
            }
        }
        if (attackTarget == 4)
        {
            Debug.Log("Survivor would hurt");
            SurvivorScr.survivorHealth = SurvivorScr.survivorHealth - Gleeble5.gleebleAttack;
        }
        Gleeble5.myTurnEnd();
        Debug.Log("Gleeble attacks for " + Gleeble5.gleebleAttack);
        aTurnActive = false;
    }
}
