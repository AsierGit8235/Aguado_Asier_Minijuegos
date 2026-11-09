using UnityEngine;
using TMPro;

public class Distancia : MonoBehaviour
{
    [SerializeField] Transform Player; // arrastra la bola
    [SerializeField] Transform Meta;    // arrastra el objeto de la meta

    TextMeshProUGUI DistanciaMJ01;

    private void Awake()
    {
        DistanciaMJ01 = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        float distancia = Vector3.Distance(Player.position, Meta.position);
        DistanciaMJ01.text = $"Distancia: {distancia:0.0} m";
    }
}
