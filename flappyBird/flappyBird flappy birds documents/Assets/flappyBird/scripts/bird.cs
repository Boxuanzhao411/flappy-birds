using UnityEngine;
using System.Collections;

public class bird : MonoBehaviour {
	public Vector2 force = new Vector2(0, 50);//向上的力度
	public Transform trans;//鸟的transform
	public Vector3 initPos;//初始位置
	Rigidbody2D body;//鸟的刚体

	// Use this for initialization
	void Start () {
		body = gameObject.GetComponent<Rigidbody2D>();
		initPos = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")){//鼠标按下左键施加向上的力
			body.AddForce(force);
		}
	}

	public void reset() {//重置游戏
		body.isKinematic = true;
		gameObject.transform.position = initPos;//重置鸟位置和方向
		gameObject.transform.eulerAngles = Vector3.zero;
		GetComponent<Animator>().enabled = true;
	}
}
