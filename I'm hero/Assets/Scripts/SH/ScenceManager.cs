using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenceManager : MonoBehaviour {

    public static bool IsGameOver;

    void Awake()
    {
        IsGameOver = false;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (IsGameOver && Input.GetKeyDown(KeyCode.Y))
        {
            // 다시 시작
        }
	}
}
