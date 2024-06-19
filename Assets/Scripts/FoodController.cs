using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController : MonoBehaviour
{
    [SerializeField]private int destroTime = 20;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(DestroyFood());
    }
    IEnumerator DestroyFood()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
