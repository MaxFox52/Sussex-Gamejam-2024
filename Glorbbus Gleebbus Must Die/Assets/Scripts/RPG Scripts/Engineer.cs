using UnityEngine;

public class Engineer : MonoBehaviour
{
    public FightController FightController;

    public int engineerAttack = 25;
    public int engineerHealth = 150;
    public int engineerSpeed = 120;

    public int turnCountUp = 0;
    public bool myTurnNow = false;

    void Start()
    {
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
                    turnCountUp = turnCountUp + engineerSpeed;
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
        Debug.Log("Engineer Turn");
        FightController.EngineerAttackButton.SetActive(true);
        FightController.aTurnActive = true;
    }

    public void myTurnEnd()
    {
        myTurnNow = false;
    }
}
