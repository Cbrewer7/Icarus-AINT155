using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicDialogueSystem : MonoBehaviour {

    public GameObject dialogueBox;

    // Whether or not the dialog box is active in the scene
    public bool dialogueActive;
	
	// Update is called once per frame
	void Update ()
    {
        // When the dialogue box is active and the space key is pressed,
        // deactivate the dialogue box
        if (dialogueActive && Input.GetKeyDown(KeyCode.Space))
        {
            dialogueBox.SetActive(false);
            dialogueActive = false;
        }
	}
}
