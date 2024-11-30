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

    public Captain CaptainScr;
    public Gleeble Gleeble1;
    public Gleeble Gleeble2;
    public Gleeble Gleeble3;
    public Gleeble Gleeble4;
    public Gleeble Gleeble5;

    public GameObject CaptainAttackButton;
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
    }

    public void CaptainAttack()
    {
        CaptainScr.myTurnEnd();
        Debug.Log("Captain attacks for " + CaptainScr.captainAttack);
        aTurnActive = false;
    }

    public void chooseTarget()
    {

    }

    public void Gleeble1Attack()
    {
        Gleeble1.gleebleAttack = Random.Range(15, 26);
        attackTarget = Random.Range(1, numberOfAllies);
        Gleeble1.myTurnEnd();
        Debug.Log("Gleeble attacks for " + Gleeble1.gleebleAttack);
        aTurnActive = false;
    }
     
    public void Gleeble2Attack()
    {
        Gleeble2.gleebleAttack = Random.Range(15, 26);
        attackTarget = Random.Range(1, numberOfAllies);
        Gleeble2.myTurnEnd();
        Debug.Log("Gleeble attacks for " + Gleeble2.gleebleAttack);
        aTurnActive = false;
    }

    public void Gleeble3Attack()
    {
        Gleeble3.gleebleAttack = Random.Range(15, 26);
        attackTarget = Random.Range(1, numberOfAllies);
        Gleeble3.myTurnEnd();
        Debug.Log("Gleeble attacks for " + Gleeble3.gleebleAttack);
        aTurnActive = false;
    }

    public void Gleeble4Attack()
    {
        Gleeble4.gleebleAttack = Random.Range(15, 26);
        attackTarget = Random.Range(1, numberOfAllies);
        Gleeble4.myTurnEnd();
        Debug.Log("Gleeble attacks for " + Gleeble4.gleebleAttack);
        aTurnActive = false;
    }

    public void Gleeble5Attack()
    {
        Gleeble5.gleebleAttack = Random.Range(15, 26);
        attackTarget = Random.Range(1, numberOfAllies);
        Gleeble5.myTurnEnd();
        Debug.Log("Gleeble attacks for " + Gleeble5.gleebleAttack);
        aTurnActive = false;
    }
}
