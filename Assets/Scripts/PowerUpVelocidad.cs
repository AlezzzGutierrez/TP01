using UnityEngine;
using System.Collections;

public class PowerUpVelocidad : MonoBehaviour
{
    [SerializeField] private float velocidadPotenciada = 10f;
    [SerializeField] private float duracion = 10f;

    private Collider col;
    private Renderer[] renders;

    void Start()
    {
        col = GetComponent<Collider>();
        renders = GetComponentsInChildren<Renderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("¡TOQUÉ EL POWER-UP!");

            Movements jugador = other.GetComponent<Movements>();

            StartCoroutine(ActivarPowerUp(jugador));

            col.enabled = false;

            foreach (Renderer rend in renders)
            {
                rend.enabled = false;
            }
        }
    }

    IEnumerator ActivarPowerUp(Movements player)
    {
        player.CambiarVelocidad(velocidadPotenciada);

        yield return new WaitForSeconds(duracion);

        player.RestaurarVelocidad();
    }
}