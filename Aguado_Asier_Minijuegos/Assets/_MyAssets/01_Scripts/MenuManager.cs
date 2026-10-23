using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void AbrirMinijuego1()
    {
        SceneManager.LoadScene("Minijuego_01");
    }

    public void AbrirMinijuego2()
    {
        SceneManager.LoadScene("Minijuego_02");
    }

    public void AbrirMinijuego3()
    {
        SceneManager.LoadScene("Minijuego_03");
    }

    public void VolverMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void SalirJuego()
    {
        Application.Quit();
    }
}