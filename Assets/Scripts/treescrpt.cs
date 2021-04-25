using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class treescrpt : MonoBehaviour
{
    public GameObject UiButton;

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


}
