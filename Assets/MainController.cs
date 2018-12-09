using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour {

    private Rigidbody2D myRigidbody;

    private float downForce = 1f;

	// Use this for initialization
	void Start () {

        this.myRigidbody = GetComponent<Rigidbody2D>();

        //this.myRigidbody.AddForce(this.transform.forward * this.downForce);

    }
	
	// Update is called once per frame
	void Update () {

        //this.myRigidbody.AddForce(this.transform.forward * this.downForce);

	}
}
