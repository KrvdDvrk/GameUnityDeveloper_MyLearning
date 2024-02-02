using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaList : MonoBehaviour
{

    public List<string> tiposInimigos = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        tiposInimigos.Add("Necros");
        tiposInimigos.Add("Shadows");
        tiposInimigos.Add("Cosmics");

        // Clear, limpa a lista
        //tiposInimigos.Clear();

        // Contains, checa se existe algo dentro da lista, bool T or F.
        //if(tiposInimigos.Contains("Cosmics"))
        //{
        //    Debug.Log("Existe um Cosmic")
        //}

        // Insert, insere um elemento na lista dentro de determinada posição.
        //tiposInimigos.Insert(0, "Aliens");

        // ToArray, transforma a lista em um array.
        // Find, localizar algo na lista.
        // Há muitas outras opções, pesquisar.
    }

    // Update is called once per frame
    void Update()
    {

    }
}
