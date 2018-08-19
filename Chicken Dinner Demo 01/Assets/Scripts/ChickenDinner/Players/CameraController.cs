using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public Transform Neck;
    public Transform Role;
    public float XSensitivity = 180;
    public float YSensitivity = 180;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");

        Debug.Log(x + "|" + y);
        transform.RotateAround(Neck.position, Role.right,-y*Time.deltaTime* YSensitivity);
        Role.Rotate(0, x * Time.deltaTime * XSensitivity, 0);

    }
}


