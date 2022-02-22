using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class onClick : MonoBehaviour
{
    public GameObject infotext_object, reviewtext_object;
    private string infotext, reviewtext;
    private bool toggle = false;

    // Start is called before the first frame update
    void Start()
    {
        infotext = infotext_object.GetComponent<TextMesh>().text;
        reviewtext = reviewtext_object.GetComponent<TextMesh>().text;

        reviewtext_object.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Switch between displayed texts 
    public void onButtonClick()
    {
        if (!toggle) {
            reviewtext_object.SetActive(true);
            infotext_object.SetActive(false);
            toggle = true;
        } else {
            reviewtext_object.SetActive(false);
            infotext_object.SetActive(true);
            toggle = false;
        }
        
    }
}
