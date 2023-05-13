using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    Rigidbody rigid;

    void Start()
    {

        rigid = GetComponent<Rigidbody>();

    }


    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 25, ForceMode.Impulse);
        }

        Vector3 vec = new Vector3(
        Input.GetAxisRaw("Horizontal"),
        0, Input.GetAxisRaw("Vertical"));

        rigid.AddForce(vec, ForceMode.Impulse);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.name == "Cube")
        {
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
        }
    }




}