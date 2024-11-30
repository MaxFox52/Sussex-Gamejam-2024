using UnityEngine;

public class FightController : MonoBehaviour
{
    public Captain Captain;
    public Gleeble Gleeble;

    public GameObject CaptainAttackButton;
    public GameObject GleebleAttackButton;

    public bool aTurnActive = false;

    void Start()
    {
        CaptainAttackButton.SetActive(false);
        GleebleAttackButton.SetActive(false);
    }

    void Update()
    {
        
    }

    public void GleebleAttack()
    {
        Gleeble.gleebleAttack = Random.Range(15, 26);
        Debug.Log("Gleeble attacks for " + Gleeble.gleebleAttack);
        Gleeble.myTurnEnd();
        aTurnActive = false;
    }

    public void CaptainAttack()
    {
        Captain.myTurnEnd();
        Debug.Log("Captain attacks for " + Captain.captainAttack);
        aTurnActive = false;
    }
}
