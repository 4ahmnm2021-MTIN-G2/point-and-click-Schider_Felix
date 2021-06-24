using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Openbutton : MonoBehaviour
{

    public Manager myManager;
    public UnityEvent clickedChest;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnMouseDown()
    {
        clickedChest.Invoke();
    }
    // Update is called once per frame
}
