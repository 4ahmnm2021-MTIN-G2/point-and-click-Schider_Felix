using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{
    public GameObject interactableObj;
    public Text Text;
    public string TextString;

    public UnityEvent clicked;


    private void OnMouseDown()
    {
        interactableObj.SetActive(false);
        Text.text = TextString;
        clicked.Invoke();
    }

}