using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy2 : MonoBehaviour
{
    protected float spawnTimer = 0f;
    protected float DelaySpawn = 1f;

    float playerPosX;
    List<GameObject> minions; //(1) Khai báo biến minions

    List<GameObject> minionPrefabs;
    public GameObject minionPrefab;// Prefab là thể hiện 1 cái gì đã có sẵn trong Unity

    // Start is called before the first frame update
    void Start()
    {
        this.minions = new List<GameObject>(); //Khởi tạo danh sách minions
        this.minionPrefabs = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        this.spawnTimer += Time.deltaTime;
        if (this.spawnTimer < this.DelaySpawn) return;
        SpawnEnemy();
        this.spawnTimer = 0f;

        
    }
    public void SpawnEnemy() 
    {
       GameObject EnemyTransform =  Instantiate(minionPrefab);
       EnemyTransform.transform.position = gameObject.transform.position;
    }
}
