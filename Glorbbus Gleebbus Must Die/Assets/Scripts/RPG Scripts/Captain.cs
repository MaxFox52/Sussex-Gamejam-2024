using UnityEngine;

public class Captain : MonoBehaviour
{
    public FightController FightController;

    public int captainAttack = 25;
    public int captainHealth = 150;
    public int captainSpeed = 120;

    public int turnCountUp = 0;
    public bool myTurnNow = false;

    void Start()
    {

    }

    void Update()
    {
        if (myTurnNow == false)
        {
            if (FightController.aTurnActive == false)
            {
                if (turnCountUp < 5000)
                {
                    turnCountUp = turnCountUp + captainSpeed;
                }
                else
                {
                    turnCountUp = 0;
                    myTurnNow = true;
                }
            }
        }
        else
        {
            myTurnStart();
        }
    }

    public void myTurnStart()
    {
        Debug.Log("Captain Turn");
        FightController.aTurnActive = true;
    }

    public void myTurnEnd()
    {
        myTurnNow = false;
    }
}
