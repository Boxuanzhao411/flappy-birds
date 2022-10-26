using UnityEngine;
using System.Collections;

public class roadGen : MonoBehaviour {
	public GameObject[] zhuzi;
	public float down=3.8f, upper = 6.0f;

	void Start () {
		//Random.seed = System.Environment.TickCount; 
	}

	public void gen() {
		zhuzi[0].SetActive(true);
		zhuzi[1].SetActive(true);
        zhuzi[2].SetActive(true);
		zhuzi[3].SetActive(true);
		Vector3 p = zhuzi[0].transform.localPosition;
		float vv = Random.value;
        p.y = Random.Range(1.5f, 5);
		zhuzi[0].transform.localPosition = p;

		p = zhuzi[1].transform.localPosition;
		 vv = Random.value;
         p.y = Random.Range(1.5f, 5);
		zhuzi[1].transform.localPosition = p;

        p = zhuzi[2].transform.localPosition;
        vv = Random.value;
        p.y = Random.Range(1.5f, 5);
        zhuzi[2].transform.localPosition = p;


        p = zhuzi[3].transform.localPosition;
        vv = Random.value;
        p.y = Random.Range(1.5f, 5);
        zhuzi[3].transform.localPosition = p;
	}

	public void hidden() {
		zhuzi[0].SetActive(false);
		zhuzi[1].SetActive(false);
        zhuzi[2].SetActive(false);
        zhuzi[3].SetActive(false);
	}
}
