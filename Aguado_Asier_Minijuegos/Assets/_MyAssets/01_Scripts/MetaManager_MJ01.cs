using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MetaManager_MJ01 : MonoBehaviour
{
    public GameObject TextoVictoria;      // arrastra aquí tu texto
    public string escenaMenu = "MenuPrincipal"; // nombre exacto de tu escena de menú
    public float segundosEspera = 3f;

    private bool terminado = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !terminado)
        {
            terminado = true;
            TextoVictoria.SetActive(true);
            StartCoroutine(VolverAlMenu());
        }
    }

    IEnumerator VolverAlMenu()
    {
        yield return new WaitForSeconds(segundosEspera);
        SceneManager.LoadScene(escenaMenu);
    }
}
