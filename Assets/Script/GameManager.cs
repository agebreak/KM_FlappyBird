using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public GameObject cactus; // 생성할 선인장 프리팹
    public float spawnTime = 1.0f;

	// Use this for initialization
	void Start () {
        // 선인장을 프래팹에서 정해진 시간마다 생성한다. 
        InvokeRepeating("MakeCactus", 0.0f, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {

    }

    // 선인장을 프래팹에서 정해진 시간마다 생성한다. 
    void MakeCactus()
    {
        Instantiate(cactus);
    }
}
