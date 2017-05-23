using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaling : MonoBehaviour {
    public ScaleController ScaleController;

    private float scale;
    private RotateAround rot;
    private Transform trans;
    private TrailRenderer trail;
    // Use this for initialization
	void Start () {
        scale = ScaleController.scale;
        rot = GetComponent<RotateAround>();
        trans = GetComponent<Transform>();
        trail = GetComponentInChildren<TrailRenderer>();

        trans.localScale *= scale;
        rot.planetSunDistance *= scale;
        rot.Kepler /= scale;
        trail.startWidth *= scale;

        rot.reStart();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
