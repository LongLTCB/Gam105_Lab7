using UnityEngine;

public class Crosshair : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // Mũi tên trái/phải hoặc A/D
        float vertical = Input.GetAxis("Vertical");     // Mũi tên lên/xuống hoặc W/S

        Vector3 move = new Vector3(horizontal, vertical, 0f);
        transform.position += move * moveSpeed * Time.deltaTime;
    }
}
