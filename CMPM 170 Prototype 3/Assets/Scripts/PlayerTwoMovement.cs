using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerTwoMovement : MonoBehaviour
{

    [SerializeField]
    private float speed = 2.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (Input.GetKey(KeyCode.RightShift))
            {
                transform.position += Vector3.up * speed * Time.deltaTime;
            }
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (Input.GetKey(KeyCode.RightShift))
            {
                transform.position += Vector3.down * speed * Time.deltaTime;
            }
            transform.position += Vector3.back * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
}
