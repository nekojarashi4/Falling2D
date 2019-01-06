using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    private GameObject downLengthText;

    private GameObject MyLevel;

    private float len = 0;

    private float mlv;

    private GameObject mainCamera;

    // Use this for initialization
    void Start () {

        this.MyLevel = GameObject.Find("myLevel");
        this.downLengthText = GameObject.Find("myResultText");
        this.mainCamera = GameObject.Find("Main Camera");

        

      
    }
	
	// Update is called once per frame
	void Update () {
        len = mainCamera.transform.position.y * -1f;
        this.downLengthText.GetComponent<Text>().text = "Distance:  " + len.ToString("F2") + "m";

        if (len < 100)
        {
            mlv = 1f;
            this.MyLevel.GetComponent<Text>().text = "Level:  " + mlv.ToString();
        }else if (100 <= len && len < 200)
        {
            mlv = 2f;
            this.MyLevel.GetComponent<Text>().text = "Level:  " + mlv.ToString();
        }
        else if (200 <= len && len < 300)
        {
            mlv = 3f;
            this.MyLevel.GetComponent<Text>().text = "Level:  " + mlv.ToString();
        }
        else if (300 <= len && len < 400)
        {
            mlv = 4f;
            this.MyLevel.GetComponent<Text>().text = "Level:  " + mlv.ToString();
        }

    }
}
