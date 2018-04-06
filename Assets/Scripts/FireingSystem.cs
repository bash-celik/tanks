using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireingSystem : MonoBehaviour {

	public GameObject bullet;
	public GameObject pivotPoint;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		fire();
	}

	void fire(){
			if(Input.GetMouseButtonDown(0)){
				Vector3 bulletPos = new Vector3(transform.position.x,transform.position.y,transform.position.z);
				Instantiate(bullet,bulletPos,pivotPoint.transform.rotation);
		}
	}
	
}
