using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed = 5f;

    [Header("Sprites por color")]
    public Sprite spriteBeige;
    public Sprite spriteGreen;
    public Sprite spriteYellow;
    public Sprite spritePurple;

    private SpriteRenderer spriteRenderer;
    private enum ColorType { Beige, Green, Yellow, Purple }
    private ColorType currentColor = ColorType.Yellow;

    private Transform spriteTransform;

    void Start()
    {
        spriteTransform = transform.Find("SpriteRenderer");
        spriteRenderer = spriteTransform.GetComponent<SpriteRenderer>();
        SetColor(currentColor);
    }

    void Update()
    {
        Move();
        HandleColorInput();
    }

    private void Move()
    {
        // Movimiento con teclado
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontal * moveSpeed * Time.deltaTime);

        // Movimiento con mouse (estilo Hungry Hero)
        if (Input.GetMouseButton(0))
        {
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 targetPos = new Vector3(mouseWorldPos.x, transform.position.y, transform.position.z);

            // Movimiento suave hacia el mouse (sin teletransportarse)
            transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime * moveSpeed);
        }
    }


    private void HandleColorInput()
    {
        if (Input.GetKeyDown(KeyCode.X)) { currentColor = ColorType.Beige; SetColor(currentColor); }
        else if (Input.GetKeyDown(KeyCode.C)) { currentColor = ColorType.Green; SetColor(currentColor); }
        else if (Input.GetKeyDown(KeyCode.V)) { currentColor = ColorType.Yellow; SetColor(currentColor); }
        else if (Input.GetKeyDown(KeyCode.B)) { currentColor = ColorType.Purple; SetColor(currentColor); }
    }

    private void SetColor(ColorType color)
    {
        switch (color)
        {
            case ColorType.Beige: spriteRenderer.sprite = spriteBeige; break;
            case ColorType.Green: spriteRenderer.sprite = spriteGreen; break;
            case ColorType.Yellow: spriteRenderer.sprite = spriteYellow; break;
            case ColorType.Purple: spriteRenderer.sprite = spritePurple; break;
        }
    }

    public string GetCurrentColor()
    {
        return currentColor.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Enemy enemy = collision.GetComponent<Enemy>();
            if (enemy != null)
            {
                string playerColor = GetCurrentColor();
                string enemyColor = enemy.enemyColor;

                if (playerColor == enemyColor)
                {
                    GameManager.Instance.AddScore(10);
                }
                else
                {
                    GameManager.Instance.AddScore(-20);
                }

                Destroy(collision.gameObject);
            }
        }
    }

}
