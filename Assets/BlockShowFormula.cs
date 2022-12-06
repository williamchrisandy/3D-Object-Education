using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class BlockShowFormula : MonoBehaviour, IVirtualButtonEventHandler
{
    public AudioSource audioSource;
    public GameObject vbBtnObj;
    public TextMesh textObject;
    public int check;
    public Animator blockAnimation;
    
    // Start is called before the first frame update
    void Start(){
        vbBtnObj = GameObject.Find("BlockVirtualButton");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        textObject = (TextMesh)GameObject.Find("BlockFormula").GetComponent<TextMesh>();
        textObject.gameObject.SetActive(false);
        check = 1;
        blockAnimation.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb){
        if(check == 1){
            check = 0;
            textObject.gameObject.SetActive(true);
            blockAnimation.enabled = true;
            blockAnimation.Play("BlockAnimation");
            vbBtnObj.transform.Find("Button").GetComponent<TextMesh>().text = "Hide Formula";
            audioSource.Play();
        }
        else{
            check = 1;
            textObject.gameObject.SetActive(false);
            blockAnimation.enabled = false;
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


