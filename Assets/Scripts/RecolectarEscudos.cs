using UnityEngine;

public class RecolectarEscudos : MonoBehaviour
{
    public delegate void AccionCambioPuntuacion(int puntuacionActual);
    public static event AccionCambioPuntuacion OnPuntuacionCambio;

    public delegate void AccionRecompensa(int numeroRecompensa);
    public static event AccionRecompensa OnRecompensaObtenida;

    private int recompensas = 0;
    private int umbralRecompensa = 100;
    private int puntuacion = 0;

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Escudo_Tipo1")) {
            SumarPuntos(5);
            Destroy(collision.gameObject);
        } else if (collision.gameObject.CompareTag("Escudo_Tipo2")) {
            SumarPuntos(100);
            Destroy(collision.gameObject);
        }
    }


    private void SumarPuntos(int puntos) {
        puntuacion += puntos;
        Debug.Log($"La puntuación actual es de: {puntuacion}");
        NotificarPuntuacion();
        while (puntuacion >= umbralRecompensa) {
            umbralRecompensa += 100;
            if (OnRecompensaObtenida != null) {
                OnRecompensaObtenida(++recompensas);
            }
        }
    }

    private void NotificarPuntuacion() {
        if (OnPuntuacionCambio != null) {
            OnPuntuacionCambio(puntuacion);
        }
    }
}
