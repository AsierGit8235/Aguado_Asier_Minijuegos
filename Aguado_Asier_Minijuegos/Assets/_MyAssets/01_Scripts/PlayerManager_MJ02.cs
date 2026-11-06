using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerManager_MJ02 : MonoBehaviour
{
    [SerializeField] float velocidad = 60f;   // grados por segundo
    [SerializeField] float anguloMax = 35f;   // inclinación máxima a cada lado
    [SerializeField] bool invertir = false;   // marca esto para que se incline al revés

    MyInputActions inputActions;
    Rigidbody rb;
    Quaternion rotInicial;
    float entrada;
    float angulo;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
        rotInicial = transform.rotation;

        inputActions = new MyInputActions();
        inputActions.Player.MoveX.performed += ctx => entrada = ctx.ReadValue<float>();
        inputActions.Player.MoveX.canceled += _ => entrada = 0f;
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
        float direccion = invertir ? -entrada : entrada;
        angulo += direccion * velocidad * Time.fixedDeltaTime;
        angulo = Mathf.Clamp(angulo, -anguloMax, anguloMax);

        rb.MoveRotation(rotInicial * Quaternion.Euler(0f, 0f, angulo));
    }
}
