using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {

    private CharacterController controller;

    public float speed = 10;

    public bool getMagic = false;

    public float timer = 1f;

    private float timerReset;

    public GameObject magicPrefab;


    void Start()
    {
        controller = this.GetComponent<CharacterController>();

        timerReset = timer;

    }

	
	// Update is called once per frame
	void Update () {


        controller.SimpleMove(new Vector3(Input.GetAxis("Horizontal") * speed, 0, Input.GetAxis("Vertical") * speed));


        if (getMagic)
        {
            timer -= Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.Space) && timer <= 0)
            {
                GameObject.Instantiate(magicPrefab, transform.position, Quaternion.identity);
                timer = timerReset;

            }
        }
	}
}
