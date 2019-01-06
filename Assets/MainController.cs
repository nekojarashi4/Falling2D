using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour {

    private Rigidbody2D myRigidbody;

    private float downForce = 10f;

	// Use this for initialization
	void Start () {

        this.myRigidbody = GetComponent<Rigidbody2D>();

        //this.myRigidbody.AddForce(this.transform.forward * this.downForce);

        this.myRigidbody.velocity = Vector2.down * 1f;
    }
	
	// Update is called once per frame
	void Update () {

        //this.myRigidbody.AddForce(this.transform.forward * this.downForce);

	}
}
