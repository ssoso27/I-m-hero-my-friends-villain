using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Text_PlayerLife : MonoBehaviour {
    public Text lifePrint;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        ShowLife();
	}

    void ShowLife()
    {
        int playerlife = GameObject.FindWithTag("Player").GetComponent<PlayerManager>().GetPlayerLife();
        lifePrint.text = "Life : " + playerlife;
    }
}
