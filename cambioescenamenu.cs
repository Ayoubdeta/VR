using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Método para cambiar de escena, se llama desde los botones
    public void ChangeScene(string Menu)
    {
        SceneManager.LoadScene(Menu);
    }

    // Método para salir del juego (para un botón de "Salir")
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("El juego se ha cerrado"); // Solo visible en el editor
    }
}
