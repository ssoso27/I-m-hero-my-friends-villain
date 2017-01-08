using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    게임을 총괄하는 스크립트
*/

public partial class GameManager : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        CheckPlayerLR(); // Player의 좌우이동 가능 여부 체크
    }
}

public partial class GameManager {
    PlayerManager pm = GameObject.Find("Player").GetComponent<PlayerManager> ();

    // GameOver 체크
    void CheckGameOver()
    {
        int player_life = pm.GetPlayerLife();

        if (player_life <= 0) // 라이프가 0이하면
        {
            GameOver();
        }
    }

    // GameOver
    void GameOver()
    {

    }

    // Player의 좌우이동 가능 여부 체크
    void CheckPlayerLR()
    {
        /*
            상하이동 가능 조건 체크하기
            ex : 보스전에 진입했는가?
            ex : 일반전에 진입했는가?
        */

        /* 
            PlayerManager 클래스의 bool IsUpDown 변수 조작
        */
    }
}
