using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class treescrpt : MonoBehaviour
{
    public GameObject UiButton;
    public GameObject UiButton2;


    public Text Text;
    public string TextString;
    public int Counter;

    private void Start()
    {
        UiButton.SetActive(false);
        UiButton2.SetActive(false);
        Counter = 1;

    }


    private void OnMouseDown()
    {
        Text.text = TextString;
        Counter++;
        if (Counter == 2)
        {
            UiButton.SetActive(true);
        }
        if (Counter == 3)
        {
            UiButton2.SetActive(true);
        }
    }

    void Update()
    {

    }

}
