using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class TerrenoManager : MonoBehaviour
{
    SerializeField] float anguloMax = 15f;   // inclinación máxima en grados
    [SerializeField] float velocidad = 30f;   // grados por segundo

    MyInputActions inputActions;
    Rigidbody rb;
    Quaternion rotInicial;

    float entradaZ, entradaX;
    float anguloZ, anguloX;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
        rotInicial = transform.rotation;

        inputActions = new MyInputActions();

        inputActions.Player.MoveY.performed += ctx => entradaZ = ctx.ReadValue<float>();
        inputActions.Player.MoveY.canceled += _ => entradaZ = 0f;

        inputActions.Player.MoveX.performed += ctx => entradaX = ctx.ReadValue<float>();
        inputActions.Player.MoveX.canceled += _ => entradaX = 0f;
    }

    private void OnEnable() 
    { 
        inputActions.Enable(); 
    }
    private void OnDisable() 
    { 
        inputActions.Disable(); 
    }

    private void FixedUpdate()
    {
        float paso = velocidad * Time.fixedDeltaTime;

        // El terreno se inclina hacia el objetivo y vuelve a plano al soltar
        anguloZ = Mathf.MoveTowards(anguloZ, -entradaZ * anguloMax, paso);
        anguloX = Mathf.MoveTowards(anguloX, entradaX * anguloMax, paso);

        rb.MoveRotation(rotInicial * Quaternion.Euler(anguloX, 0f, anguloZ));
    }
}
