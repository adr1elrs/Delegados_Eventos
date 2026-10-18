using UnityEngine;

public class RecolectarEscudos : MonoBehaviour
{
    private int puntuacion = 0;
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Escudo_Tipo1")) {
            puntuacion += 5;
            Debug.Log($"La puntuación actual es de: {puntuacion}");
            Destroy(collision.gameObject);
        } else if (collision.gameObject.CompareTag("Escudo_Tipo2")) {
            puntuacion += 10;
            Debug.Log($"La puntuación actual es de: {puntuacion}");
            Destroy(collision.gameObject);
        }
    }
}
