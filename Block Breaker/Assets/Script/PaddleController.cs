using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    //Config param
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;
    [SerializeField] float widthOfBackgroundInUnity = 16f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mounsePosInUnit = Input.mousePosition.x / Screen.width * widthOfBackgroundInUnity;
        Vector2 paddlePosition = new Vector2(mounsePosInUnit, transform.position.y);
        paddlePosition.x = Mathf.Clamp(paddlePosition.x, minX, maxX);
        transform.position = paddlePosition;
    }
}
