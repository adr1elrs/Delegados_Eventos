using UnityEngine;

public class ImpulsarCubo : MonoBehaviour
{
    private Rigidbody rb;
    private float force = 10f;
    private bool yaDisparado = false;
    public Transform cilindro;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && !yaDisparado) {
            DispararHaciaCilindro();
        }
    }

    void DispararHaciaCilindro() {
        if (cilindro != null) {
            Vector3 direccion = (cilindro.position - transform.position).normalized;
            rb.AddForce(direccion * force, ForceMode.Impulse);
            yaDisparado = true;
        }
    }
}
