using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Player에 대한 스크립트
*/

public partial class PlayerManager : MonoBehaviour {

    GameManager gm;

    // Use this for initialization
    void Start() {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>(); 
    }

    // Update is called once per frame
    void Update() {
        PlayerMove(); // 플레이어 이동
    }
}

public partial class PlayerManager
{
    // Getter, Setter 함수

    public int GetPlayerLife() { return player_life; }
}


public partial class PlayerManager {

    /*
    public 전역변수는 간편한 테스트를 위함.
    후에 private로 바꾸는 것을 추천
    */

    public const float moveSpeedX = 5.0f; // 플레이어 x좌표 이동 속도
    public const float moveSpeedY = 3.0f; // 플레이어 y좌표 이동 속도
    public bool IsLeftRight = false; // 좌우이동 가능 여부
    public int player_life = 5;


    // 플레이어 이동
    void PlayerMove()
    {
        float distanceX; // x좌표 이동(할) 거리
        float distanceY; // y좌표 이동(할) 거리

        // 이동(할) 거리 지정
        if (IsLeftRight)
        {
            // 좌우이동 가능
            distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeedX; // 좌우
            distanceY = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeedY; // 상하
        }
        else
        {
            // 좌우이동 불가. 자동이동
            distanceX = Time.deltaTime * moveSpeedX; // 좌우
            distanceY = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeedY; // 상하
        }

        // 이동(할) 거리 만큼 이동
        this.gameObject.transform.Translate(distanceX, distanceY, 0);
    }

    // 충돌 처리
    void OnCollisionEnter(Collision col)
    {
        EnemyCollision(col); // 적과의 충돌
    }

    // 적과의 충돌
    void EnemyCollision(Collision col)
    {
        // 만약 충돌체의 Tag가 longpaso 또는 shortpaso면
        if (col.gameObject.tag == "longpaso" || col.gameObject.tag == "shortpaso")
        {
            // 라이프 감소
            player_life--;
            // 게임오버 체크 (by. GameManager.cs)
            // 뒤로 조금 밀려남 or 1초전 위치로 이동
            // 잠시 무적
            // 1초간 모든 오브젝트 일시정지
        }
    }
}
