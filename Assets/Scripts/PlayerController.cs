using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public GameObject bulletType1;
    private float horBorder = 20;
    private float vertBorder = 10;
    Rigidbody playerRb;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.forward * speed * verticalInput);
        playerRb.AddForce(Vector3.right * speed * horizontalInput);

        CheckBorder();
        //transform.Translate(Vector3.forward * speed * verticalInput * Time.deltaTime);
        //transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletType1, transform.position, transform.rotation);
        }
    }
    void CheckBorder()
    {
        if(transform.position.x < -horBorder)
        {
            transform.position = new Vector3(-horBorder, transform.position.y, transform.position.z);
        }
        if(transform.position.z < -vertBorder)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -vertBorder);
        }
        if(transform.position.z > vertBorder)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, vertBorder);
        }
        if(transform.position.x > horBorder)
        {
            transform.position = new Vector3(horBorder, transform.position.y, transform.position.z);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) { Debug.Log("Player has collided with enemy"); }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Powerup")) { Debug.Log("Powerup is picked");
            Destroy(other.gameObject);
        }
    }
}
