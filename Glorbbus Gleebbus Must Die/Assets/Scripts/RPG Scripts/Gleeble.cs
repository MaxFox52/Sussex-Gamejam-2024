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

        FightController = GameObject.Find("FightController").GetComponent<FightController>();
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
        FightController.aTurnActive = true;
        if (gameObject.name == "Enemy1")
        {
            FightController.Gleeble1Attack();
        }
        if (gameObject.name == "Enemy2")
        {
            FightController.Gleeble2Attack();
        }
        if (gameObject.name == "Enemy3")
        {
            FightController.Gleeble3Attack();
        }
        if (gameObject.name == "Enemy4")
        {
            FightController.Gleeble4Attack();
        }
        if (gameObject.name == "Enemy5")
        {
            FightController.Gleeble5Attack();
        }
    }

    public void myTurnEnd()
    {
        myTurnNow = false;
    }
}
