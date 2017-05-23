using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MagicalFX;

public class BlueToothController : MonoBehaviour {
    //public GameObject cube;
    //public Text text;
    public GameObject[] Skills;
    public GameObject cam;
    // Use this for initialization

    private GameObject skill;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown)
        {
            fire();
            Debug.Log(Input.inputString);
            //string name = 
            //text.text = ""
        }
	}

    public void fire()
    {
        skill = Skills[Random.Range(0, Skills.Length)];
        //Vector3 pos = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
        //Debug.Log(pos);
       // cube.transform.position = pos;
        GameObject sk = (GameObject)GameObject.Instantiate(skill, cam.transform.position, skill.transform.rotation);
        sk.transform.forward = (cam.transform.forward).normalized;
    }
    
}



