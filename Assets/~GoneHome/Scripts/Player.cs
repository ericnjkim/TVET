using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
[] - brackets
{} - braces
() - parenthesis

   Hot Keys:
   Clean code ctrl + K + D
   Fold code ctrl + M + O
   Unfold code ctrl + M + P

*/
public class Player : MonoBehaviour
{
    public string message = "Hello World!";
    public Rigidbody rigid;

    float speed = 5;
	// Use this for initialization
	void Start ()
    {
        rigid.AddForce(Vector3.forward * speed);
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            print("Hello World!");
        }
    }
}
