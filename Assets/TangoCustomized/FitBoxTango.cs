using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FitBoxTango : MonoBehaviour {

	[Tooltip("The collection of holograms to show when the Fitbox is dismissed.")]
    public GameObject HologramCollection;

	//private GestureRecognizer recognizer;

	void Awake(){
		#if UNITY_EDITOR
        // If we are running inside Unity's Editor, disable the Fitbox script
        // as there is no easy way to dismiss it to see our actual holograms.
        	enabled = false;
		#else // UNITY_EDITOR
        #endif
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
