using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FollowPlayer : MonoBehaviour
{
    public Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Follow();
    }

    void Follow()
    {
        // Tính khoảng cách từ vị trí hiện tại của đối tượng này đến vị trí của box
        Vector3 distance = Player.transform.position - transform.position;

        // Nếu khoảng cách lớn hơn hoặc bằng 3 đơn vị
        if (distance.magnitude >= 0)
        {
            // Tính điểm mục tiêu cách box 3 đơn vị theo hướng về phía transform
            Vector3 targetPoint = Player.transform.position - distance.normalized * 3;

            // Di chuyển vị trí gameObject hiện tại về targetPoint với tốc độ 15 đơn vị/giây
            gameObject.transform.position = Vector3.MoveTowards(
                gameObject.transform.position,  // vị trí hiện tại
                targetPoint,                    // điểm đến
                15 * Time.deltaTime             // tốc độ di chuyển (đơn vị trên giây)
            );
        }
    }

}
