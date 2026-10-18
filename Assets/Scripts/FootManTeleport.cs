using UnityEngine;

public class FootManTeleport : MonoBehaviour
{
    public Transform escudoObjetivo;
    
    private void OnEnable() {
        ReferenciaNotificador.OnCuboAproximado += RealizarTeletransporte;
    }

    private void OnDisable() {
        ReferenciaNotificador.OnCuboAproximado -= RealizarTeletransporte;
    }

    private void RealizarTeletransporte() {
        transform.position = escudoObjetivo.position;
    }
}
