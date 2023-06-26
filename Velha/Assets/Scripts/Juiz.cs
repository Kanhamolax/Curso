using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Juiz : MonoBehaviour
{
    public SpriteRenderer t1, t2,velha ;
    public TextMeshProUGUI placar01, placar02;
    int placar1, placar2;
    // Start is called before the first frame update
    void Start()
    {
        placar1 = 0;
        placar2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
       // Calcula.Vencedor1();
       // Calcula.Vencedor2();
        

        if(Calcula.vencedor==1)
        {
            t1.enabled = true;
            placar1++;
            placar01.text = placar1.ToString();
            Calcula.vencedor = 4;
        }
        if (Calcula.vencedor == 2)
        {
           t2.enabled = true;
            placar2++;
            placar02.text = placar2.ToString();
            Calcula.vencedor = 4;
                
        }
        if (Calcula.vencedor == 3)
        {

            velha.enabled = true;
            Calcula.vencedor = 4;
        }
    }
}
