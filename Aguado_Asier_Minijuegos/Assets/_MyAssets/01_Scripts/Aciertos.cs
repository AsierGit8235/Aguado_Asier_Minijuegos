using TMPro;
using UnityEngine;

using UnityEngine;
using TMPro;

public class Aciertos : MonoBehaviour
{
    public static int total = 0;

    TextMeshProUGUI Aciertos01;

    private void Awake()
    {
        Aciertos01 = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        Aciertos01.text = "Aciertos: " + total;
    }
}
