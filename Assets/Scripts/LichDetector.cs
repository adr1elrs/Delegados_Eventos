using UnityEngine;

public class LichDetector : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name.Contains("Cube")) {
            NotificadorEventos.NotificarChoqueLich();
        }
    }
}
