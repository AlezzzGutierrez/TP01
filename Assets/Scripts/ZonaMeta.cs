using UnityEngine;

public class ZonaMeta : MonoBehaviour
{
    [SerializeField] private GameObject mensajeVictoria;
    [SerializeField] private ParticleSystem particulasVictoria;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ObjetoTransportable"))
        {
            Debug.Log("¡Objeto entregado correctamente!");

            mensajeVictoria.SetActive(true);
            particulasVictoria.Play();
        }
    }
}