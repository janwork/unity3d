using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class MyCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Camera.main.DOShakePosition(2, new Vector3(5, 6, 7));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
