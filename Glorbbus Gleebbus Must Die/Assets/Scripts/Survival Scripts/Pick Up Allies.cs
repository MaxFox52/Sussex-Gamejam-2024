using UnityEngine;

public class PickUpAllies : MonoBehaviour
{
    public GameObject Button;
    public GameObject Ally;
    public GameObject HR;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonPressed()
    {
        Button.SetActive(false);
        Ally.SetActive(false);
        HR.SetActive(false);
    }
}
