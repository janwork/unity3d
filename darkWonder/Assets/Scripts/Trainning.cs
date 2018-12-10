using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trainning : MonoBehaviour {

    public bool isStart = false;
    public float timer = 10f;
    public float resetTimer;
    public bool isTrainningEnd = false;
    public GameObject player;
    public GameObject skillOne;
    public GameObject message;

    void Start()
    {
        resetTimer = timer;
    }

    void Update()
    {
        if (isStart && isTrainningEnd == false)
        {
            timer -= Time.deltaTime;
            Message.getInstance().showMessage(" 修炼时间: " + String.Format("{0:F2}", timer));
            if (timer <= 0)
            {
                isTrainningEnd = true;
                skillOne.SetActive(true);
                //Message.getInstance().hideMessage();
                Message.getInstance().showMessage(" 修炼完成");
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == player.name && isTrainningEnd == false)
        {
            isStart = true;
            timer = resetTimer;
            message.SetActive(true);
        }       

    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == player.name)
        {
            isStart = false;
            Message.getInstance().hideMessage();
        }
        
    }
}
