
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField] private GameObject[] animals;
    int interval = 10;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(2);
        Init();   
    }
    void Init()
    {
        Instantiate(animals[Random.Range(1, 4)], new Vector3(Random.Range(-4,4),transform.position.y, transform.position.z), transform.rotation);
        
    }
}
