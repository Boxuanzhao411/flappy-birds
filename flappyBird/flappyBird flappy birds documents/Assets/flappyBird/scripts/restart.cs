using UnityEngine;
using System.Collections;

public class restart : MonoBehaviour {
	public Camera cam2d;
	public GameObject ready; //,score,road, bird, bird01;
	public void Resets()//重新开始游戏
    {
		gameObject.SetActive(false);//隐藏界面
		Time.timeScale = 1;
		score.instance.scores = 0f;//清空分数
		score.instance.scoreText.text = score.instance.scores.ToString();//清空分数
		ready.SetActive(true);
		GameObject[] resets = GameObject.FindGameObjectsWithTag("needReset");
		foreach (GameObject r in resets)
		{
			r.BroadcastMessage("reset");
		}
	}
	void stopped() {//暂停游戏
		Time.timeScale = 0;
	}
}
