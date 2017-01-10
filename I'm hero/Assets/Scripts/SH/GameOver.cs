using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

    Animator animator;

    void Awake()
    {
        animator = GameObject.Find("GameoverCanvas").GetComponent<Animator>();

    }

	// Use this for initialization
	void Start () {
        animator.SetBool("IsGameOver", false);
    }
	
	// Update is called once per frame
	void Update () {
		if (ScenceManager.IsGameOver)
        {
            animator.SetBool("IsGameOver", true);
        }
	}
}
