using UnityEngine;
using System.Collections;

public class manager : MonoBehaviour {
    public GameObject gongzhu;
    public float timer;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            gongzhu.SetActive(true);
        }
	}
}
