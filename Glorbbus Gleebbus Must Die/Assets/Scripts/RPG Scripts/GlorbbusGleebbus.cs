using UnityEngine;

public class GlorbbusGleebbus : MonoBehaviour
{
    public FightController FightController;

    public int GGAttack = 45;
    public int GGHealth = 500;
    public int GGSpeed = 126;

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
                    turnCountUp = turnCountUp + GGSpeed;
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
        Debug.Log("GG Turn");
        FightController.aTurnActive = true;
        FightController.GGAttack();
    }

    public void myTurnEnd()
    {
        myTurnNow = false;
    }
}
