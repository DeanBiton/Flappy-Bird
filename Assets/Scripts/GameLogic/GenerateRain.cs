using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateRain : MonoBehaviour
{
    [SerializeField] private float cooldown;
    [SerializeField] private float rainDurationRangeStart;
    [SerializeField] private float rainDurationRangeEnd;
    [SerializeField] private float rainAppearancePercentage;
    [SerializeField] private GameObject rain;
    private GameObject player;
    private Coroutine generator;

    public void gameReady()
    {
        rain.GetComponent<ParticleSystem>().Stop();
        rain.GetComponent<ParticleSystem>().Clear();
    }

    public void gameStart()
    {
        player = GameObject.FindWithTag("Player");
        generator = StartCoroutine(generateRain());
    }

    public void gameOver()
    {
        StopCoroutine(generator);
        player = null;
    }

    public IEnumerator generateRain()
    {
        while(true)
        {
            yield return new WaitForSeconds(cooldown);
            if(Random.Range(0f,1f) < rainAppearancePercentage)
            {
                rain.GetComponent<ParticleSystem>().Play();
                player.GetComponent<Rigidbody2D>().gravityScale *= 2;
                yield return new WaitForSeconds(Random.Range(rainDurationRangeStart,rainDurationRangeEnd));
                rain.GetComponent<ParticleSystem>().Stop();
                player.GetComponent<Rigidbody2D>().gravityScale /= 2;
            }
        }
    }
}
