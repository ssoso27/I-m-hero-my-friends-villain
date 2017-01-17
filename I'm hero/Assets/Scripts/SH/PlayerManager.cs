using System;
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
        ShootControl();
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

    /*
     * longpaso, boss 등에 쓰는 충돌
     * 관통 하지 않는 충돌
     */
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerCollisionLongpaso();
        // PlayerCollisionBoss();
    }

    private void PlayerCollisionLongpaso()
    {
        Debug.Log("플레이어 - 롱파소 충돌");
        player_life--;
        StartCoroutine(gm.OverpowerPlayer());
        Debug.Log("충돌 스크립트 끝");
    }

    /*
     * shortpaso, ssal 등에 쓰는 충돌
     * 관통 하는 충돌
     */
    private void OnTriggerEnter2D(Collider2D collision)
    {

    }


    public GameObject laserPrefab; //발사할 레이저 저장
    public bool canShoot = true; //레이저 쓸 수 있는 상태인지 검사
    const float shootDelay = 0.5f; //레이저 쏘는 주기
    float shootTimer = 0; //시간 재는 타이머 만듬


    void ShootControl() //발사관리함수
    {
        if (canShoot) //쏠 수 있는 상태인지 검사
        {
            if (shootTimer > shootDelay && Input.GetKey(KeyCode.Space)) //쿨타임이 지났는지와, 스페이스바 눌려있는지 검사
            {
                Instantiate(laserPrefab, transform.position, Quaternion.identity); //레이저 생성
                shootTimer = 0; //쿨타임을 다시 카운트
            }
            shootTimer += Time.deltaTime; //쿨타임 카운트
        }
    }
}
