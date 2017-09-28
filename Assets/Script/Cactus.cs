using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cactus : MonoBehaviour
{
    public Vector3 speed;
    public float randMin;
    public float randMax;

    // Use this for initialization
    void Start()
    {
        // 생성될때 Y값을 랜덤한값(최소, 최대)으로 설정한다. 
        //Vector3 pos = transform.position;
        //pos.y = Random.Range(randMin, randMax);
        //transform.position = pos;

        float y = Random.Range(randMin, randMax);
        transform.Translate(new Vector3(0, y, 0));
    }

    // Update is called once per frame
    void Update()
    { 
        transform.position += speed * Time.deltaTime;
    }

    // 화면에서 사라지면 삭제된다. 
    public void OnBecameInvisible()
    {
        // 내가 붙어있는 오브젝트를 파괴한다.
        Destroy(gameObject);
    }

    

}
