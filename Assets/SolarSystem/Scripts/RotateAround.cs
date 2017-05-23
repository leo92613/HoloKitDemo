using UnityEngine;
using System.Collections;

public class RotateAround : MonoBehaviour {
    
    public Transform centerMass;
    public Transform revealingLight;
    //public GameObject sun;

    public float rotationAroundPlanetSpeed;
    public float planetSunDistance;
    public float planetSpeedRotation;
    public float Kepler = 0.00000001f;

    private GlobalValues globalValuesScript;
    // Use this for initialization
    void Start () {
        //globalValuesScript = Camera.main.GetComponent<GlobalValues>();

       

    }
    public void reStart()
    {
        transform.position = (transform.position - centerMass.position).normalized * planetSunDistance + centerMass.position;
        float a3 = Mathf.Pow(planetSunDistance, 3.0f);
        float t = Mathf.Pow(a3 * Kepler, 0.5f);
        rotationAroundPlanetSpeed = planetSunDistance / t;
        //rotationAroundPlanetSpeed = rotationAroundSunDays / defaultEarthYear;

        // For reveal light - must follow Planet and retain the same position
        if (revealingLight != null)
        {
            revealingLight.transform.LookAt(transform.position);
        }

        TrailRenderer trail = GetComponentInChildren<TrailRenderer>();
        trail.Clear();
    }
    // Update is called once per frame

	// Update is called once per frame
	void Update () {
        //if (planet != null)
        //{
        //    transform.position = planet.position + (transform.position - planet.position).normalized * satelliteOrbitDistance;
        //    transform.RotateAround(planet.position, Vector3.up, rotationAroundPlanetSpeed * Time.deltaTime);
        //}

        //transform.LookAt(sun);
        //transform.Translate(Vector3.right * Time.deltaTime * (defaultEarthYear / rotationAroundSunDays) * (globalValuesScript.globalPlanetRotationAroundSun) * (rotationAroundSunDays / defaultEarthYear));



        //transform.RotateAround(centerMass.position, Vector3.up, Time.deltaTime * (defaultEarthYear / rotationAroundSunDays) * (globalValuesScript.globalPlanetRotationAroundSun) * Time.deltaTime);
        transform.RotateAround(centerMass.position, Vector3.up, Time.deltaTime * rotationAroundPlanetSpeed * Time.deltaTime);
        transform.Rotate(-Vector3.up * Time.deltaTime * planetSpeedRotation);
    }
    
}
