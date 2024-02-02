using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaFor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int contador;
        //for(comando de inicializacao; condicao; incremento/decremento)
        for(contador = 0; contador < 5; contador++)
        {
            Debug.Log(contador);
        }

        Debug.Log("O valor final do contador é: " + contador);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
