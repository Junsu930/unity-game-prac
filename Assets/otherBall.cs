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
    {                           // �浹 ���� Ŭ����
        // ����� ���� ���
        if (collision.gameObject.name == "Main Ball")
        {
            mat.color = new Color(0, 0, 0); 

        }

        
    }

    private void OnCollisionStay(Collision collision)
    {
        // �浹 ���� ���
    }

    private void OnCollisionExit(Collision collision)
    {
        mat.color = new Color(1, 1, 1);
    }

    
}
