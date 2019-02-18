using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchBtn : MonoBehaviour {

    public GameObject switchOn;
    public GameObject switchOff;
    private Toggle toggle;

	// Use this for initialization
	void Start () {
        toggle = this.GetComponent<Toggle>();
        if (toggle.isOn)
        {
            switchOn.SetActive(true);
            switchOff.SetActive(false);
        }
        else
        {
            switchOn.SetActive(false);
            switchOff.SetActive(true);
        }
	}
	
	// Update is called once per frame
    public void OnValueChanged(bool isOn)
    {
        switchOn.SetActive(isOn);
        switchOff.SetActive(!isOn);
    }
}
