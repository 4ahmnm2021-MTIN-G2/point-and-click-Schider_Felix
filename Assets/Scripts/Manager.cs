using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public bool GotKey { get; set; }
    public bool GotShovel { get; set; }
    // public bool GotTreassure { get; set; }

    public bool GotClicked { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        GotKey = false;
        GotShovel = false;
        GotClicked = false;
        // GotyTreassure = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
