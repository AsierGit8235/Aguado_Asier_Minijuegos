using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicMaterialDetect : MonoBehaviour
{
    Rigidbody rb;
    float startingDrag;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startingDrag = rb.linearDamping;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (rb != null && collision.gameObject.GetComponent<Collider>().sharedMaterial != null)
        {
            //Obtenemos la fricci�n en movimiento de la superficie que tocamos
            float dynamicFrition = collision.gameObject.GetComponent<Collider>().sharedMaterial.dynamicFriction;
            //Cambiamos nuestra resistencia al airen funci�n de la fricci�n
            rb.linearDamping = startingDrag + dynamicFrition;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (rb != null && collision.gameObject.GetComponent<Collider>().sharedMaterial != null)
        {
            //Cambiamos nuestra resistencia al airen funci�n de la fricci�n
            rb.linearDamping = startingDrag;
        }
    }


}
