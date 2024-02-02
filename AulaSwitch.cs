using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaSwitch : MonoBehaviour
{
    public int forca;

    // Start is called before the first frame update
    void Start()
    {
        switch(forca)
        {
            case 1:
                Debug.Log("forca igual a 1");
                break;

            case 2:
                Debug.Log("forca igual a 2");
                break;

            case 3:
                Debug.Log("forca igual a 3");
                break;

            case 4:
                Debug.Log("forca igual a 4");
                break;

            case 5:
                Debug.Log("forca igual a 5");
                break;

            default:
                Debug.Log("Não possui valor atribuído!");
                break;

        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
