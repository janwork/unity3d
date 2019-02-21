using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class MyText : MonoBehaviour {

    private Text text;

	// Use this for initialization
	void Start () {
        text = this.GetComponent<Text>();
        Tweener t = text.DOText("吴忠薪是个大傻逼，接下来我们进入第二卷吴忠薪是个大傻逼，接下来我们进入第二卷吴忠薪是个大傻逼，接下来我们进入第二卷吴忠薪是个大傻逼，接下来我们进入第二卷", 2);
        t.Play();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
