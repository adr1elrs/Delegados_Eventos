using UnityEngine;

public class FootmanComportamiento : MonoBehaviour
{
    public Transform escudoTipo1;
    public Transform escudoTipo2;
    public float speed = 3.0f;
    private Transform objetivoActual;
    private Renderer rend;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rend = GetComponentInChildren<Renderer>();
    }

    void OnEnable() {
        NotificadorEventos.OnCuboChocaConLich += MoverAEscudo1;
        NotificadorEventos.OnCuboChocaConFootman += MoverAEscudo2;
    }

    void OnDisable() {
        NotificadorEventos.OnCuboChocaConLich -= MoverAEscudo1;
        NotificadorEventos.OnCuboChocaConFootman -= MoverAEscudo2;
    }

    private void MoverAEscudo1() {
        objetivoActual = escudoTipo1;
    }

    private void MoverAEscudo2() {
        objetivoActual = escudoTipo2;
    }

    private void Update() {
        if (objetivoActual != null) {
            Vector3 direccion = (objetivoActual.position - transform.position).normalized;
            transform.position = Vector3.MoveTowards(transform.position, objetivoActual.position, speed * Time.deltaTime);
            Vector3 mirar = new Vector3(objetivoActual.position.x, transform.position.y, objetivoActual.position.z);
            transform.LookAt(mirar);
        }
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name.Contains("Cube")) {
            Debug.Log("Choque con el cubo");
            NotificadorEventos.NotificarChoqueFootman();
        }

        if (collision.gameObject.CompareTag("Escudo_Tipo2")) {
            Debug.Log("¡Etiqueta Escudo_Tipo2 detectada!");
            if (rend != null) {
                Debug.Log("Cambiando color a amarillo...");
                rend.material.color = Color.yellow;
            } else {
                Debug.LogError("El componente 'rend' es NULL, no se encontró el Renderer.");
            }
        }
    }
}
 