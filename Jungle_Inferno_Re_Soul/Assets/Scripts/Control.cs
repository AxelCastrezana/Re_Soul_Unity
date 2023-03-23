using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Control : MonoBehaviour
{
    [SerializeField] private int velocidad = 10, fuerzaGiro = 100, fuerza=5;
    [SerializeField] private float inputY, inputX, inputZ, inputGX /*inputGY*/;
    [SerializeField] private GameObject Canvas;
    private Rigidbody jugador;
    private bool act=true;
    // Start is called before the first frame update
    void Start()
    {
        jugador = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        inputZ = Input.GetAxis("Vertical");
        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Jump");
        inputGX = Input.GetAxis("Mouse X");
        //inputGY = Input.GetAxis("Mouse Y");
        transform.Translate(Vector3.forward * Time.deltaTime * velocidad * inputZ);
        transform.Translate(Vector3.right * Time.deltaTime * velocidad * inputX);
        transform.Rotate(Vector3.up * Time.deltaTime * fuerzaGiro * inputGX);
        if (Input.GetKeyDown(KeyCode.Space) && act)
        {
            act = false;
           jugador.AddForce(0, 1 * fuerza, 0, ForceMode.Impulse);
        }

    }
    
        //transform.Rotate(Vector3.right * Time.deltaTime * fuerzaGiro * inputGY);

/*
        if (transform.position.x <= 1) {
            transform.position = new Vector3(1, transform.position.y, transform.position.z);
        }
        else if (transform.position.x >= 99)
        {
            transform.position = new Vector3(99, transform.position.y, transform.position.z);
        }


        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Time.timeScale == 1) {
                Time.timeScale = 0;
                Canvas.SetActive(true);
            }
            else if (Time.timeScale == 0)
            {
                Canvas.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }
}
*/

/*
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ZonaFria"))
        {
            velocidad = 2;
        }
    }


    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ZonaFria"))
        {
            velocidad = 10;
        }
    }
    */


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Tierra"))
        {
            act=true;
        }
    }
}


/*
//inputX = Input.GetAxis("Vertical");
  //      if (Input.GetKey(KeyCode.D)){
    //      transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * valor1);
      //  }
*/


