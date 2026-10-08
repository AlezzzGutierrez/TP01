using UnityEngine;

public class MovimientoObstaculo : MonoBehaviour
{
    [SerializeField] private float velocidad = 5f;
    [SerializeField] private float tiempoDeVida = 1f;

    private Vector3 direccion;

    void Start()
    {
        Destroy(gameObject, tiempoDeVida);
    }

    void Update()
    {
        transform.position += direccion * velocidad * Time.deltaTime;
    }

    public void ConfigurarDireccion(Vector3 nuevaDireccion)
    {
        direccion = nuevaDireccion;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody rbPlayer = collision.gameObject.GetComponent<Rigidbody>();

            rbPlayer.AddForce(direccion * 10f, ForceMode.Impulse);
        }
    }
}