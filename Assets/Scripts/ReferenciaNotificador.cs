using UnityEngine;

public class ReferenciaNotificador : MonoBehaviour
{
    public delegate void AccionProximidad();
    public static event AccionProximidad OnCuboAproximado;
    private bool yaNotificado = false;
    private void OnTriggerEnter(Collider other) {
        if (!yaNotificado && other.name.Contains("Cube")) {
            yaNotificado = true;
            if (OnCuboAproximado != null) {
                OnCuboAproximado();
            }
        }
    }
}
