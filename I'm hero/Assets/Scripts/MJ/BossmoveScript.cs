using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossmoveScript : MonoBehaviour
{

    public const float moveSpeed = 0.3f; //이동속도
    public int patrolArea = 5; //시작과 종료 사이의 거리
    public Rigidbody2D rig2d; //리지드바디 접근
    float StartPos; //시작 위치
    float EndPos ; //마지막 위치

    bool moveUp = true; //위아래 이동 왔다갔다 구분값

    void Start()
    {
        rig2d = GetComponent<Rigidbody2D>(); //리지드바디2d 대입
        StartPos = transform.position.y; //스크립트를 입힌 객체의 y값 초기화
        EndPos = transform.position.y + patrolArea; //패트롤 위치는 시작 값에 5를 더함
    }

    void Update()
    {
        if (moveUp)
        {
            rig2d.MovePosition(transform.position + transform.up * Time.deltaTime * moveSpeed);
        }

        if (transform.position.y > EndPos)
        {
            moveUp = false;
        }

        if (moveUp)
        {
            rig2d.MovePosition(transform.position - transform.up * Time.deltaTime * moveSpeed);
        }

        if (transform.position.y < StartPos)
        {
            moveUp = true;
        }

    }
}
	
