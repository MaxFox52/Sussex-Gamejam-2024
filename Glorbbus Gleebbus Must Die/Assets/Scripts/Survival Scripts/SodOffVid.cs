using System.Collections;
using UnityEngine;

public class SodOffVid : MonoBehaviour
{
    public GameObject vid;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(GoAway());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator GoAway()
    {
        vid.SetActive(false);
        yield return new WaitForSeconds(0.001f);
        vid.SetActive(true);
        yield return new WaitForSeconds(5);
        vid.SetActive(false);
    }
}
