using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Buttonscrpt : MonoBehaviour
{
    public Button yourButton;
    public GameObject Coco;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Coco.SetActive(true);
    }
}
