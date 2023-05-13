using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3(8 , 1.5f, 0);

    void Start()
    {
        
    }

    void Update()
    {
        // 1. MoveTowards (현재 위치, 목표 위치, 속도) 마지막 매개변수와 비례하여 속도 증가
        /*
        transform.position =
            Vector3.MoveTowards(transform.position, target, 0.3f);
        
        // 2. SmoothDamp (현재 위치, 목표 위치, 참조 속도, 속도) 마지막 매개변수와 반비례하여 속도 증가
        Vector3 velo = Vector3.zero;

        transform.position = 
            Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);
       

        // 3. Lerp 선형보간, SmoothDamp보다 감속 시간이 김
        transform.position = 
            Vector3.Lerp(transform.position, target, 0.02f);
        */

        // 4. Slerp 구면 선형 보간, 호를 그리면서 이동
        transform.position =
            Vector3.Slerp(transform.position, target, 1.2f*Time.deltaTime); 
    }
}
