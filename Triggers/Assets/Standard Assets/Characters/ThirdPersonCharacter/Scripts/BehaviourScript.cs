using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BehaviourScript : MonoBehaviour {

    public GameObject LightG;
    // Use this for initialization
    void Start () {
       
}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.GetComponent<Collider>().CompareTag("Player"))
		{
			LightG.GetComponent<Light>().color = Color.red;
			//AudioSource sound = other.GetComponent<AudioSource>();
			//sound.Play();
		}
	}
}
