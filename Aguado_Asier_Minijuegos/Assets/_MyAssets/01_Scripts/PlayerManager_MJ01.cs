using UnityEngine;

public class PlayerManager_MJ01 : MonoBehaviour
{
    public bool alive = true;

    [SerializeField] float force = 15f;
    [SerializeField] float torque = 8f;
    [SerializeField] Transform camara; // opcional: si lo dejas vacío usa la cámara principal

    MyInputActions inputActions;
    Rigidbody rb;

    float moveX;
    float moveY;

    float moveSpeed;
    float desplSpeed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

        inputActions = new MyInputActions();

        inputActions.Player.MoveX.performed += ctx => moveX = ctx.ReadValue<float>();
        inputActions.Player.MoveX.canceled += _ => moveX = 0f;

        inputActions.Player.MoveY.performed += ctx => moveY = ctx.ReadValue<float>();
        inputActions.Player.MoveY.canceled += _ => moveY = 0f;

        moveSpeed = 10f;
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
        if (!alive) return;

        if (Mathf.Abs(moveX) < 0.15f) moveX = 0f;
        if (Mathf.Abs(moveY) < 0.15f) moveY = 0f;

        // Dirección relativa a la cámara (sin inclinación vertical)
        Vector3 adelante = camara.forward;
        adelante.y = 0f;
        adelante.Normalize();

        Vector3 derecha = camara.right;
        derecha.y = 0f;
        derecha.Normalize();

        Vector3 direccion = derecha * moveX + adelante * moveY;
        rb.AddForce(direccion * force);
        rb.AddTorque(direccion * torque);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (camara == null) camara = Camera.main.transform;

        desplSpeed = 15f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
