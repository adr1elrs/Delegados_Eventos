using UnityEngine;

public class NotificadorEventos : MonoBehaviour
{
    public delegate void MensajeAccion();
    public static MensajeAccion OnCuboChocaConLich;
    public static MensajeAccion OnCuboChocaConFootman;

    public static void NotificarChoqueLich() {
        if (OnCuboChocaConLich != null) {
            OnCuboChocaConLich();
        }
    }

    public static void NotificarChoqueFootman() {
        if (OnCuboChocaConFootman != null) {
            OnCuboChocaConFootman();
        }
    }
}
