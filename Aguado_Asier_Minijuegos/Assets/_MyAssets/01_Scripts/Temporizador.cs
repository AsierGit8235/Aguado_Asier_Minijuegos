using UnityEngine;
using TMPro;

public class Temporizador : MonoBehaviour
{
    TextMeshProUGUI Temporizador01;
    float tiempo;

    private void Awake()
    {
        Temporizador01 = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        tiempo += Time.deltaTime;
        int minutos = (int)(tiempo / 60f);
        int segundos = (int)(tiempo % 60f);
        Temporizador01.text = $"{minutos:00}:{segundos:00}";
    }
}
