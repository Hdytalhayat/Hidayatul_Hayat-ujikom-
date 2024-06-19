using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController : MonoBehaviour
{

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
