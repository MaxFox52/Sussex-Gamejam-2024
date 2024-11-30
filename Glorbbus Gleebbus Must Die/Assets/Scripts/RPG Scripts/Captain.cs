using UnityEngine;

public class Captain : MonoBehaviour
{
    public int captainAttack;
    public int captainHealth;
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
        else
        {
            myTurnStart();
        }
    }

    public void myTurnStart()
    {
        Debug.Log("Captain Turn");
        myTurnNow = false;
    }
}
