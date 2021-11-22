using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    private float speed = 5f;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector3.forward * speed * Time.deltaTime);
        if(transform.position.z < -50 && !CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}
