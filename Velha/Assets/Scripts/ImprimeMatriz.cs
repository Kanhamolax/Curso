using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImprimeMatriz : MonoBehaviour
{
    // Start is called before the first frame update
    void OnMouseOver()
    {

        this.transform.localScale = new Vector3(1.09f, 1.09f, 1.09f);



        if (Input.GetMouseButtonUp(0))
        {

            Application.Quit();


        }
    }
    void OnMouseExit()
    {
        this.transform.localScale = new Vector3(1, 1, 1);

    }
}
