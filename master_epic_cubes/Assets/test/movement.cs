using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour
{
    public float thrust;
    public Rigidbody rb;
    public float jumpforce;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        thrust = 1f;
       // jumpforce = .001f;
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal") * thrust * Time.deltaTime;
        if (Input.GetKey(KeyCode.D))
        {

            rb.AddTorque(transform.right * h);

        }

        if (Input.GetKey(KeyCode.A))
        {

            rb.AddTorque(transform.right * h);

        }



        /*  if (Input.GetKey(KeyCode.Space))
          {

              rb.AddForce(Vector3.up * jumpforce/20 * Time.deltaTime, ForceMode.Impulse);

          }


      }*/

    }
}
