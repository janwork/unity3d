using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LevelScrollBtn : MonoBehaviour , IBeginDragHandler,IEndDragHandler{

    public Toggle[] toggleArray;

    private ScrollRect scrollRect;
    private float[] pageArray = new float[]{0.0f, 0.333f, 0.666f, 1};
    private float targetHorizontalPosition = 0;
    private int smothingTime = 4;
    private bool isDragging = false;

	// Use this for initialization
	void Start () {
        scrollRect = this.GetComponent<ScrollRect>();
	}
	
	// Update is called once per frame
	void Update () {
        if (!isDragging)
        {
            scrollRect.horizontalNormalizedPosition = Mathf.Lerp(scrollRect.horizontalNormalizedPosition, targetHorizontalPosition, Time.fixedDeltaTime * smothingTime);
        }
    
	}

    public void OnBeginDrag(PointerEventData eventData)
    {
        isDragging = true;
    }


    public void OnEndDrag(PointerEventData eventData)
    {

        //Debug.Log(scrollRect.horizontalNormalizedPosition);
        float posX = scrollRect.horizontalNormalizedPosition;
        int index = 0;

        float offSet = Mathf.Abs(pageArray[index] - posX);

        for (int i = 1; i < pageArray.Length; i++)
        {
            float offsetTemp = Mathf.Abs(pageArray[i] - posX);
            if (offsetTemp < offSet)
            {
                index = i;
                offSet = offsetTemp;
            }
        }

        targetHorizontalPosition = pageArray[index];

        toggleArray[index].isOn = true;

        isDragging = false;
    }

    public void MoveToPage1(bool isOn)
    {

        isDragging = false;
        if (isOn)
        {
            targetHorizontalPosition = pageArray[0];
        }
    }

    public void MoveToPage2(bool isOn)
    {
        isDragging = false;

        if (isOn)
        {
            targetHorizontalPosition = pageArray[1];
        }
    }

    public void MoveToPage3(bool isOn)
    {
        isDragging = false;

        if (isOn)
        {
            targetHorizontalPosition = pageArray[2];
        }
    }

    public void MoveToPage4(bool isOn)
    {
        isDragging = false;

        if (isOn)
        {
            targetHorizontalPosition = pageArray[3];
        }
    }
}
