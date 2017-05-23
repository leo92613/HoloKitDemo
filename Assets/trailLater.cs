using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trailLater : MonoBehaviour {
    public float startTime = 0.5f;

    private TrailRenderer trail;
	// Use this for initialization
	void Start () {
        trail = GetComponent<TrailRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
