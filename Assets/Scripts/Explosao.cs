using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosao : MonoBehaviour
{
    [Range(0f, 10f)]
    public float delayDestruir = 1f;

    private void Start()
    {
        Destroy(gameObject, delayDestruir);
    }
}
