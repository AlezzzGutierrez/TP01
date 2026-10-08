using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using System.Collections;
public class Movements : MonoBehaviour
{

    [SerializeField] private float velocidad = 5f;
    private float velocidadOriginal;
    [SerializeField] private float fuerzaSalto = 5f;
    private Rigidbody rb;
     private float tiempoEntreSaltos = 1f;
    private bool puedeSaltar = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
       
            rb = GetComponent<Rigidbody>();
            velocidadOriginal = velocidad;

    }
    
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direccion = new Vector3(horizontal, 0f, vertical);

        transform.Translate(
            direccion * velocidad * Time.deltaTime,

            Space.World
            );


        bool down = Input.GetButtonDown("Jump");
        bool held = Input.GetButton("Jump");
        bool up = Input.GetButtonUp("Jump");
        if (Input.GetButtonDown("Jump") && puedeSaltar)
        {
            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
            StartCoroutine(RecargarSalto());
        }

    }
    private IEnumerator RecargarSalto()
    {
        puedeSaltar = false;

        yield return new WaitForSeconds(tiempoEntreSaltos);

        puedeSaltar = true;
    }
    public void CambiarVelocidad(float nuevaVelocidad)
    {
        velocidad = nuevaVelocidad;
    }
    public void RestaurarVelocidad()
    {
        velocidad = velocidadOriginal;
        Debug.Log("Velocidad restaurada a: " + velocidad);
    }
}

