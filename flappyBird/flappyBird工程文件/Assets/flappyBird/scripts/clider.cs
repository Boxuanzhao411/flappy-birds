using UnityEngine;
using System.Collections;

public class clider : MonoBehaviour {
	public score s;//分数控制
	public int clideNum;
	public string tag;//判断碰撞的标签
	public bool isSuccess = false, isFail = false;
	void Start () {
		tag = "";
		isSuccess = false;
		isFail = false;
	}
	void OnTriggerEnter2D(Collider2D other) {//碰撞检测

		if(other.gameObject.tag.Equals("success")) {//未碰撞到柱子逻辑
			if(!isSuccess) {
				print("===trigger enter==");
				isSuccess = true;
				s.success();
				print ("success");
			}
		} else if(!isFail) {//碰撞柱子或地面逻辑
			print("===trigger enter==");
			isFail = true;
			s.fail();
			print ("fail");
		}
	}
	void OnTriggerExit2D(Collider2D other) {
		print("===trigger exit==");
		isSuccess = false;
	}

	void OnCollisionEnter2D(Collision2D other) { 

		if(other.gameObject.tag.Equals("success"))
		{//未碰撞到柱子逻辑
			if (!isSuccess) {
				print("===collision enter==");
				isSuccess = true;
			
			}
		} else if(!isFail)
		{//碰撞柱子或地面逻辑
			print("===collision enter==");
			isFail = true;
			s.fail();
		}
	}
	void OnCollisionExit2D(Collision2D coll) {
		print("===collision exit==");
		isSuccess = false;
	}
	public void reset() {
		isSuccess = false;
		isFail = false;
	}
}
