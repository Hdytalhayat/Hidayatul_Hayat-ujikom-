using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private CharacterController characterController;
    [SerializeField] private float playerSpeed = 350f;

    [SerializeField] private GameObject food;
    void Start()
    {
        characterController = gameObject.AddComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        characterController.Move(move * Time.deltaTime * playerSpeed);
        shoot();
    }
    void shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(food, gameObject.transform.position, Quaternion.identity);
        }
    }
}
