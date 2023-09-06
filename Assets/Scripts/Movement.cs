using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Animator anim;
    public float speed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("isWalkingForward", false);
        anim.SetBool("isWalkingBackward", false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("isWalkingForward", true);
            anim.SetBool("isWalkingBackward", false);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("isWalkingForward", false);
            anim.SetBool("isWalkingBackward", true);
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        else
        {
            anim.SetBool("isWalkingForward", false);
            anim.SetBool("isWalkingBackward", false);
        }
    }
}
