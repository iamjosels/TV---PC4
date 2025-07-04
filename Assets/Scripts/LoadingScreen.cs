using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{
    public class LoadingScreen : MonoBehaviour
    {
        [Header("Scene Transition")]
        [Tooltip("Nombre de la escena a cargar después del loading")]
        [SerializeField] private string sceneToLoad = "Menu";

        [Header("Tiempo de espera")]
        [Tooltip("Tiempo en segundos antes de cambiar de escena")]
        [SerializeField] private float waitTime = 5f;

        private void Start()
        {
            Invoke(nameof(LoadNextScene), waitTime);
        }

        private void LoadNextScene()
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
