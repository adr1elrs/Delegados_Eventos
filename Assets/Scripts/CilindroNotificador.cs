using UnityEngine;

public class CilindroNotificador : MonoBehaviour
{
    public delegate void NotificacionColision();
    public static event NotificacionColision OnCuboChoca;

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name.Contains("Cube")) {
            Debug.Log("Colisión detectada. El cilindro está notificando...");
        }

        if (OnCuboChoca != null) {
            OnCuboChoca();
        }
    }
}
