using UnityEngine;
using UnityEngine.SceneManagement;

public class MetaAcierto : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Aciertos.total++;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
