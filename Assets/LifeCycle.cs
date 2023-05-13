using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{

        void Start(){

        }
        
        // 1초에 60회씩 동작
        void Update(){
            Vector3 vec = new Vector3(
                Input.GetAxis("Horizontal") * Time.deltaTime,Input.GetAxis("Vertical")*Time.deltaTime,0);
            transform.Translate(vec);

            /*
            // 마우스, 키보드 등 아무 키
            if(Input.anyKeyDown){
                Debug.Log("플레이어가 키를 눌렀습니다");
            }

            if(Input.GetButton("Horizontal")){
                Debug.Log("횡 이동 중" 
                + Input.GetAxisRaw("Horizontal") );
               // Input.GetAxis => 가중치 포함 축 값
               // Input.GetAxisRaw => 가중치 없이 축 값

               
            }

            if(Input.GetButton("Vertical")){
                Debug.Log("종 이동 중" + Input.GetAxisRaw("Vertical"));
            }

            // 기본적으로 Unity에 space bar가 Jump로 등록되어있다. 
            
            if(Input.GetButton("Jump"))
                Debug.Log("점프 모으는 중");

            if(Input.GetButtonUp("Jump"))
                Debug.Log("슈퍼 점프!");
            
            
            // 키보드
            if(Input.GetKeyDown(KeyCode.Return)){
                Debug.Log("아이템을 구매하였습니다.");
            }
            
            if(Input.GetKey(KeyCode.LeftArrow)){
                Debug.Log("왼쪽으로 이동 중");
            }

            if(Input.GetKeyUp(KeyCode.RightArrow)){
                Debug.Log("오른쪽 이동을 멈추었습니다.");
            }
            
            // 마우스
            if(Input.GetMouseButtonDown(1)){
                Debug.Log("슈퍼미사일 발사");
            }

            if(Input.GetMouseButton(0)){
                Debug.Log("미사일 충전중");
            }

            if(Input.GetMouseButtonUp(0)){
                Debug.Log("미사일 발사!");
            }
            */

        }
        
}
