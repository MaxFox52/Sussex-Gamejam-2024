using System.Collections;
using UnityEngine;

public class SavesForRealTotally : MonoBehaviour
{
    public GameObject SaveButton;
    public GameObject YesButton;
    public GameObject NoButton;
    public GameObject SaveFoundVid;
    public GameObject YesSaveVid;
    public GameObject NoSaveVid;
    public GameObject done;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SaveFoundVid.SetActive(false);
        YesButton.SetActive(false);
        NoButton.SetActive(false);
        YesSaveVid.SetActive(false);
        NoSaveVid.SetActive(false);
        done.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Save()
    {
        SaveButton.SetActive(false);
        SaveFoundVid.SetActive(true);
        YesButton.SetActive(true);
        NoButton.SetActive(true);
    }

    public void Yes()
    {
        SaveFoundVid.SetActive(false);
        YesButton.SetActive(false);
        NoButton.SetActive(false);
        YesSaveVid.SetActive(true);
        done.SetActive(true);
    }

    public void No()
    {
        SaveFoundVid.SetActive(false);
        YesButton.SetActive(false);
        NoButton.SetActive(false);
        NoSaveVid.SetActive(true);
        done.SetActive(true);
    }

    public void Done()
    {
        YesSaveVid.SetActive(false);
        NoSaveVid.SetActive(false);
        done.SetActive(false);
    }

}
