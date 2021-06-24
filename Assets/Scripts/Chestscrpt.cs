using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chestscrpt : MonoBehaviour
{
    public GameObject UiButton;

    // public Manager MyManager;

    public Text Text;
    public string TextString;




    private void Start()
    {
        UiButton.SetActive(false);

    }


    private void OnMouseDown()
    {
        Text.text = TextString;

        UiButton.SetActive(true);

    }

    private void Update()
    {


    }

}

