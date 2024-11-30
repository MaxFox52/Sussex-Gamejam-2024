using UnityEngine;

public class Gleeble : MonoBehaviour
{
    public FightController FightController;

    public int gleebleAttack;
    public int gleebleHealth;
    public int gleebleSpeed;

    public int turnCountUp = 0;
    public bool myTurnNow = false;

    void Start()
    {
        gleebleHealth = Random.Range(50, 76);
        gleebleSpeed = Random.Range(100, 151);
    }

    void Update()
    {
        if (myTurnNow == false)
        {
            if (FightController.aTurnActive == false)
            {
                if (turnCountUp < 5000)
                {
                    turnCountUp = turnCountUp + gleebleSpeed;
                }
                else
                {
                    turnCountUp = turnCountUp - 5000;
                    myTurnNow = true;
                    myTurnStart();
                }
            }
        }
    }

    public void myTurnStart()
    {
        Debug.Log("Gleeble Turn");
        if (gameObject.name == "Enemy1")
        {
            FightController.Gleeble1AttackButton.SetActive(true);
        }
        if (gameObject.name == "Enemy2")
        {
            FightController.Gleeble2AttackButton.SetActive(true);
        }
        if (gameObject.name == "Enemy3")
        {
            FightController.Gleeble3AttackButton.SetActive(true);
        }
        if (gameObject.name == "Enemy4")
        {
            FightController.Gleeble4AttackButton.SetActive(true);
        }
        if (gameObject.name == "Enemy5")
        {
            FightController.Gleeble5AttackButton.SetActive(true);
        }
        FightController.aTurnActive = true;
    }

    public void myTurnEnd()
    {
        if (gameObject.name == "Enemy1")
        {
            FightController.Gleeble1AttackButton.SetActive(false);
        }
        if (gameObject.name == "Enemy2")
        {
            FightController.Gleeble2AttackButton.SetActive(false);
        }
        if (gameObject.name == "Enemy3")
        {
            FightController.Gleeble3AttackButton.SetActive(false);
        }
        if (gameObject.name == "Enemy4")
        {
            FightController.Gleeble4AttackButton.SetActive(false);
        }
        if (gameObject.name == "Enemy5")
        {
            FightController.Gleeble5AttackButton.SetActive(false);
        }
        myTurnNow = false;
    }
}
