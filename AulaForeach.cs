using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaForeach : MonoBehaviour
{
    // É usado para percorrer posições

    public string[] nomesNPC = new string[3];

    public List<string> nomesInimigos = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        nomesNPC[0] = "Krvd";
        nomesNPC[1] = "Dvrk";
        nomesNPC[2] = "KrvdDvrk";

        nomesInimigos.Add("Godzilla");
        nomesInimigos.Add("Cthullu");
        nomesInimigos.Add("Killgrave");

        // Estrutura:
        // tipo de item da coleção in coleção
        foreach(string elementoNPC in nomesNPC)
        {
            Debug.Log(elementoNPC);
        }

        foreach(string elementoINI in nomesInimigos)
        {
            Debug.Log(elementoINI);
        }

        // Exemplo dessa lógica com o for  COM ARRAY
        // for(int i = 0; i < nomesNPC.Length, i++)
        // {
        //     Debug.Log(nomesNPC[i]);
        // }

        // Exemplo dessa lógica com o for  COM LIST
        // for(int i = 0; i < nomesInimigos.Count, i++)
        // {
        //     Debug.Log(nomesInimigos[i]);
        // }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
