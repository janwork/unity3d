using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClickStartBtn()
    {
        Debug.Log("Start");
    }

    public void OnClickSoundBtn()
    {
        Debug.Log("Sound");
    }

    public void OnClickMailBtn()
    {
        Debug.Log("Mail");
    }

    public void OnClickMoreGameBtn()
    {
        Debug.Log("MoreGame");
    }

    public void OnClickSettingBtn()
    {
        Debug.Log("Setting");
    }

}
