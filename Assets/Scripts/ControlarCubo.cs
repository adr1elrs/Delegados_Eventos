using UnityEngine;

public class ControlarCubo : MonoBehaviour
{
    public float speed = 6.0f;

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direccion = new Vector3(horizontal, 0, vertical);
        transform.Translate(direccion * speed * Time.deltaTime);
    }
}
