using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoScroll : MonoBehaviour {
    public float speed = 1.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // 현재 프레임에서의 이동 거리를 구한다.
        float deltaX = Time.deltaTime* speed;

        Vector2 offset = GetComponent<MeshRenderer>().material.mainTextureOffset;
        offset.x += deltaX;
        GetComponent<MeshRenderer>().material.mainTextureOffset = offset;
		
	}
}
