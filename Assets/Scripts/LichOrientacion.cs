using UnityEngine;

public class LichOrientacion : MonoBehaviour
{
    public Transform objetoEncarar;
    
    private void OnEnable() {
        ReferenciaNotificador.OnCuboAproximado += EncararObjeto;
    }

    private void OnDisable() {
        ReferenciaNotificador.OnCuboAproximado -= EncararObjeto;
    }

    private void EncararObjeto() {
        Vector3 puntoMirada = new Vector3(objetoEncarar.position.x, transform.position.y, objetoEncarar.position.z);
        transform.LookAt(puntoMirada);
    }
}
