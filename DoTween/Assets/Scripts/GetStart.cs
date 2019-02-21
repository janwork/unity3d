using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GetStart : MonoBehaviour {

    private GameObject panel;

    private bool isShowed = false;

    //public Transform rt; // 3d

    //public RectTransform rtf;

    //public Vector3 myValue = new Vector3(0, 0, 0);

    //public float myValue2 = 0;


	// Use this for initialization
	void Start () {

        panel = GameObject.Find("Canvas/Panel");

       Tweener tweener =  panel.GetComponent<RectTransform>().DOLocalMoveX(-1, 3).From();

       //tweener.SetEase();设置曲线。
       //tweener.OnComplete();设置动画完成之后 调用方法
        // 加上From 从0的位置 移动到 当前的位置。From 带参数 true ，相对位置。 要加上当前位置。 如果位置在5，目标位置是-1 最后就是从 4 到 -1.


        //panel = GameObject.Find("Canvas/Panel");
        ////DOTween.To( () => myValue2, x => myValue2 = x, 10, 2);
        //Tweener tweener = panel.GetComponent<RectTransform>().DOLocalMove(new Vector3(0, 0, 0), 2, true);
        //tweener.SetAutoKill(false);
        //panel.GetComponent<RectTransform>().DOPause();


	}
	
	// Update is called once per frame
	void Update () {
        //rt.position = myValue;
        //rtf.localPosition = myValue;
	}

    public void OnClickButton()
    {
        //if (isShowed == false)
        //{
        //    panel.GetComponent<RectTransform>().DOPlayForward();
        //    isShowed = true;
        //}
        //else
        //{
        //    panel.GetComponent<RectTransform>().DOPlayBackwards();
        //    isShowed = false;
        //}
    
    }
}
