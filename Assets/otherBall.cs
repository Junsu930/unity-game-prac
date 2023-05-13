using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class otherBall : MonoBehaviour
{

    MeshRenderer mesh;
    Material mat;
   
  
   
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
        
        
    }


    private void OnCollisionEnter(Collision collision)
    {                           // 충돌 정보 클래스
        // 충격을 했을 경우
        if (collision.gameObject.name == "Main Ball")
        {
            mat.color = new Color(0, 0, 0); 

        }

        
    }

    private void OnCollisionStay(Collision collision)
    {
        // 충돌 중의 경우
    }

    private void OnCollisionExit(Collision collision)
    {
        mat.color = new Color(1, 1, 1);
    }

    
}
