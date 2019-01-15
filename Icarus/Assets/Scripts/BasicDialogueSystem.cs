using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicDialogueSystem : MonoBehaviour {

    public GameObject dialogueBox;


    public bool dialogueActive;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (dialogueActive && Input.GetKeyDown(KeyCode.Space))
        {
            dialogueBox.SetActive(false);
            dialogueActive = false;
        }
	}
}
