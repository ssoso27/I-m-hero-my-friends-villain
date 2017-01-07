using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Player에 대한 스크립트
*/

public class PlayerManager : MonoBehaviour {

    /*
        public 전역변수는 간편한 테스트를 위함.
        후에 private로 바꾸는 것을 추천
    */
    
    public const float moveSpeedX = 5.0f; // 플레이어 x좌표 이동 속도
    public const float moveSpeedY = 3.0f; // 플레이어 y좌표 이동 속도
    public bool IsUpDown = false; // 상하이동 가능 여부

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        PlayerMove(); // 플레이어 이동
	}

    // 플레이어 이동
    void PlayerMove()
    {
        float distanceX; // x좌표 이동(할) 거리
        float distanceY; // y좌표 이동(할) 거리
        
        // 이동(할) 거리 지정
        distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeedX; // 좌우
        distanceY = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeedY; // 상하

        // 이동(할) 거리 만큼 이동
        if (IsUpDown)
        {
            // 상하운동 적용
            this.gameObject.transform.Translate(distanceX, distanceY, 0);
        }
        else
        {
            // 상하운동 미적용
            this.gameObject.transform.Translate(distanceX, 0, 0);
        }
    }
}
