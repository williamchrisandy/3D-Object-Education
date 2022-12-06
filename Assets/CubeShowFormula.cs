using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class CubeShowFormula : MonoBehaviour, IVirtualButtonEventHandler
{
    public AudioSource audioSource;
    public GameObject vbBtnObj;
    public TextMesh textObject;
    public int check;
    public Animator cubeAnimator;

    // Start is called before the first frame update
    void Start(){
        vbBtnObj = GameObject.Find("CubeVirtualButton");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        textObject = (TextMesh)GameObject.Find("CubeFormula").GetComponent<TextMesh>();
        textObject.gameObject.SetActive(false);
        check = 1;
        cubeAnimator.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb){
        if(check == 1){
            check = 0;
            textObject.gameObject.SetActive(true);
            cubeAnimator.enabled = true;
            cubeAnimator.Play("CubeAnimation");
            vbBtnObj.transform.Find("Button").GetComponent<TextMesh>().text = "Hide Formula";
            audioSource.Play();
        }
        else{
            check = 1;
            textObject.gameObject.SetActive(false);
            cubeAnimator.enabled = false;
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
