using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePipes : MonoBehaviour
{
    private bool end = false;
    [SerializeField] private float cooldown = 2;
    [SerializeField] private GameObject prefabPipe;

    void Start()
    {
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
            Instantiate(prefabPipe);
        }
    }
}
