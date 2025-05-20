using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alive : MonoBehaviour
{
    public float TimeLive = 4;

    // Update is called once per frame
    void Update()
    {
        Invoke(nameof(deleteEnemy), TimeLive);
    }
    public void deleteEnemy() 
    {
        Destroy(gameObject);
    }
}
