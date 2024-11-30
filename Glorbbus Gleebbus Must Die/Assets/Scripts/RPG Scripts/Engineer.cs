using UnityEngine;

public class Engineer : MonoBehaviour
{
    public FightController FightController;

    public int engineerAttack;
    public int engineerHealth = 175;
    public int engineerSpeed = 100;

    public int turnCountUp = 0;
    public bool myTurnNow = false;

    void Start()
    {
        engineerAttack = Random.Range(15, 26);

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
