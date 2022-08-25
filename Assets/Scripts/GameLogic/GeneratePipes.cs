using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePipes : MonoBehaviour
{
    [SerializeField] private float cooldown = 2;
    [SerializeField] private float range = 32f;
    [SerializeField] private GameObject prefabPipe;
    [SerializeField] private GameObject soundManager;

    private Vector3 pipeStartPosition;
    private Coroutine generator;
    private GameObject pipe;

    void Start()
    {
        pipeStartPosition = prefabPipe.transform.position;
    }

    public IEnumerator generatePipes()
    {
        while(true)
        {
            pipe = Instantiate(prefabPipe, pipeStartPosition + new Vector3(0,Random.Range(0f,range),0), Quaternion.identity);
            pipe.GetComponent<Pipe>().soundManager = soundManager.GetComponent<SoundManager>();
            yield return new WaitForSeconds(cooldown);
        }
    }

    public void gameReady()
    {
        GameObject[] pipes = GameObject.FindGameObjectsWithTag("Pipe");
        foreach(GameObject pipe in pipes){
            Destroy(pipe);
        }
    }

    public void gameStart()
    {
        generator = StartCoroutine(generatePipes());
    }

    public void gameOver()
    {
        StopCoroutine(generator);
    }
}
