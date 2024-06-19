using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private CharacterController characterController;
    [SerializeField] private float playerSpeed = 350f;

    [SerializeField] private Rigidbody food;
    [SerializeField] private Animator animator;
    [SerializeField]private AudioSource menuClip;
    [SerializeField]private Button menubtn;
    void Start()
    {
        characterController = gameObject.AddComponent<CharacterController>();
        animator = GetComponent<Animator>();
        menubtn.onClick.AddListener(MenuBtn);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        if(Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("Left");
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("Right");
        }
        characterController.Move(move * Time.deltaTime * playerSpeed);
        shoot();
    }
    void shoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            animator.SetTrigger("Throw");
            Rigidbody clone;
            clone = Instantiate(food, transform.position, transform.rotation);
            clone.velocity = transform.TransformDirection(Vector3.forward * 10);
        }
    }
    void MenuBtn()
    {
        menuClip.Play();
        SceneManager.LoadScene("MainMenu");
    }
}
