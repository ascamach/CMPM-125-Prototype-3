using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerOneMovement : MonoBehaviour
{

    [SerializeField]
    private float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey (KeyCode.LeftShift))
            {
                transform.position += Vector3.up * speed * Time.deltaTime;
            }
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey (KeyCode.S))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.position += Vector3.down * speed * Time.deltaTime;
            }
            transform.position += Vector3.back * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
}
