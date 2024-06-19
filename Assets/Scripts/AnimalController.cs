using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AnimalController : MonoBehaviour
{
    [SerializeField]private float speed;
    [SerializeField]private float hunger;
    [SerializeField]private int score;
    [SerializeField]private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(DestroyObj());
        rb.velocity = transform.TransformDirection(Vector3.forward * speed);
    }
    IEnumerator DestroyObj()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }

}
