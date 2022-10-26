using UnityEngine;
using System.Collections;

public class isReady : MonoBehaviour {
	public GameObject road, bird;//鸟和路的物体
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")){//鼠标按下
			score.instance.isGO = true;//游戏开始计时
			gameObject.SetActive(false);//关闭游戏准备开始界面
			road.GetComponent<road>().isBegin = true;//路移动方法
			bird.GetComponent<Rigidbody2D>().isKinematic = false;
			bird.GetComponent<Animator>().enabled = false;
		}
	}
}
