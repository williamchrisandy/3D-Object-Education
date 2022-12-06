using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TabungShowFormula : MonoBehaviour, IVirtualButtonEventHandler
{
    public AudioSource audioSource;
    public GameObject vbBtnObj;
    public TextMesh textObject;
    public int check;
    public Animator tabungAnimator;

    // Start is called before the first frame update
    void Start(){
        vbBtnObj = GameObject.Find("TabungVirtualButton");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        textObject = (TextMesh)GameObject.Find("TabungFormula").GetComponent<TextMesh>();
        textObject.gameObject.SetActive(false);
        check = 1;
        tabungAnimator.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb){
        if(check == 1){
            check = 0;
            textObject.gameObject.SetActive(true);
            tabungAnimator.enabled = true;
            tabungAnimator.Play("TabungAnimation");
            vbBtnObj.transform.Find("Button").GetComponent<TextMesh>().text = "Hide Formula";
            audioSource.Play();
        }
        else{
            check = 1;
            textObject.gameObject.SetActive(false);
            tabungAnimator.enabled = false;
            vbBtnObj.transform.Find("Button").GetComponent<TextMesh>().text = "Show Formula";
            audioSource.Stop();
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb){
    }

    // Update is called once per frame
    void Update(){
        
    }
}


