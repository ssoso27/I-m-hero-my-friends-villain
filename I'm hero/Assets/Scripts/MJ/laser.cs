using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour {

    public float moveSpeed = 0.45f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float moveX = moveSpeed * Time.deltaTime;
        //이동할 거리 지정
        transform.Translate(moveX, 0, 0);
        //이동 반영

	}
}
