using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    float playerPosX;
    List<GameObject> minions; //(1) Khai báo biến minions

    List<GameObject> minionPrefabs;
    public GameObject minionPrefab;// Prefab là thể hiện 1 cái gì đã có sẵn trong Unity

    protected float spawnTimer = 0f;
    protected float DelaySpawn = 1f;
    private void Start()
    {
        this.minions = new List<GameObject>(); //Khởi tạo danh sách minions
        this.minionPrefabs = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {

        this.spawnTimer += Time.deltaTime;
        if (this.spawnTimer < this.DelaySpawn) return;
        this.spawnTimer = 0f;

        playerPosX = transform.position.x;
        int spawnLocation = 7; // sửa lỗi chính tả

        if (playerPosX >= spawnLocation) // nếu nhân vật đến vị trí nhất định quái sẽ xuất hiện
        {
            Spawn();
        }
        else
        {
            NotSpawn();
        }

        checkMinionDie();
    }
    void Spawn()
    {

        Debug.Log("Quái vật đã được sinh ra!");
        if (this.minions.Count >= 7) {
            return;
        }

        int index = this.minions.Count + 1;

        GameObject minion = new GameObject("Minion " + index);//(2)
        this.minions.Add(minion); // nó sẽ add các minion được sinh ra từ hàm (2) rồi add vào minions được tạo ở (1)
        // Thêm logic sinh quái vật ở đây
        minion.AddComponent<addComponet>(); // thêm scrip cho object khi mới được tạo ra 




        //Tạo GameObject từ Prefab Bai5
        if (this.minionPrefabs.Count >= 7)
        {
            return;
        }
        int indexPrefab = this.minionPrefabs.Count + 1;

        GameObject minionPrefabb = Instantiate(this.minionPrefab);
        minionPrefabb.gameObject.SetActive(true);
        minionPrefabb.name = "MinionPrefab #" + index;
        this.minionPrefabs.Add(minionPrefabb);
        minionPrefabb.transform.position = transform.position;
    }

    void checkMinionDie()
    {
        GameObject minion;
        for(int i = 0; i < this.minions.Count; i++) 
        {
                minion = this.minions[i];
            if (minion == null) 
            {
                this.minions.RemoveAt(i);
            }
        }
    }

    void NotSpawn()
    {
        Debug.Log("Không sinh quái vật.");

        // Thêm logic không sinh quái vật ở đây
    }
}
