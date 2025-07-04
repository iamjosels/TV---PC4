using UnityEngine;

public class DestroyOffScreen : MonoBehaviour
{
    private float minY;

    void Start()
    {
        minY = Camera.main.ScreenToWorldPoint(Vector3.zero).y - 1f;
    }

    void Update()
    {
        if (transform.position.y < minY)
        {
            Destroy(gameObject);
        }
    }
}
