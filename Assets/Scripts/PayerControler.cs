using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PayerControler : MonoBehaviour {

	public int playerSpeed;
	public float moveX;
	public int numOfMoves;

	// Use this for initialization
	void Start () {
		moveX = 1;
		numOfMoves = 0;
	}
	
	// Update is called once per frame
	void Update () {

		/**
		igrac se pomera levo, odnosno desno, maks koliko moze da se pomeri je 3 poteza
		 */


		if(numOfMoves < 3){
		if(Input.GetKeyUp("d")){
		gameObject.GetComponent<Rigidbody2D>().velocity = 
									new Vector2(moveX*playerSpeed,gameObject.GetComponent<Rigidbody2D>().velocity.y);
			numOfMoves++;
		}
		if(Input.GetKeyUp("a")){
			gameObject.GetComponent<Rigidbody2D>().velocity =
									new Vector2(moveX *playerSpeed,gameObject.GetComponent<Rigidbody2D>().velocity.y);
			numOfMoves++;
		}
		}
	}
}
