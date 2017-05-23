/// <summary>
/// Camera cursor.
/// Add this script to Camera(Head) in each of the scene.
/// </summary>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCursor : MonoBehaviour {
	private Ray ray;
	private RaycastHit hit;
	private SceneIcon lasticon;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ray = new Ray (transform.position, transform.forward);

		if (Physics.Raycast (ray, out hit)) {
			if (hit.transform.gameObject.GetComponent<SceneIcon> ()) {
				if (lasticon != null) {
					if (lasticon != hit.transform.gameObject.GetComponent<SceneIcon> ()) {
						hit.transform.gameObject.GetComponent<SceneIcon> ().BeingChosen = true;
						lasticon.BeingChosen = false;
						lasticon = hit.transform.gameObject.GetComponent<SceneIcon> ();
					}
				} else {
					hit.transform.gameObject.GetComponent<SceneIcon> ().BeingChosen = true;
					lasticon = hit.transform.gameObject.GetComponent<SceneIcon> ();
				}
			} else {
				if (lasticon != null) {
					lasticon.BeingChosen = false;
					lasticon = null;
				}
			}
		} else {
			if (lasticon != null) {
				lasticon.BeingChosen = false;
				lasticon = null;
			}
		}
	}
}
