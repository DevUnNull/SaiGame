using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If : MonoBehaviour
{
    void Start()
    {
        int playerLocation = 20; // vị trí nhân vật 
        int spawnLocation = 20; // sửa lỗi chính tả

        if (playerLocation == spawnLocation) // nếu nhân vật đến vị trí nhất định quái sẽ xuất hiện
        {
            Spawn();
        }
        else
        {
            NotSpawn();
        }
    }

    void Spawn()
    {
        Debug.Log("Quái vật đã được sinh ra!");
        // Thêm logic sinh quái vật ở đây
    }

    void NotSpawn()
    {
        Debug.Log("Không sinh quái vật.");
        // Thêm logic không sinh quái vật ở đây
    }
}
