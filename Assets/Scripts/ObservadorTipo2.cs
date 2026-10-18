using UnityEngine;

public class ObservadorTipo2 : MonoBehaviour
{
    public Transform objetivoCilindro;
    public float speed = 3.0f;
    private bool debeMoverse = false;

    private void OnEnable() {
        CilindroNotificador.OnCuboChoca += IrHaciaCilindro;
    }

    private void OnDisable() {
        CilindroNotificador.OnCuboChoca -= IrHaciaCilindro;
    }

    private void IrHaciaCilindro() {
        debeMoverse = true;
    }

    void Update() {
        if (debeMoverse && objetivoCilindro != null) {
            transform.position = Vector3.MoveTowards(transform.position, objetivoCilindro.position, speed * Time.deltaTime);
            Vector3 mirar = new Vector3(objetivoCilindro.position.x, transform.position.y, objetivoCilindro.position.z);
            transform.LookAt(mirar);
        }
    }
}
