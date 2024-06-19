
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField] private GameObject[] animals;
    [SerializeField] private int index;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        index = Random.Range(1, 4);
        StartCoroutine(Spawn(index));
    }
    IEnumerator Spawn(int random)
    {
        yield return new WaitForSeconds(2);
        Init(random);
    }
    void Init(int random)
    {
        Instantiate(animals[random], new Vector3(Random.Range(-4,4),transform.position.y, transform.position.z), transform.rotation);  
        
    }
}
