using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerControl : MonoBehaviour
{

    public float HorizontalInput;
    public float speed = 10.0f;
    public float xRange = 10;
    
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Speler binnen camara houden
        if (transform.position.x < -xRange) 
        {
            transform.position = new Vector3( -xRange, transform.position.y, transform.position.z);
        }
        
        if (transform.position.x > xRange) 
        {
            transform.position = new Vector3( xRange, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //speler schiet nu iets
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        HorizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * HorizontalInput * Time.deltaTime * speed);
    }
}
