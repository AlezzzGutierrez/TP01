using UnityEngine;

public class PlataformaMovil : MonoBehaviour
{
    [SerializeField] private Transform puntoA;
    [SerializeField] private Transform puntoB;
    [SerializeField] private float velocidad = 5f;

    private bool vaHaciaB = true;
    private bool puedeMoverse = true;

    void Start()
    {
        puedeMoverse = true;

    }

    void Update()
    {
        if (!puedeMoverse)
            return;

        if (vaHaciaB)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                puntoB.position,
                velocidad * Time.deltaTime
            );

            if (transform.position == puntoB.position)
            {
                puedeMoverse = false;
                Invoke("CambiarDireccion", 0.5f);
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                puntoA.position,
                velocidad * Time.deltaTime
            );

            if (transform.position == puntoA.position)
            {
                puedeMoverse = false;
                Invoke("CambiarDireccion", 0.5f);
            }
        }
    }

    void CambiarDireccion()
    {
        vaHaciaB = !vaHaciaB;
        puedeMoverse = true;

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
    }
}