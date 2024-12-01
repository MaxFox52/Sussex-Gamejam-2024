using UnityEngine;

public class Survivor : MonoBehaviour
{
    public FightController FightController;

    public int survivorAttack;
    public int survivorHealth = 125;
    public int survivorSpeed = 130;

    public int turnCountUp = 0;
    public bool myTurnNow = false;

    void Start()
    {
        survivorAttack = Random.Range(20, 31);

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
                    turnCountUp = turnCountUp + survivorSpeed;
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
        Debug.Log("Survivor Turn");
        FightController.SurvivorAttackButton.SetActive(true);
        FightController.SurvivorSprite.SetActive(true);
        FightController.aTurnActive = true;
    }

    public void myTurnEnd()
    {
        myTurnNow = false;
    }
}
