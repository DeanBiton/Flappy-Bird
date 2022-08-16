using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePipes : MonoBehaviour
{
    private bool endGame = false;
    [SerializeField] private float cooldown = 2;
    [SerializeField] private float range = 32f;
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
        while(!endGame)
        {
            yield return new WaitForSeconds(cooldown);
            Instantiate(prefabPipe, pipeStartPosition + new Vector3(0,Random.Range(0f,range),0), Quaternion.identity);
        }
    }
}
