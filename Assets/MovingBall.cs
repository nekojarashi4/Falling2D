using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovingBall : MonoBehaviour
{
    private GameObject MainCamera;

    private float ymove;

    private GameObject gameOverText;

    public AudioSource AS;

    void Start()
    {

        this.MainCamera = GameObject.Find("Main Camera");

        myRigidbody = GetComponent<Rigidbody2D>();

        this.gameOverText = GameObject.Find("GameOver");

        AS = GetComponent<AudioSource>();
    }

    //先ほど作成したJoystick
    [SerializeField]
    private Joystick _joystick = null;

    private Rigidbody2D myRigidbody;

    //移動速度
    private const float SPEED = 0.1f;

    private float moveForce = 5f;

    private void Update()
    {
        ymove = MainCamera.transform.position.y;

        Vector3 pos = transform.position;

        if ((pos.x >= -2.5f) && (_joystick.Position.x < 0))
        {
            //左に移動
            this.myRigidbody.AddForce(new Vector2(this.moveForce * _joystick.Position.x, 0f));
        }

        if ((pos.x <= 2.5f) && (_joystick.Position.x > 0))
        {
            //右に移動
            this.myRigidbody.AddForce(new Vector2(this.moveForce * _joystick.Position.x, 0f));
        }

        if ((pos.y >= ymove-5f) && (_joystick.Position.y < 0))
        {
            //下に移動
            this.myRigidbody.AddForce(new Vector2(0f,this.moveForce * _joystick.Position.y));
        }

        if ((pos.y <= ymove+5f) && (_joystick.Position.y > 0))
        {
            //上に移動
            this.myRigidbody.AddForce(new Vector2(0f, this.moveForce * _joystick.Position.y));
        }

        if (pos.y <= ymove - 5f)
        {
            this.myRigidbody.velocity = new Vector2(0f,0f);//サッカーボールが画面下端に着いた時にボールを完全に停止させたい
        }

        if (pos.y >= ymove + 5f)
        {
            this.MainCamera.GetComponent<MyCameraController>().speed = 0f;
            this.gameOverText.GetComponent<Text>().text = "GameOver";// GameOverにする（Textも表示）
        }

        if (ymove <= -400f)
        {
            this.MainCamera.GetComponent<MyCameraController>().speed = 0f;
            this.gameOverText.GetComponent<Text>().text = "GameClear";
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "abstacle")
        {
            //AS.PlayOneShot(A);
            AS.Play();
        }
    }
}
