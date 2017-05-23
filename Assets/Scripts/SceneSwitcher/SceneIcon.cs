using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneIcon : MonoBehaviour {
	private bool beingchosen;
	private float timer;

	public int SceneIndex;

	public bool BeingChosen {
		set {
			beingchosen = value;
		}
	}

	// Use this for initialization
	void Start () {
		timer = 0f;
		beingchosen = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void LateUpdate(){
		if (beingchosen) {
			this.transform.FindChild ("Loading").gameObject.SetActive (true);
			timer += Time.deltaTime;
			if (timer > 3f) {
				timer = 0;
				SceneManager.LoadScene (SceneIndex);
			}
		} else {
			this.transform.FindChild ("Loading").gameObject.SetActive (false);
			timer = 0;
		}
	}
}
