using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SphereShowFormula : MonoBehaviour, IVirtualButtonEventHandler
{
    public AudioSource audioSource;
    public GameObject vbBtnObj;
    public TextMesh textObject;
    public int check;
    public Animator sphereAnimator;

    // Start is called before the first frame update
    void Start(){
        vbBtnObj = GameObject.Find("SphereVirtualButton");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        textObject = (TextMesh)GameObject.Find("SphereFormula").GetComponent<TextMesh>();
        textObject.gameObject.SetActive(false);
        check = 1;
        sphereAnimator.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb){
        if(check == 1){
            check = 0;
            textObject.gameObject.SetActive(true);
            sphereAnimator.enabled = true;
            sphereAnimator.Play("SphereAnimation");
            vbBtnObj.transform.Find("Button").GetComponent<TextMesh>().text = "Hide Formula";
            audioSource.Play();
        }
        else{
            check = 1;
            textObject.gameObject.SetActive(false);
            sphereAnimator.enabled = false;
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


