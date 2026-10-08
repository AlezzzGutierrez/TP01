using UnityEngine;

public class SpawnerObstaculos : MonoBehaviour
{
    [SerializeField] private GameObject Bala;
    [SerializeField] private float intervalo = 1f;
    void Start()
    {
        InvokeRepeating("CrearObstaculo", 2f, intervalo);
    }

    void CrearObstaculo()
    {
        GameObject nuevoObstaculo = Instantiate(
            Bala,
            transform.position,
            transform.rotation
        );

        nuevoObstaculo.GetComponent<MovimientoObstaculo>()
            .ConfigurarDireccion(transform.forward);
    }
}