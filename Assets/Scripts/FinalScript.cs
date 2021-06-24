using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class FinalScript : MonoBehaviour
{
    public Manager MyManager;

    public GameObject ButtonOpen;

    public UnityEvent clicked;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((MyManager.GotKey) && (MyManager.GotClicked))
        {
            ButtonOpen.SetActive(true);
        }

    }



}
