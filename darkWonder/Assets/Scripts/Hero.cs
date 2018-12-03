using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {

    private CharacterController controller;

    public float speed = 10;

    void Start()
    {
        controller = this.GetComponent<CharacterController>();

    }

	
	// Update is called once per frame
	void Update () {
        
       float h = Input.GetAxis("Horizontal");
       float v = Input.GetAxis("Vertical");

       controller.SimpleMove(new Vector3(h * speed, 0, v * speed));
	}
}
