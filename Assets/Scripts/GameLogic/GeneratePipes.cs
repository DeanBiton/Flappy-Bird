using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePipes : MonoBehaviour
{
    private bool end = false;
    [SerializeField] private float cooldown = 2;
    [SerializeField] private GameObject prefabPipe;
    private Vector3 pipeStartPosition;
    void Start()
    {
        pipeStartPosition = prefabPipe.transform.position;
        StartCoroutine(generatePipes());
    }

    void Update()
    {

    }

    IEnumerator generatePipes()
    {
        while(!end)
        {
            yield return new WaitForSeconds(cooldown);
            Instantiate(prefabPipe, pipeStartPosition + new Vector3(0,Random.Range(0f,32f),0), Quaternion.identity);
        }
    }
}
