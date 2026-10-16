using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    {
        public void abrirMinijuego1()
        {
            SceneManager.LoadScene("Minijuego_01");
        }

        public void abrirMinijuego2()
        {
            SceneManager.LoadScene("Minijuego_02");
        }

        public void abrirMinijuego3()
        {
            SceneManager.LoadScene("Minijuego_03");
        }

        public void salir()
        {
            Application.Quit();
        }
    }
}