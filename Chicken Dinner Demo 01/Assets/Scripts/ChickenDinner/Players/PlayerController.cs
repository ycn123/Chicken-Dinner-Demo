using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    Animator animator;
    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        Move();
    }
    void Move()
    {
        var h = Input.GetAxis("Horizontal");
        //Debug.Log(h);
        var v = Input.GetAxis("Vertical");
        animator.SetFloat("speedX", h*1.76f);
        animator.SetFloat("speedZ", v*2.71f);
    }
}
