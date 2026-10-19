using UnityEngine;

public class ControlarCubo : MonoBehaviour
{
    public float speed = 6.0f;
    private Rigidbody rb;
    private Vector3 direccionInput;
    
    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        direccionInput = new Vector3(horizontal, 0, vertical).normalized;
    }

    void FixedUpdate() {
        if (direccionInput != Vector3.zero) {
            Vector3 nuevaPosicion = rb.position + direccionInput * speed * Time.fixedDeltaTime;
            rb.MovePosition(nuevaPosicion);
        }
    }
}
