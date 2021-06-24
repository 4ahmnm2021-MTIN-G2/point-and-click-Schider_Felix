using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestBaitscrpt : MonoBehaviour
{

    public Manager MyManager;

    public GameObject Bait;

    public GameObject Real;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MyManager.GotShovel)
        {
            Bait.SetActive(false);
            Real.SetActive(true);
        }
    }

}
