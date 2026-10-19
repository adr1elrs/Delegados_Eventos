using UnityEngine;
using TMPro;

public class ControladorUIPuntuacion : MonoBehaviour
{
    public TextMeshProUGUI textoMarcador;
    public TextMeshProUGUI textoRecompensa;
    
    private void OnEnable() {
        RecolectarEscudos.OnPuntuacionCambio += ActualizarTexto;
        RecolectarEscudos.OnRecompensaObtenida += ActualizarTextoRecompensa;
    }

    private void OnDisable() {
        RecolectarEscudos.OnPuntuacionCambio -= ActualizarTexto;
        RecolectarEscudos.OnRecompensaObtenida -= ActualizarTextoRecompensa;
    }

    private void ActualizarTexto(int nuevaPuntuacion) {
        textoMarcador.text = $"Puntuación: {nuevaPuntuacion}";
    }

    private void ActualizarTextoRecompensa(int nuevaRecompensa) {
        textoRecompensa.text = $"Recompensas: {nuevaRecompensa}";
    }
}
