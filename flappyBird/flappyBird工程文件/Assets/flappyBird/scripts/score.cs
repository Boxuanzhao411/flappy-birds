using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class score : MonoBehaviour {
	public GameObject gameOver;//游戏结束界面
	public Text scoreText;//分数text
	public Text GameOverScoreText;//游戏结束分数text
	public float scores;//分数
	public bool isGO;//是否开始游戏
	public static score instance;//单例
	// Use this for initialization
	void Awake () {
		instance = this;//单例赋值
	}
    private void Update()
    {
		if(isGO)//开始游戏后计时
        {
			scores += Time.deltaTime;
			scoreText.text = scores.ToString();
		}
			
		

    }
    public void success() {
		
	}

	public void reset() {
		
	}

	public void fail() {//游戏失败
		gameOver.SetActive(true);//显示游戏失败界面
		isGO = false;
		GameOverScoreText.text = scores.ToString();//记录最终分数
		Time.timeScale = 0f;
	}
}
