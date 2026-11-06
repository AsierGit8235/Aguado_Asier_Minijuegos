using UnityEngine;
using UnityEngine.SceneManagement;

public class MetaManager_MJ02 : MonoBehaviour
{
    public float segundosEspera = 1f;
    private bool terminado = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !terminado)
        {
            terminado = true;
            Invoke(nameof(ReiniciarEscena), segundosEspera);
        }
    }

    private void ReiniciarEscena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
