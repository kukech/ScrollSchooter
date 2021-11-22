using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10f;
    public GameObject bulletType1;
    private float horBorder = 20;
    //Rigidbody playerRb;
    void Start()
    {
        //playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed * verticalInput * Time.deltaTime);
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);

        if(transform.position.x < -horBorder)
        {
            transform.position = new Vector3(-horBorder, transform.position.y, transform.position.z);
        }
        if(transform.position.x > horBorder)
        {
            transform.position = new Vector3(horBorder, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletType1, transform.position, transform.rotation);
        }
        //playerRb.AddForce(Vector3.forward * speed * verticalInput);
        //playerRb.AddForce(Vector3.right * speed * horizontalInput);
    }
}
