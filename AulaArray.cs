using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaArray : MonoBehaviour
{

    public string inimigo1 = "Necros";
    public string inimigo2 = "Shadows";
    public string inimigo3 = "Cosmics";

    // Forma manual:
    //public string[] inimigos;

    // Forma automatizada:
    public string[] meusInimigos = new string[] { "Nxcros", "Shxdxws", "Cxsmxcs"};

    // GameObject é tudo que está na cena.
    public GameObject[] inimigos;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(meusInimigos[2]);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
