using UnityEngine;

public class Gleeble : MonoBehaviour
{
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
            if (turnCountUp < 5000)
            {
                turnCountUp = turnCountUp + gleebleSpeed;
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
        Debug.Log("Turn");
        myTurnNow = false;
    }
}
