using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For : MonoBehaviour
{
    void Start()
    {
        int maxMinion = 7;
        for (int i = 0; i <= maxMinion; i++)
        {
            Spawn(i);
        }
    }

    void Spawn(int i)
    {
        Debug.Log("Minion " + i);
        // ở đây thực hiện logic Sqwan quái
    }
}
