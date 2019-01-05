using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Message : MonoBehaviour {

    public static Message _instance;
    //public GUIText guiText;

	// Use this for initialization
	void Start () {
        _instance = this;
        _instance.gameObject.SetActive(false);
        //print(_instance.gameObject.name);
	}

    public  static Message getInstance(){
        return _instance;
    }

    public void showMessage(string message)
    {
        this.gameObject.GetComponent<Text>().text = message;
        this.gameObject.SetActive(true);
    }

    public void hideMessage()
    {
        this.gameObject.SetActive(false);
    }
}
