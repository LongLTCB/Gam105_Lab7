using UnityEngine;

public class Bubble : MonoBehaviour
{
    public Sprite[] sprites;

    void Start()
    {
        // Chọn sprite ngẫu nhiên
        int index = Random.Range(0, sprites.Length);
        GetComponent<SpriteRenderer>().sprite = sprites[index];
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Crosshair"))
        {
            Debug.Log("Crosshair hit the bubble!");
            Destroy(gameObject); // xoá quả cầu khi va chạm
            GameManager.instance.AddScore(1);
        }
    }
}
