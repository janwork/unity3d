using UnityEngine;
using System.Collections;

public class GUIManager : MonoBehaviour {
	
	private MouseOrbit mo;
	// Use this for initialization
	void Start () {
		mo = Camera.main.GetComponent<MouseOrbit>();
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			mo.distance -= 0.5f;
		}else if(Input.GetKeyDown(KeyCode.DownArrow))
		{
			mo.distance += 0.5f;
		}
	}
	
	void OnGUI()
	{
		GUI.Label(new Rect(10,10, 500, 45), "To view animations, click the following number:");
		GUI.Label(new Rect(10,35, 200, 450),"1 = idle\n2 = walk\n3 = run\n4 = get hit\n5 = claw attack\n6 = foot attack\n7 = death\n\nup arrow = zoom in\ndown arrow = zoom out");
		
	
	}
}
