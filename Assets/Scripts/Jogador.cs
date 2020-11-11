using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public float velocidade = 2f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector2.up * vertical * velocidade * Time.deltaTime);
    }
}
