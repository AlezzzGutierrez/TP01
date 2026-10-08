using UnityEngine;

public class Moneda : MonoBehaviour
{
    [SerializeField] private Transform puntoDeTransporte;
    [SerializeField] private float velocidadRotacion = 100f;
    private bool jugadorCerca = false;
    private bool transportando = false;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Rotar();

        if (Input.GetKeyDown(KeyCode.E) && jugadorCerca && !transportando)
        {
            Recoger();
        }

        if (Input.GetKeyDown(KeyCode.R) && transportando)
        {
            Soltar();
        }
    }

    void Rotar()
    {
        transform.Rotate(1f, 0f, 0f);
    }

    void Recoger()
    {
        rb.isKinematic = true;

        rb.constraints = RigidbodyConstraints.FreezeAll;

        transform.SetParent(puntoDeTransporte);
        transform.localPosition = Vector3.zero;
        transportando = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            jugadorCerca = true;
            Debug.Log("¡Jugador cerca de la moneda!");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            jugadorCerca = false;
        }
    }

    void Soltar()
    {
        transform.SetParent(null);

        rb.isKinematic = false;

        rb.constraints = RigidbodyConstraints.None;

        transportando = false;
    }
}