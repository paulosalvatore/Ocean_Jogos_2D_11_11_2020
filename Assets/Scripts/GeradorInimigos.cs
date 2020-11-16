using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorInimigos : MonoBehaviour
{
    public GameObject inimigoPrefab;

    [Range(0f, 5f)]
    public float delayGerarInimigos = 1f;

    public float posicaoYAleatoria = 0.9f;

    private void Start()
    {
        InvokeRepeating("Gerar", delayGerarInimigos, delayGerarInimigos);
    }

    private void Gerar()
    {
        var posicaoAtualY = transform.position.y;
        var posicaoY = Random.Range(posicaoAtualY - posicaoYAleatoria, posicaoAtualY + posicaoYAleatoria);

        var posicao = transform.position;
        posicao.y = posicaoY;

        Instantiate(inimigoPrefab, posicao, transform.rotation);
    }
}
