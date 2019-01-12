using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour {

    private static bool healthbarExists;

	// Use this for initialization
	void Start () {

        if (!healthbarExists)
        {
            healthbarExists = true;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
