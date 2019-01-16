using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {
    // This is the same as the basic Dialogue system but includes more variables for the tutorial

    // UI components for tutorial
    public GameObject dialogueBox;
    public GameObject controlsScroll;
    public Text dialogueText;
    public GameObject hint;

    public bool dialogueActive;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // If the Dialogue Box is active and the player presses space
        if (dialogueActive && Input.GetKeyDown(KeyCode.Space))
        {
            // Set the UI Components to false
            controlsScroll.SetActive(false);
            dialogueBox.SetActive(false);
            hint.SetActive(false);
            dialogueActive = false;
        }
	}
}
