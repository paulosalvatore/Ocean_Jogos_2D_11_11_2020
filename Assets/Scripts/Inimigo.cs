﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inimigo : MonoBehaviour
{
    [Range(0f, 20f)]
    public float velocidade = 2f;

    [Range(0f, 10f)]
    public float delayDestruir = 5f;

    public GameObject explosaoPrefab;

    private Jogador jogadorScript;

    private void Start()
    {
        jogadorScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Jogador>();

        Destroy(gameObject, delayDestruir);
    }

    private void Update()
    {
        transform.Translate(Vector2.left * velocidade * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Projétil"))
        {
            jogadorScript.AdicionarPontos();

            // Destrói o GameObject do Projétil
            Destroy(other.gameObject);

            // Destrói o inimigo
            Destroy(gameObject);

            // Criar o prefab da explosão
            Instantiate(explosaoPrefab, transform.position, Quaternion.identity);
        }

        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
