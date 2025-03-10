using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cinta : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    public List<GameObject> onBelt;
    public GameObject boxPrefab;
    public Transform spawnPoint;
    public float spawnInterval = 2f;

    void Start()
    {
        StartCoroutine(SpawnearCajasConIntervalo());
    }

    void Update()
    {

        for (int i = 0; i <= onBelt.Count - 1; i++)
        {
            onBelt[i].GetComponent<Rigidbody>().linearVelocity = speed * direction * Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        onBelt.Add(collision.gameObject);
    }

    private void OnCollisionExit(Collision collision)
    {
        onBelt.Remove(collision.gameObject);
    }

    IEnumerator SpawnearCajasConIntervalo()
    {
        while (true)
        {
            Instantiate(boxPrefab, spawnPoint.transform.position, spawnPoint.transform.rotation);
            yield return new WaitForSeconds(spawnInterval);
        }
    }

}

