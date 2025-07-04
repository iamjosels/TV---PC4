using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyBarnacle;
    public GameObject enemyBee;
    public GameObject enemyBlock;
    public GameObject enemyWorn;

    public float spawnInterval = 10f;
    public float spawnY = 12f; // posición vertical desde donde caen

    private float minX, maxX;

    void Start()
    {
        // Calculamos el ancho de la pantalla en unidades del mundo
        Vector2 screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        minX = -screenBounds.x + 1f;
        maxX = screenBounds.x - 1f;

        InvokeRepeating(nameof(SpawnEnemies), 1f, spawnInterval);
    }

    void SpawnEnemies()
    {
        Spawn(enemyBarnacle, "Purple");
        Spawn(enemyBee, "Yellow");
        Spawn(enemyBlock, "Green");
        Spawn(enemyWorn, "Beige");
    }

    void Spawn(GameObject prefab, string color)
    {
        float randomX = Random.Range(minX, maxX);
        Vector3 spawnPos = new Vector3(randomX, spawnY, 0f);
        GameObject enemy = Instantiate(prefab, spawnPos, Quaternion.identity);
        enemy.GetComponent<Enemy>().enemyColor = color;
    }
}
