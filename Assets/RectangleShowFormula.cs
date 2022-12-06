using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class RectangleShowFormula : MonoBehaviour, IVirtualButtonEventHandler
{
    public AudioSource audioSource;
    public GameObject vbBtnObj;
    public TextMesh textObject;
    public int check;

    // Start is called before the first frame update
    void Start()
    {
        vbBtnObj = GameObject.Find("RectangleVirtualButton");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        textObject = (TextMesh)GameObject.Find("RectangleFormula").GetComponent<TextMesh>();
        textObject.gameObject.SetActive(false);
        check = 1;
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (check == 1)
        {
            check = 0;
            textObject.gameObject.SetActive(true);
            vbBtnObj.transform.Find("Button").GetComponent<TextMesh>().text = "Hide Formula";
            audioSource.Play();
        }
        else
        {
            check = 1;
            textObject.gameObject.SetActive(false);
            vbBtnObj.transform.Find("Button").GetComponent<TextMesh>().text = "Show Formula";
            audioSource.Stop();
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
}
