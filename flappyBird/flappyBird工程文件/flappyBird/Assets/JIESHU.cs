using UnityEngine;
using System.Collections;

public class JIESHU : MonoBehaviour {

    


	// Use this for initialization
    void Start()
    {


    }



	
	// Update is called once per frame
	void Update () {
	     Vector3  vex= transform.position;
        vex.x-=Time.deltaTime*0.5f;
        transform.position =vex;
    }
   
}
