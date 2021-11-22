using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float speed = 8f;
    public GameObject tmp1;
    public GameObject tmp2;
    void Start()
    {
        Debug.Log(tmp1.transform.position.z - tmp2.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector3.forward * speed * Time.deltaTime);
    }
}
