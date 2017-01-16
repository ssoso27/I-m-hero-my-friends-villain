using UnityEngine;
using System.Collections;

public class MapMaker : MonoBehaviour
{

    const float MAP_WIDTH = 46; // 맵 너비
    const int MAP_TYPE_NUM = 10; // 맵 종류의 개수
    int PlayerMap; // Player 현재 위치 맵
    
    ArrayList Maps = new ArrayList(); // 맵 동적배열
    
    // 메소드

    public void InputPrefab(int i) // Maps[i]에 Map Prefab을 입력
    {
        GameObject inputMap = new GameObject();
        int randomType;

        randomType = Random.Range(0, MAP_TYPE_NUM);
                
        switch (randomType)
        {
            case 0: // Arch
                inputMap = Resources.Load("Map/Whole/Arch") as GameObject; // Arch 로드
                break;

            case 1: // Arch_upsidedown
                inputMap = Resources.Load("Map/Whole/Arch_upsidedown") as GameObject; // Arch_upsidedown 로드
                break;

            case 2: // dog
                inputMap = Resources.Load("Map/Whole/dog") as GameObject; // dog 로드
                break;

            case 3: // dog_upsidedown
                inputMap = Resources.Load("Map/Whole/dog_upsidedown") as GameObject; // dog_upsidedown 로드
                break;

            case 4: // fox
                inputMap = Resources.Load("Map/Whole/fox") as GameObject; // fox 로드
                break;

            case 5: // fox_upsidedown
                inputMap = Resources.Load("Map/Whole/fox_upsidedown") as GameObject; // fox_upsidedown 로드
                break;

            case 6: // hiking
                inputMap = Resources.Load("Map/Whole/hiking") as GameObject; // hiking 로드
                break;

            case 7: // hiking_upsidedown
                inputMap = Resources.Load("Map/Whole/hiking_upsidedown") as GameObject; // hiking_upsidedown 로드
                break;

            case 8: // hopper
                inputMap = Resources.Load("Map/Whole/hopper") as GameObject; // hopper 로드
                break;

            case 9: // wholeflat
                inputMap = Resources.Load("Map/Whole/wholeflat") as GameObject; // wholeflat 로드
                break;

            default:
                break;

        }
        Maps.Add(inputMap);
    }

    public void FirstCreateMap() // 최초 실행 맵생성
    {
        InputPrefab(0);
        InputPrefab(1);

        for (int i = 0; i < 2; i++)
        {
            Maps[i] = (GameObject)Instantiate((GameObject)Maps[i], new Vector3(50 * i, -3f, 0), Quaternion.identity); // Map을 position위치에 identity만큼(안 돌림) 돌려서 생성 (이름, 위치, 회전률)
        }
    }

    public void CreateMap() // 지속적인 맵 생성
    {
        PlayerMap = (int)(GameObject.FindWithTag("Player").transform.position.x / 50); // Player 현재 위치 맵 찾음

        if (Maps[PlayerMap + 1] == null) // 다음 맵이 null이면
        {
            InputPrefab(PlayerMap + 1);

            Maps[PlayerMap + 1] = (GameObject)Instantiate((GameObject)Maps[PlayerMap + 1], new Vector3(50 * (PlayerMap + 1), -3f, 0), Quaternion.identity); // Map을 position위치에 identity만큼(안 돌림) 돌려서 생성 (이름, 위치, 회전률)
        }
    }

    public void DeleteMap() // 지난 맵 삭제
    {
        PlayerMap = (int)(GameObject.FindWithTag("Player").transform.position.x / 50); // Player 현재 위치 맵 찾음

        if (PlayerMap > 1)
        {
            if (Maps[PlayerMap - 2] != null) // 전전 맵이 null이 아니면
            {
                DestroyImmediate((GameObject)Maps[PlayerMap - 2], true);
            }
        }
    }
}