using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
       PrintInstructions(); 
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    void PrintInstructions ()
    {
        Debug.Log("Welcome to the Game");
        Debug.Log("Move your player with WASD or Arrow Keys");
        Debug.Log("Don't hit the walls!");
    }

    void PlayerMovement()
    {
        float xAxis = Input.GetAxis("Horizontal")* Time.deltaTime * moveSpeed;
        float zAxis = Input.GetAxis("Vertical")* Time.deltaTime * moveSpeed;
        transform.Translate(xAxis,0,zAxis);
    }
}
