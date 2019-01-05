using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrollsBorn : MonoBehaviour {

    public GameObject trollPrefab;

    public static int trollCount= 0;

    public static int trollMaxCount = 5;

    public float timer = 5;

    private float timerReset;


	// Use this for initialization
	void Start () {
        timerReset = timer;
	}
	
	// Update is called once per frame
	void Update () {

        if (trollCount < trollMaxCount)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                //born troll
                GameObject.Instantiate(trollPrefab, transform.position, Quaternion.identity);
                trollCount++;
                timer = timerReset;
            }
        }
	}
}
