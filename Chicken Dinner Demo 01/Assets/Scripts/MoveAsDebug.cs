using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Amanda");
        Debug.Log(2 * 10);
        float a = (float)3.14 + 10;
        float b = 10;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    float GetMoney(float value) {
        return value * 2;
    }
    void BorrowMoney() {

    }
}
