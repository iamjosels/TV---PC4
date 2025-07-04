using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
