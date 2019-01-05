using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Troll : MonoBehaviour {

  
    public float speed = 5;
    public float hp = 10f;

    private bool isIdle = true;
    private float timer = 2.0f;
    private Animator anim;
    private CharacterController controller;
    private float angle = 0f;
    private float destroyTimer = 1.2f;
    private bool startDestroyTimer = false;


	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();

        angle = Random.Range(-90, 90);
	}
	
	// Update is called once per frame
	void Update () {

        if (hp <= 0)
        {
             if (startDestroyTimer)
             {
                 destroyTimer -= Time.deltaTime;
                 if (destroyTimer<= 0){
                     GameObject.Destroy(this.gameObject);
                 }
             }
            return;
        }

        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            if (isIdle)
            {
                transformToWalk();
            }
            else
            {
                transformToIdle();
             
            }
        }

        if (!isIdle)
        {
            if (Mathf.Abs(angle) >= 0.2f)
            {
                float temp = angle * 0.05f;
                transform.Rotate(new Vector3(0, temp, 0));
                angle -= temp;

            }
            else
            {
                angle = Random.Range(-90, 90);
            }
            //transform.position += transform.forward * Time.deltaTime *speed;
            controller.SimpleMove(transform.forward *speed);
        }
	}


    public void die()
    {
        //GameObject.Destroy(this.gameObject);
        anim.SetFloat("death", 1.0F);
        startDestroyTimer = true;
        TrollsBorn.trollCount--;
    }

    public void animationToWalk()
    {
        anim.SetFloat("run", 0.0F);
        anim.SetFloat("idle", 0F);
        anim.SetFloat("walk", 1.0F);
    }

    public void animationToIdle()
    {
        anim.SetFloat("idle", 1F);
        anim.SetFloat("walk", 0.0F);
        anim.SetFloat("run", 0F);
    }

    public void transformToWalk()
    {
        isIdle = false;
        timer = 5.0f;
        //transform.Rotate(new Vector3(0, temp, 0));
        animationToWalk();
    }

    public void transformToIdle()
    {
        isIdle = true;
        timer = 2.0f;
        animationToIdle();
    }
}
