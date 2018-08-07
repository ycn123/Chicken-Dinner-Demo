using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTreatment : MonoBehaviour {
    public int Hp;
	// Use this for initialization
	void Start () {
        if (Hp > 100) {
            Hp = 100; 
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
