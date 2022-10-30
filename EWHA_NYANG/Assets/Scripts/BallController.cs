using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float resetTime = 3.0f;

    Rigidbody rb;
    bool isReady = true;
    Vector2 startPos;

    // Start is called before the first frame update
    void Start()
    {
        //리지드 바디의 물리 능력을 비활성화 한다.
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        //사용자가 공을 발사해 날아가고 있는 도중에는 위치 이동 하면 안됨 
        if (!isReady)
        {
            return;
        }

        //공을 카메라 전방 하단에 배치시킨다
        SetBallPosition(Camera.main.transform);

        if(Input.touchCount > 0 && isReady)
        {
            Touch touch = Input.GetTouch(0);

            //만일 터치를 시작했다면 ...
            if (touch.phase == TouchPhase.Began)
            {
                //터치를 시작한 픽셀을 저장
                startPos = touch.position;
            }
            //터치가 끝나면 ...
            else if(touch.phase == TouchPhase.Ended)
            {
                //손가락이 드래그한 픽셀의 Y축 거리를 구한다
                float dragDistance = touch.position.y - startPos.y;

                //AR 카메라를 기준으로 던질 방(전방 45도 위쪽)을 설정한다
                Vector3 throwAngle = (Camera.main.transform.forward + Camera.main.transform.up).normalized;

                //물리 능력을 활성화하고 준비 상태를 false로 바꿈
                rb.isKinematic = false;
                isReady = false;

                //던질 방향 * 손가락 드래그 거리 만큼 공에 물리적 힘을 가함
                rb.AddForce(throwAngle * dragDistance * 0.005f, ForceMode.VelocityChange);
                //나중에 0.005픽셀 수정가능

                //3초 후에 공의 위치 및 속도를 초기화 한다
                Invoke("ResetBall", resetTime);
            }
        }
        
    }

    void SetBallPosition(Transform anchor)
    {
        ////카메라의 위치에서 일정 거리만큼 떨어진 특정 위치를 설정한다
        //Vector3 offset = anchor.forward * 0.5f + anchor.up * -0.2f;

        ////공의 위치를 카메라 위치에서 특정 위치만큼 이동된 거리로 정한다
        //transform.position = anchor.position + offset;

        Vector3 vector = new Vector3(0, -463, -359);
        Quaternion q = Quaternion.Euler(new Vector3(0, 0, 0));

        anchor.SetPositionAndRotation(vector, q);

    }

    private void ResetBall()
    {
        //물리 능력을 비활성화하고 속도도 초기화 한다
        rb.isKinematic = true;
        rb.velocity = Vector3.zero;

        //준비 상태로 변경
        isReady = true;
    }
}
