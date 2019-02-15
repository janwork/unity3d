using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skill : MonoBehaviour {

    public float coldTime = 2.0f;

    public KeyCode keycode;

    private Image filledImage;

    private float timer = 0f;

    private bool isStartTimer = false;


	// Use this for initialization
	void Start () {

        filledImage = transform.Find("Alpha").GetComponent<Image>();

		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(keycode))
        {
            isStartTimer = true;
        }



        if (isStartTimer)
        {
            filledImage.IsActive();
            timer += Time.deltaTime;
            filledImage.fillAmount = (coldTime - timer) / coldTime;

            if (timer >= coldTime)
            {
                timer = 0;
                isStartTimer = false;
                filledImage.fillAmount = 0;

            }
        }
	}

    public void OnClickSkillBtn()
    {
        isStartTimer = true;
    }
}
