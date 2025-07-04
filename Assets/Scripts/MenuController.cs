using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void OnPlayButtonPressed()
    {
        SceneManager.LoadScene("Game");
    }
}
