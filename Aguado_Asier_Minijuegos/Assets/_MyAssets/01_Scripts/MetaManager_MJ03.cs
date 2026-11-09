using UnityEngine;
using UnityEngine.SceneManagement;

public class MetaManager_MJ03 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
