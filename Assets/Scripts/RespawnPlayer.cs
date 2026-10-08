using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    [SerializeField] private Transform plataformaRespawn;
    [SerializeField] private float alturaRespawn = 2f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Vector3 posicionRespawn = plataformaRespawn.position;

            posicionRespawn.y += alturaRespawn;

            other.transform.position = posicionRespawn;
        }
    }
}