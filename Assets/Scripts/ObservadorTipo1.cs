using UnityEngine;

public class ObservadorTipo1 : MonoBehaviour
{
    
    public Transform objetivoEsferaTipo2;
    public float speed = 3.0f;

    private bool debeMoverse = false;

    private void OnEnable() {
        CilindroNotificador.OnCuboChoca += IniciarMovimiento;
    }

    private void OnDisable() {
        CilindroNotificador.OnCuboChoca -= IniciarMovimiento;
    }

    private void IniciarMovimiento() {
        debeMoverse = true;
    }

    private void Update() {
        if (debeMoverse && objetivoEsferaTipo2 != null) {
            transform.position = Vector3.MoveTowards(transform.position, objetivoEsferaTipo2.position, speed * Time.deltaTime);
            Vector3 mirar = new Vector3(objetivoEsferaTipo2.position.x, transform.position.y, objetivoEsferaTipo2.position.z);
            transform.LookAt(mirar);
        }
    }
}
