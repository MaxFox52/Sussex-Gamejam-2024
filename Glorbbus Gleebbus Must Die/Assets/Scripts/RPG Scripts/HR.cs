using UnityEngine;

public class HR : MonoBehaviour
{
    public FightController FightController;

    public int HRAttack = 25;
    public int HRHealth = 150;
    public int HRSpeed = 120;

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
                    turnCountUp = turnCountUp + HRSpeed;
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
        Debug.Log("HR Turn");
        FightController.HRAttackButton.SetActive(true);
        FightController.aTurnActive = true;
    }

    public void myTurnEnd()
    {
        myTurnNow = false;
    }
}
