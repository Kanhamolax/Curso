using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resete : MonoBehaviour
{
    public Material[] material;
    public SpriteRenderer t1, t2, velha;
    // Start is called before the first frame update
    void OnMouseOver()
    {

        this.transform.localScale = new Vector3(1.09f, 1.09f, 1.09f);



        if (Input.GetMouseButtonUp(0))
        {

            for (int i = 1; i < 10; i++)
            {
                material[i].color = material[0].color;
            }
            Calcula.Inicia();
            t1.enabled = false;
            t2.enabled = false;
            velha.enabled = false;
           


        }
    }
    void OnMouseExit()
    {
        this.transform.localScale = new Vector3(1, 1, 1);

    }
}
