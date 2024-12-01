using UnityEngine;
using UnityEngine.SceneManagement;

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
    public GlorbbusGleebbus GGScr;

    public GameObject CaptainAttackButton;
    public GameObject EngineerAttackButton;
    public GameObject HRAttackButton;
    public GameObject SurvivorAttackButton;
    public GameObject Gleeble1AttackButton;
    public GameObject Gleeble2AttackButton;
    public GameObject Gleeble3AttackButton;
    public GameObject Gleeble4AttackButton;
    public GameObject Gleeble5AttackButton;

    public GameObject CaptainSprite;
    public GameObject EngineerSprite;
    public GameObject HRSprite;
    public GameObject SurvivorSprite;
    public GameObject Gleeble1Sprite;
    public GameObject Gleeble2Sprite;
    public GameObject Gleeble3Sprite;
    public GameObject Gleeble4Sprite;
    public GameObject Gleeble5Sprite;
    public GameObject GGSprite;

    public GameObject text;

    public GameObject deathScreen;

    public bool aTurnActive = false;

    void Start()
    {
        deathScreen.SetActive(false);
        text.SetActive(false);

        // setting up captain
        if (Captain.GetComponent("Captain") != null)
        {
            CaptainScr = Captain.GetComponent<Captain>();
            numberOfAllies++;
        }
        CaptainAttackButton = GameObject.Find("CaptainAttack");
        CaptainAttackButton.SetActive(false);
        CaptainSprite = GameObject.Find("CaptainSprite");
        CaptainSprite.SetActive(true);

        // setting up engineer
        if (Engineer.GetComponent("Engineer") != null)
        {
            EngineerScr = Engineer.GetComponent<Engineer>();
            numberOfAllies++;
            EngineerSprite = GameObject.Find("EngineerSprite");
            EngineerSprite.SetActive(true);
        }
        else
        {
            EngineerSprite = GameObject.Find("EngineerSprite");
            EngineerSprite.SetActive(false);
        }
        EngineerAttackButton = GameObject.Find("EngineerAttack");
        EngineerAttackButton.SetActive(false);

        // setting up HR
        if (HR.GetComponent("HR") != null)
        {
            HRScr = HR.GetComponent<HR>();
            numberOfAllies++;
            HRSprite = GameObject.Find("HRSprite");
            HRSprite.SetActive(true);
        }
        else
        {
            HRSprite = GameObject.Find("HRSprite");
            HRSprite.SetActive(false);
        }
        HRAttackButton = GameObject.Find("HRAttack");
        HRAttackButton.SetActive(false);

        // setting up survivor
        if (Survivor.GetComponent("Survivor") != null)
        {
            SurvivorScr = Survivor.GetComponent<Survivor>();
            numberOfAllies++;
            SurvivorSprite = GameObject.Find("SurvivorSprite");
            SurvivorSprite.SetActive(true);
        }
        else
        {
            SurvivorSprite = GameObject.Find("SurvivorSprite");
            SurvivorSprite.SetActive(false);
        }
        SurvivorAttackButton = GameObject.Find("SurvivorAttack");
        SurvivorAttackButton.SetActive(false);

        // setting up gleeble 1
        if (enemyOne.GetComponent("Gleeble") != null)
        {
            Gleeble1 = enemyOne.GetComponent<Gleeble>();
            numberOfEnemies++;
            Gleeble1Sprite = GameObject.Find("Enemy1Sprite");
            Gleeble1Sprite.SetActive(true);
        }
        else
        {
            Gleeble1Sprite = GameObject.Find("Enemy1Sprite");
            Gleeble1Sprite.SetActive(false);
        }
        Gleeble1AttackButton = GameObject.Find("GleebleAttack1");
        Gleeble1AttackButton.SetActive(false);

        // setting up gleeble 2
        if (enemyTwo.GetComponent("Gleeble") != null)
        {
            Gleeble2 = enemyTwo.GetComponent<Gleeble>();
            numberOfEnemies++;
            Gleeble2Sprite = GameObject.Find("Enemy2Sprite");
            Gleeble2Sprite.SetActive(true);
        }
        else
        {
            Gleeble2Sprite = GameObject.Find("Enemy2Sprite");
            Gleeble2Sprite.SetActive(false);
        }
        Gleeble2AttackButton = GameObject.Find("GleebleAttack2");
        Gleeble2AttackButton.SetActive(false);

        // setting up gleeble 3
        if (enemyThree.GetComponent("Gleeble") != null)
        {
            Gleeble3 = enemyThree.GetComponent<Gleeble>();
            numberOfEnemies++;
            Gleeble3Sprite = GameObject.Find("Enemy3Sprite");
            Gleeble3Sprite.SetActive(true);
        }
        else
        {
            Gleeble3Sprite = GameObject.Find("Enemy3Sprite");
            Gleeble3Sprite.SetActive(false);
        }
        Gleeble3AttackButton = GameObject.Find("GleebleAttack3");
        Gleeble3AttackButton.SetActive(false);
        
        // setting up gleeble 3
        if (enemyFour.GetComponent("Gleeble") != null)
        {
            Gleeble4 = enemyFour.GetComponent<Gleeble>();
            numberOfEnemies++;
            Gleeble4Sprite = GameObject.Find("Enemy4Sprite");
            Gleeble4Sprite.SetActive(true);
        }
        else
        {
            Gleeble4Sprite = GameObject.Find("Enemy4Sprite");
            Gleeble4Sprite.SetActive(false);
        }
        Gleeble4AttackButton = GameObject.Find("GleebleAttack4");
        Gleeble4AttackButton.SetActive(false);

        // setting up gleeble 5
        if (enemyFive.GetComponent("Gleeble") != null)
        {
            Gleeble5 = enemyFive.GetComponent<Gleeble>();
            numberOfEnemies++;
            Gleeble5Sprite = GameObject.Find("Enemy5Sprite");
            Gleeble5Sprite.SetActive(true);
        }
        else
        {
            Gleeble5Sprite = GameObject.Find("Enemy5Sprite");
            Gleeble5Sprite.SetActive(false);
        }
        Gleeble5AttackButton = GameObject.Find("GleebleAttack5");
        Gleeble5AttackButton.SetActive(false);

        if (enemyThree.GetComponent("GlorbbusGleebbus") != null)
        {
            GGScr = enemyThree.GetComponent<GlorbbusGleebbus>();
            numberOfEnemies++;
            GGSprite = GameObject.Find("Glorbbus_Gleebbus");
            GGSprite.SetActive(true);
        }
        else
        {
            GGSprite = GameObject.Find("Glorbbus_Gleebbus");
            GGSprite.SetActive(false);
        }
    }

    void Update()
    {
        if (CaptainScr.captainHealth <= 0)
        {
            aTurnActive = true;
            CaptainAttackButton.SetActive(false);
            EngineerAttackButton.SetActive(false);
            HRAttackButton.SetActive(false);
            SurvivorAttackButton.SetActive(false);
            Gleeble1AttackButton.SetActive(false);
            Gleeble2AttackButton.SetActive(false);
            Gleeble3AttackButton.SetActive(false);
            Gleeble4AttackButton.SetActive(false);
            Gleeble5AttackButton.SetActive(false);
            deathScreen.SetActive(true);
            // need to play rewind time / death scene here
        }

        if (EngineerScr != null)
        {
            if (EngineerScr.engineerHealth <= 0)
            {
                Debug.Log("Unlucky Engineer");
                EngineerSprite.SetActive(false);
                Destroy(EngineerScr);
                numberOfAllies--;
            }
        }
        if (HRScr != null)
        {
            if (HRScr.HRHealth <= 0)
            {
                Debug.Log("Unlucky HR");
                HRSprite.SetActive(false);
                Destroy(HRScr);
                numberOfAllies--;
            }
        }
        if (SurvivorScr != null)
        {
            if (SurvivorScr.survivorHealth <= 0)
            {
                Debug.Log("Unlucky Survivor");
                SurvivorSprite.SetActive(false);
                Destroy(SurvivorScr);
                numberOfAllies--;
            }
        }

        if (Gleeble1 != null)
        {
            if (Gleeble1.gleebleHealth <= 0)
            {
                Debug.Log("Unlucky Gleeble 1");
                Gleeble1Sprite.SetActive(false);
                Destroy(Gleeble1);
                numberOfEnemies--;
            }
        }
        if (Gleeble2 != null)
        {
            if (Gleeble2.gleebleHealth <= 0)
            {
                Debug.Log("Unlucky Gleeble 2");
                Gleeble2Sprite.SetActive(false);
                Destroy(Gleeble2);
                numberOfEnemies--;
            }
        }
        if (Gleeble3 != null)
        {
            if (Gleeble3.gleebleHealth <= 0)
            {
                Debug.Log("Unlucky Gleeble 3");
                Gleeble3Sprite.SetActive(false);
                Destroy(Gleeble3);
                numberOfEnemies--;
            }
        }
        if (Gleeble4 != null)
        {
            if (Gleeble4.gleebleHealth <= 0)
            {
                Debug.Log("Unlucky Gleeble 4");
                Gleeble4Sprite.SetActive(false);
                Destroy(Gleeble4);
                numberOfEnemies--;
            }
        }
        if (Gleeble5 != null)
        {
            if (Gleeble5.gleebleHealth <= 0)
            {
                Debug.Log("Unlucky Gleeble 5");
                Gleeble5Sprite.SetActive(false);
                Destroy(Gleeble5);
                numberOfEnemies--;
            }
        }
        if (GGScr != null)
        {
            if (GGScr.GGHealth <= 0)
            {
                Debug.Log("Glorbbus Gleebbus is Dead");
                GGSprite.SetActive(false);
                Destroy(GGScr);
                numberOfEnemies--;
            }
        }

        if (numberOfEnemies == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            text.SetActive(true);
        }
    }

    public void CaptainAttack()
    {
        CaptainScr.myTurnEnd();
        if (Gleeble1 != null)
        {
            Gleeble1AttackButton.gameObject.SetActive(true);
            Gleeble1Sprite.gameObject.SetActive(true);
        }
        if (Gleeble2 != null)
        {
            Gleeble2AttackButton.gameObject.SetActive(true);
            Gleeble2Sprite.gameObject.SetActive(true);
        }
        if (Gleeble3 != null)
        {
            Gleeble3AttackButton.gameObject.SetActive(true);
            Gleeble3Sprite.gameObject.SetActive(true);
        }
        if (Gleeble4 != null)
        {
            Gleeble4AttackButton.gameObject.SetActive(true);
            Gleeble4Sprite.gameObject.SetActive(true);
        }
        if (Gleeble5 != null)
        {
            Gleeble5AttackButton.gameObject.SetActive(true);
            Gleeble5Sprite.gameObject.SetActive(true);
        }
        if (GGScr != null)
        {
            Gleeble3AttackButton.gameObject.SetActive(true);
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
            Gleeble1Sprite.gameObject.SetActive(true);
        }
        if (Gleeble2 != null)
        {
            Gleeble2AttackButton.gameObject.SetActive(true);
            Gleeble2Sprite.gameObject.SetActive(true);
        }
        if (Gleeble3 != null)
        {
            Gleeble3AttackButton.gameObject.SetActive(true);
            Gleeble3Sprite.gameObject.SetActive(true);
        }
        if (Gleeble4 != null)
        {
            Gleeble4AttackButton.gameObject.SetActive(true);
            Gleeble4Sprite.gameObject.SetActive(true);
        }
        if (Gleeble5 != null)
        {
            Gleeble5AttackButton.gameObject.SetActive(true);
            Gleeble5Sprite.gameObject.SetActive(true);
        }
        if (GGScr != null)
        {
            Gleeble3AttackButton.gameObject.SetActive(true);
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
            Gleeble1Sprite.gameObject.SetActive(true);
        }
        if (Gleeble2 != null)
        {
            Gleeble2AttackButton.gameObject.SetActive(true);
            Gleeble2Sprite.gameObject.SetActive(true);
        }
        if (Gleeble3 != null)
        {
            Gleeble3AttackButton.gameObject.SetActive(true);
            Gleeble3Sprite.gameObject.SetActive(true);
        }
        if (Gleeble4 != null)
        {
            Gleeble4AttackButton.gameObject.SetActive(true);
            Gleeble4Sprite.gameObject.SetActive(true);
        }
        if (Gleeble5 != null)
        {
            Gleeble5AttackButton.gameObject.SetActive(true);
            Gleeble5Sprite.gameObject.SetActive(true);
        }
        if (GGScr != null)
        {
            Gleeble3AttackButton.gameObject.SetActive(true);
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
            Gleeble1Sprite.gameObject.SetActive(true);
        }
        if (Gleeble2 != null)
        {
            Gleeble2AttackButton.gameObject.SetActive(true);
            Gleeble2Sprite.gameObject.SetActive(true);
        }
        if (Gleeble3 != null)
        {
            Gleeble3AttackButton.gameObject.SetActive(true);
            Gleeble3Sprite.gameObject.SetActive(true);
        }
        if (Gleeble4 != null)
        {
            Gleeble4AttackButton.gameObject.SetActive(true);
            Gleeble4Sprite.gameObject.SetActive(true);
        }
        if (Gleeble5 != null)
        {
            Gleeble5AttackButton.gameObject.SetActive(true);
            Gleeble5Sprite.gameObject.SetActive(true);
        }
        if (GGScr != null)
        {
            Gleeble3AttackButton.gameObject.SetActive(true);
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
        if (GGScr != null)
        {
            GGScr.GGHealth = GGScr.GGHealth - nextAttackAttackDamage;
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

    public void GGAttack()
    {
        attackTarget = Random.Range(1, numberOfAllies + 1);
        if (attackTarget == 1)
        {
            Debug.Log("Captain would hurt");
            CaptainScr.captainHealth = CaptainScr.captainHealth - GGScr.GGAttack;
        }
        if (attackTarget == 2)
        {
            if (EngineerScr != null)
            {
                Debug.Log("Engineer would hurt");
                EngineerScr.engineerHealth = EngineerScr.engineerHealth - GGScr.GGAttack;
            }
            else if (HRScr != null)
            {
                Debug.Log("HR would hurt");
                HRScr.HRHealth = HRScr.HRHealth - GGScr.GGAttack;
            }
            else
            {
                Debug.Log("Survivor would hurt");
                SurvivorScr.survivorHealth = SurvivorScr.survivorHealth - GGScr.GGAttack;
            }
        }
        if (attackTarget == 3)
        {
            if (HRScr != null)
            {
                Debug.Log("HR would hurt");
                HRScr.HRHealth = HRScr.HRHealth - GGScr.GGAttack;
            }
            else
            {
                Debug.Log("Survivor would hurt");
                SurvivorScr.survivorHealth = SurvivorScr.survivorHealth - GGScr.GGAttack;
            }
        }
        if (attackTarget == 4)
        {
            Debug.Log("Survivor would hurt");
            SurvivorScr.survivorHealth = SurvivorScr.survivorHealth - GGScr.GGAttack;
        }
        GGScr.myTurnEnd();
        Debug.Log("HE attacks for " + GGScr.GGAttack);
        aTurnActive = false;
    }
}
