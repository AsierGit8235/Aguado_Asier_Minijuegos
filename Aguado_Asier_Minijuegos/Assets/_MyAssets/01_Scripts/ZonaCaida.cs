using UnityEngine;
using UnityEngine.SceneManagement;

public class ZonaCaida : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Toca la zona: " + other.name + " | Tag: " + other.tag);

        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
