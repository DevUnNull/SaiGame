using UnityEngine;

public class KeoTha : MonoBehaviour
{
    private Vector3 offset;       // Độ lệch giữa chuột và tâm của object khi bắt đầu kéo
    private bool isDragging;      // Cờ đánh dấu trạng thái đang kéo hay không

    // Khi nhấn chuột vào object
    private void OnMouseDown()
    {
        // Lấy vị trí chuột trong không gian thế giới
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Tính độ lệch giữa vị trí chuột và vị trí object
        offset = transform.position - mouseWorld;
        offset.z = 0; // Đảm bảo không thay đổi trục Z (quan trọng trong 2D)

        isDragging = true; // Bắt đầu quá trình kéo
    }

    // Khi giữ chuột và di chuyển
    private void OnMouseDrag()
    {
        if (!isDragging) return;

        // Lấy vị trí chuột mới trong không gian thế giới
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Cộng thêm offset để giữ đúng khoảng cách lúc bấm vào
        Vector3 newPosition = mouseWorld + offset;
        newPosition.z = 0; // Giữ object ở mặt phẳng Z = 0 (tránh biến mất khỏi camera)

        // Cập nhật vị trí object
        transform.position = newPosition;
    }

    // Khi thả chuột
    private void OnMouseUp()
    {
        isDragging = false; // Kết thúc quá trình kéo
    }
}