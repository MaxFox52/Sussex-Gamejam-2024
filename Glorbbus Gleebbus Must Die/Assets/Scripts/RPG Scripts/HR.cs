using UnityEngine;

public class HR : MonoBehaviour
{
    public FightController FightController;

    public int HRAttack;
    public int HRHealth = 90;
    public int HRSpeed = 140;

    public int turnCountUp = 0;
    public bool myTurnNow = false;

    void Start()
    {
        HRAttack = Random.Range(10, 21);

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
        FightController.HRSprite.SetActive(true);
        FightController.aTurnActive = true;
    }

    public void myTurnEnd()
    {
        myTurnNow = false;
    }
}
