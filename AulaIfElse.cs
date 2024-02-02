using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaIfElse : MonoBehaviour
{

    public float vida;

    // Start is called before the first frame update
    void Start()
    {
        if(vida <= 0)
        {
            //executa aqui se a condicao for verdadeira
            Debug.Log("Game Over!");
        }
        else
        {
            //executa aqui se a condicao for falsa
            Debug.Log("Vivo!");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
