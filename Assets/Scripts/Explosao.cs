using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosao : MonoBehaviour
{
    [Range(0f, 10f)]
    public float delayDestruir = 0.4f;

    private void Start()
    {
        Destroy(gameObject, delayDestruir);
    }
}
