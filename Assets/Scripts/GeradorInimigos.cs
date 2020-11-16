using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorInimigos : MonoBehaviour
{
    public GameObject inimigoPrefab;

    [Range(0f, 5f)]
    public float delayGerarInimigos = 1f;

    private void Start()
    {
        InvokeRepeating("Gerar", delayGerarInimigos, delayGerarInimigos);
    }

    private void Gerar()
    {
        Instantiate(inimigoPrefab, transform.position, transform.rotation);
    }
}
