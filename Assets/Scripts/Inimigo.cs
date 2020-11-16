using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    [Range(0f, 20f)]
    public float velocidade = 2f;

    [Range(0f, 10f)]
    public float delayDestruir = 5f;

    private void Start()
    {
        Destroy(gameObject, delayDestruir);
    }

    private void Update()
    {
        transform.Translate(Vector2.left * velocidade * Time.deltaTime);
    }
}
