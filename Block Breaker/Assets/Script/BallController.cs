using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] PaddleController paddle1;

    //State
    Vector2 paddleToBallVector;
    bool hasStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        this.paddleToBallVector = transform.position - paddle1.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(!hasStarted)
        {
            this.LockBallByPaddle();
            this.ClickMounse();
        }
    }

    private void LockBallByPaddle()
    {
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlePos + this.paddleToBallVector;
    }

    private void ClickMounse()
    {
        if(Input.GetMouseButtonDown(0))
        {
            this.hasStarted = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 15f);
        }
    }
}
