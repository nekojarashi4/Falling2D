using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{

    private GameObject SoccerBall;

    private float groundGeneratePoint = 3;

    private float obstacleGeneratePointone = 3;

    private float obstacleGeneratePointtwo = 3;

    public GameObject groundPrefab;

    public GameObject leftPrefab;

    public GameObject rightPrefab;

    public GameObject obstaclePrefab;

    private float len = 0;

    private GameObject mainCamera;

    // Use this for initialization
    void Start()
    {

        this.SoccerBall = GameObject.Find("SoccerBall");

        this.mainCamera = GameObject.Find("Main Camera");

        len = mainCamera.transform.position.y * -1f;

    }

    // Update is called once per frame
    void Update()
    {
        if (len < 100)
        {
            if (this.groundGeneratePoint >= SoccerBall.transform.position.y - 10)
            {
                GameObject ground = Instantiate(groundPrefab) as GameObject;
                ground.transform.position = new Vector3(0, groundGeneratePoint - 13, 0);

                GameObject leftprefab = Instantiate(leftPrefab) as GameObject;
                leftprefab.transform.position = new Vector3(-2.8f, groundGeneratePoint - 13, 0);
                GameObject rightprefab = Instantiate(rightPrefab) as GameObject;
                rightprefab.transform.position = new Vector3(2.8f, groundGeneratePoint - 13, 0);

                this.groundGeneratePoint -= 10;
            }

            if (this.obstacleGeneratePointone >= SoccerBall.transform.position.y - 10)
            {
                float numx = Random.Range(-3f, 3f);

                float numy = Random.Range(groundGeneratePoint - 8, groundGeneratePoint - 13);

                float numa = Random.Range(0.5f, 1.3f);

                float anglez = Random.Range(0f, 360f);

                GameObject obstacleprefab = Instantiate(obstaclePrefab) as GameObject;
                obstacleprefab.transform.position = new Vector3(numx, numy, 0);
                obstacleprefab.transform.localScale = new Vector3(numa, numa, 0f);
                obstacleprefab.transform.rotation = Quaternion.Euler(0, 0, anglez);

                this.obstacleGeneratePointone -= 10;
            }

            if (this.obstacleGeneratePointtwo >= SoccerBall.transform.position.y - 10)
            {
                float numx = Random.Range(-3f, 3f);

                float numy = Random.Range(groundGeneratePoint - 13, groundGeneratePoint - 18);

                float numa = Random.Range(0.5f, 1.3f);

                float anglez = Random.Range(0f, 360f);

                GameObject obstacleprefab = Instantiate(obstaclePrefab) as GameObject;
                obstacleprefab.transform.position = new Vector3(numx, numy, 0);
                obstacleprefab.transform.localScale = new Vector3(numa, numa, 0f);
                obstacleprefab.transform.rotation = Quaternion.Euler(0, 0, anglez);

                this.obstacleGeneratePointtwo -= 10;

            }
        }
        else if (100 <= len && len < 200)//レベル2
        {
            if (this.groundGeneratePoint >= SoccerBall.transform.position.y - 10)
            {
                GameObject ground = Instantiate(groundPrefab) as GameObject;
                ground.transform.position = new Vector3(0, groundGeneratePoint - 13, 0);

                GameObject leftprefab = Instantiate(leftPrefab) as GameObject;
                leftprefab.transform.position = new Vector3(-2.8f, groundGeneratePoint - 13, 0);
                GameObject rightprefab = Instantiate(rightPrefab) as GameObject;
                rightprefab.transform.position = new Vector3(2.8f, groundGeneratePoint - 13, 0);

                this.groundGeneratePoint -= 10;
            }

            if (this.obstacleGeneratePointone >= SoccerBall.transform.position.y - 10)
            {
                float numx = Random.Range(-3f, 3f);

                float numy = Random.Range(groundGeneratePoint - 8, groundGeneratePoint - 13);

                float numa = Random.Range(0.7f, 1.8f);

                float anglez = Random.Range(0f, 360f);

                GameObject obstacleprefab = Instantiate(obstaclePrefab) as GameObject;
                obstacleprefab.transform.position = new Vector3(numx, numy, 0);
                obstacleprefab.transform.localScale = new Vector3(numa, numa, 0f);
                obstacleprefab.transform.rotation = Quaternion.Euler(0, 0, anglez);

                this.obstacleGeneratePointone -= 10;
            }

            if (this.obstacleGeneratePointtwo >= SoccerBall.transform.position.y - 10)
            {
                float numx = Random.Range(-3f, 3f);

                float numy = Random.Range(groundGeneratePoint - 13, groundGeneratePoint - 18);

                float numa = Random.Range(0.7f, 1.8f);

                float anglez = Random.Range(0f, 360f);

                GameObject obstacleprefab = Instantiate(obstaclePrefab) as GameObject;
                obstacleprefab.transform.position = new Vector3(numx, numy, 0);
                obstacleprefab.transform.localScale = new Vector3(numa, numa, 0f);
                obstacleprefab.transform.rotation = Quaternion.Euler(0, 0, anglez);

                this.obstacleGeneratePointtwo -= 10;
            }
        }
        else if (200 <= len && len < 300)//レベル3
        {
            if (this.groundGeneratePoint >= SoccerBall.transform.position.y - 10)
            {
                GameObject ground = Instantiate(groundPrefab) as GameObject;
                ground.transform.position = new Vector3(0, groundGeneratePoint - 13, 0);

                GameObject leftprefab = Instantiate(leftPrefab) as GameObject;
                leftprefab.transform.position = new Vector3(-2.8f, groundGeneratePoint - 13, 0);
                GameObject rightprefab = Instantiate(rightPrefab) as GameObject;
                rightprefab.transform.position = new Vector3(2.8f, groundGeneratePoint - 13, 0);

                this.groundGeneratePoint -= 10;
            }

            if (this.obstacleGeneratePointone >= SoccerBall.transform.position.y - 10)
            {
                float numx = Random.Range(-3f, 3f);

                float numy = Random.Range(groundGeneratePoint - 8, groundGeneratePoint - 13);

                float numa = Random.Range(0.4f, 1.3f);

                float anglez = Random.Range(0f, 360f);

                GameObject obstacleprefab = Instantiate(obstaclePrefab) as GameObject;
                obstacleprefab.transform.position = new Vector3(numx, numy, 0);
                obstacleprefab.transform.localScale = new Vector3(numa, numa, 0f);
                obstacleprefab.transform.rotation = Quaternion.Euler(0, 0, anglez);

                this.obstacleGeneratePointone -= 10;
            }

            if (this.obstacleGeneratePointone >= SoccerBall.transform.position.y - 10)
            {
                float numx = Random.Range(-3f, 3f);

                float numy = Random.Range(groundGeneratePoint - 8, groundGeneratePoint - 13);

                float numa = Random.Range(0.4f, 1.3f);

                float anglez = Random.Range(0f, 360f);

                GameObject obstacleprefab = Instantiate(obstaclePrefab) as GameObject;
                obstacleprefab.transform.position = new Vector3(numx, numy, 0);
                obstacleprefab.transform.localScale = new Vector3(numa, numa, 0f);
                obstacleprefab.transform.rotation = Quaternion.Euler(0, 0, anglez);

                this.obstacleGeneratePointone -= 10;
            }

            if (this.obstacleGeneratePointtwo >= SoccerBall.transform.position.y - 10)
            {
                float numx = Random.Range(-3f, 3f);

                float numy = Random.Range(groundGeneratePoint - 13, groundGeneratePoint - 18);

                float numa = Random.Range(0.4f, 1.3f);

                float anglez = Random.Range(0f, 360f);

                GameObject obstacleprefab = Instantiate(obstaclePrefab) as GameObject;
                obstacleprefab.transform.position = new Vector3(numx, numy, 0);
                obstacleprefab.transform.localScale = new Vector3(numa, numa, 0f);
                obstacleprefab.transform.rotation = Quaternion.Euler(0, 0, anglez);

                this.obstacleGeneratePointtwo -= 10;
            }
            if (this.obstacleGeneratePointtwo >= SoccerBall.transform.position.y - 10)
            {
                float numx = Random.Range(-3f, 3f);

                float numy = Random.Range(groundGeneratePoint - 13, groundGeneratePoint - 18);

                float numa = Random.Range(0.4f, 1.3f);

                float anglez = Random.Range(0f, 360f);

                GameObject obstacleprefab = Instantiate(obstaclePrefab) as GameObject;
                obstacleprefab.transform.position = new Vector3(numx, numy, 0);
                obstacleprefab.transform.localScale = new Vector3(numa, numa, 0f);
                obstacleprefab.transform.rotation = Quaternion.Euler(0, 0, anglez);

                this.obstacleGeneratePointtwo -= 10;
            }
        }
        else if (300 <= len && len < 400)//レベル4
        {
            if (this.groundGeneratePoint >= SoccerBall.transform.position.y - 10)
            {
                GameObject ground = Instantiate(groundPrefab) as GameObject;
                ground.transform.position = new Vector3(0, groundGeneratePoint - 13, 0);

                GameObject leftprefab = Instantiate(leftPrefab) as GameObject;
                leftprefab.transform.position = new Vector3(-2.8f, groundGeneratePoint - 13, 0);
                GameObject rightprefab = Instantiate(rightPrefab) as GameObject;
                rightprefab.transform.position = new Vector3(2.8f, groundGeneratePoint - 13, 0);

                this.groundGeneratePoint -= 10;
            }

            if (this.obstacleGeneratePointone >= SoccerBall.transform.position.y - 10)
            {
                float numx = Random.Range(-3f, 3f);

                float numy = Random.Range(groundGeneratePoint - 8, groundGeneratePoint - 13);

                float numa = Random.Range(0.7f, 1.6f);

                float anglez = Random.Range(0f, 360f);

                GameObject obstacleprefab = Instantiate(obstaclePrefab) as GameObject;
                obstacleprefab.transform.position = new Vector3(numx, numy, 0);
                obstacleprefab.transform.localScale = new Vector3(numa, numa, 0f);
                obstacleprefab.transform.rotation = Quaternion.Euler(0, 0, anglez);

                this.obstacleGeneratePointone -= 10;
            }

            if (this.obstacleGeneratePointone >= SoccerBall.transform.position.y - 10)
            {
                float numx = Random.Range(-3f, 3f);

                float numy = Random.Range(groundGeneratePoint - 8, groundGeneratePoint - 13);

                float numa = Random.Range(0.7f, 1.6f);

                float anglez = Random.Range(0f, 360f);

                GameObject obstacleprefab = Instantiate(obstaclePrefab) as GameObject;
                obstacleprefab.transform.position = new Vector3(numx, numy, 0);
                obstacleprefab.transform.localScale = new Vector3(numa, numa, 0f);
                obstacleprefab.transform.rotation = Quaternion.Euler(0, 0, anglez);

                this.obstacleGeneratePointone -= 10;
            }

            if (this.obstacleGeneratePointtwo >= SoccerBall.transform.position.y - 10)
            {
                float numx = Random.Range(-3f, 3f);

                float numy = Random.Range(groundGeneratePoint - 13, groundGeneratePoint - 18);

                float numa = Random.Range(0.7f, 1.6f);

                float anglez = Random.Range(0f, 360f);

                GameObject obstacleprefab = Instantiate(obstaclePrefab) as GameObject;
                obstacleprefab.transform.position = new Vector3(numx, numy, 0);
                obstacleprefab.transform.localScale = new Vector3(numa, numa, 0f);
                obstacleprefab.transform.rotation = Quaternion.Euler(0, 0, anglez);

                this.obstacleGeneratePointtwo -= 10;
            }
            if (this.obstacleGeneratePointtwo >= SoccerBall.transform.position.y - 10)
            {
                float numx = Random.Range(-3f, 3f);

                float numy = Random.Range(groundGeneratePoint - 13, groundGeneratePoint - 18);

                float numa = Random.Range(0.7f, 1.6f);

                float anglez = Random.Range(0f, 360f);

                GameObject obstacleprefab = Instantiate(obstaclePrefab) as GameObject;
                obstacleprefab.transform.position = new Vector3(numx, numy, 0);
                obstacleprefab.transform.localScale = new Vector3(numa, numa, 0f);
                obstacleprefab.transform.rotation = Quaternion.Euler(0, 0, anglez);

                this.obstacleGeneratePointtwo -= 10;
            }
        }
    }
}
