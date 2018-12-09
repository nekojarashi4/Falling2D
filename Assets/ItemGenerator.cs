using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour {

    private GameObject SoccerBall;

    private float groundGeneratePoint=3;

    public GameObject groundPrefab;

    // Use this for initialization
    void Start () {

        this.SoccerBall = GameObject.Find("SoccerBall");

    }
	
	// Update is called once per frame
	void Update () {

        if (this.groundGeneratePoint >= SoccerBall.transform.position.y)
        {
            GameObject ground = Instantiate(groundPrefab) as GameObject;
            ground.transform.position = new Vector3(0, groundGeneratePoint - 10, -10);
            this.groundGeneratePoint -= 10;
        }
        
    }
}
