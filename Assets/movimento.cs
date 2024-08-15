using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movimento : MonoBehaviour
{
    Vector3 m; 
    // Start is called before the first frame update
    void Start()
    {
        m.x = 2;
        m.y = 2;
        m.z = -33;
        transform.position = m;
        m.Set(0, 0, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -4)
            {
                m.x = -0.01f;
                transform.Translate(m);
            }
        }
        if (Input.GetKey(KeyCode.D)) 
        {
            if (transform.position.x < 4)
            {
                m.x = 0.01f;
                transform.Translate(m);
            }
        }
        if (Input.GetKey(KeyCode.W)) 
        {
            if (transform.position.z < -30)
            {
                m.z = 0.01f;
                transform.Translate(m);
            }
        }
        if (Input.GetKey(KeyCode.S)) 
        {
            if (transform.position.z > -40)
            {
                m.z = -0.01f;
                transform.Translate(m);
            }
        }
        if(Input.GetKey(KeyCode.Space)) 
        {
                m.y = 0.05f;
                transform.Translate(m);
        }
        if (Input.GetKey(KeyCode.LeftControl)) 
        {
            m.y = -0.05f;
            transform.Translate(m);
        }
        if (Input.GetKey(KeyCode.Q)) 
        {
            m.x = 0;
            transform.Translate(m);
            transform.Rotate(0f,5f,0f);
        }
        if (Input.GetKey(KeyCode.E))
        {
            m.x = 0;
            transform.Translate(m);
            transform.Rotate(0f, -5f, 0f);
        }
        m.Set(0, 0, 0);
    }
}
