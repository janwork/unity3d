using UnityEngine;
using System.Collections;

public class TrollManager : MonoBehaviour {
	
	private Animator anim;
	
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
		
	
		if(Input.GetKeyDown(KeyCode.Alpha1))
		{
			anim.SetFloat("idle", 1F);
			anim.SetFloat("walk", 0.0F);
			anim.SetFloat("run", 0F);
		}
		
		
		if(Input.GetKeyDown(KeyCode.Alpha2))
		{
		
			anim.SetFloat("run", 0.0F);
			anim.SetFloat("idle", 0F);
			anim.SetFloat("walk", 1.0F);
		}
		
		
			
		if(Input.GetKeyDown(KeyCode.Alpha3))
		{
			Debug.Log("3 hit");
			anim.SetFloat("idle", 0F);
			anim.SetFloat("walk", 0.0F);
			anim.SetFloat("run", 1.0F);
		}
		
		
			
		if(Input.GetKeyDown(KeyCode.Alpha4))
		{
			Debug.Log("3 hit");
			anim.SetFloat("get_hit", 1.0F);
		}
		else if(Input.GetKeyUp(KeyCode.Alpha4))
		{
			anim.SetFloat("get_hit", -1F);
		}
		
		
		if(Input.GetKeyDown(KeyCode.Alpha5))
		{
			Debug.Log("5 hit");
			anim.SetFloat("clawAttack", 1.0F);
		}
		else if(Input.GetKeyUp(KeyCode.Alpha5))
		{
			anim.SetFloat("clawAttack", -1F);
		}
		
		if(Input.GetKeyDown(KeyCode.Alpha6))
		{
			Debug.Log("6 hit");
			anim.SetFloat("footAttack", 1.0F);
		}
		else if(Input.GetKeyUp(KeyCode.Alpha6))
		{
			anim.SetFloat("footAttack", -1F);
		}
		
			if(Input.GetKeyDown(KeyCode.Alpha7))
		{
			Debug.Log("6 hit");
			anim.SetFloat("death", 1.0F);
		}
		else if(Input.GetKeyUp(KeyCode.Alpha7))
		{
			anim.SetFloat("death", -1F);
		}
	}
}
