using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPhisycs : MonoBehaviour {

	public int bulletSpeed;
	public float moveX,moveY;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		moveX = Input.GetAxis("Horizontal");
		moveY = Input.GetAxis("Vertical");

		GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * bulletSpeed, moveY *bulletSpeed);


	}
}
