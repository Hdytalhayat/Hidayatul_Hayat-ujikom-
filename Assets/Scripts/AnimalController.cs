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
    [SerializeField]private AudioSource audioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(DestroyObj());
        rb.velocity = transform.TransformDirection(Vector3.forward * speed);
    }
    IEnumerator DestroyObj()
    {
        yield return new WaitForSeconds(4);
        Destroy(gameObject);
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "Food(Clone)")
        {
            Debug.Log("TRUE");
            audioSource.Play();
            Destroy(gameObject);
        }
    }

}
