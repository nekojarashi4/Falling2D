﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCameraController : MonoBehaviour {

    private GameObject SoccerBall;

    private float CameraIchi;

    public float speed;

	// Use this for initialization
	void Start () {

        this.SoccerBall = GameObject.Find("SoccerBall");

        

    }
	
	// Update is called once per frame
	void Update () {

        //this.CameraIchi = SoccerBall.transform.position.y - 4;

        this.transform.position = this.transform.position + new Vector3(0, speed, 0);

	}
}
