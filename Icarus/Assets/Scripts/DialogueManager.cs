using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    public GameObject dialogueBox;
    public GameObject controlsScroll;
    public Text dialogueText;

    public bool dialogueActive;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (dialogueActive && Input.GetKeyDown(KeyCode.Space))
        {
            controlsScroll.SetActive(false);
            dialogueBox.SetActive(false);
            dialogueActive = false;
        }
	}
}
