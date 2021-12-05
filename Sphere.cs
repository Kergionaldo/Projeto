using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public string gamename = "Projeto";

    public float eixox;
    public float eixoy;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("\nStart\n" + gamename);
    }

    // Update is called once per frame
    void Update()
    {
        eixox = Input.GetAxis("Horizontal");
        eixoy = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * eixox * Time.deltaTime * 10);
        transform.Translate(Vector3.forward * eixoy * Time.deltaTime * 10);

        if (Input.GetKeyUp("space"))
        {
            transform.Translate(Vector3.up);
        }

    }
}
