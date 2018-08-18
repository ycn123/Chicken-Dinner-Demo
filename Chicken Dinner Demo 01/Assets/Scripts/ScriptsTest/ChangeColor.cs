using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {
    Color OldColor;
    MeshRenderer _renderer;
	void Start () {
        _renderer = GetComponent<MeshRenderer>();
        OldColor = _renderer.material.color;
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseEnter()
    {
        _renderer.material.color = Color.yellow;
    }
    private void OnMouseExit()
    {
        _renderer.material.color = OldColor;
    }
}
