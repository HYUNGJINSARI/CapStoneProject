using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;  // 플레이어의 위치를 가져오기 위한 변수
    public Vector3 offset;    // 카메라와 플레이어 사이의 거리

    void Start()
    {
        // 카메라와 플레이어 사이의 초기 거리 설정
        offset = transform.position - player.position;
    }

    void LateUpdate()
    {
        // 플레이어의 위치에 따라 카메라 위치를 업데이트
        transform.position = player.position + offset;
    }
}
