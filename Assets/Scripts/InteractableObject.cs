using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableObject : MonoBehaviour
{
    public GameObject interactableObj;
    public Text Text;
    public string TextString;


    private void OnMouseDown()
    {
        interactableObj.SetActive(false);
        Text.text = TextString;
    }

}