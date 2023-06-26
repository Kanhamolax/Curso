using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tabuleiro : MonoBehaviour
{
    public int x, y;
   
    public Color cor1,cor2,cor3;
  
    public Material material2;

    // Start is called before the first frame update
    void OnMouseOver()
    {
        if (Calcula.matris[x-1,y-1]==0 && Calcula.vencedor==0)
        {
            this.transform.localScale = new Vector3(1.09f, 1.09f, 1.09f);



            if (Input.GetMouseButtonUp(0))
            {

                if (Calcula.player == 1)
                {
                    material2.color = cor2;
                    Calcula.inseri(x - 1, y - 1, 1);
                    Calcula.player = 2;
                    
                    Calcula.Vencedor1();
                    Calcula.Vencedor2();
                    Calcula.Empate();

                }
                else if (Calcula.player == 2)
                {
                    material2.color = cor3;
                    Calcula.inseri(x - 1, y - 1, 2);
                    Calcula.player = 1;
                    
                    Calcula.Vencedor1();
                    Calcula.Vencedor2();
                    Calcula.Empate();
                }


            }
        }
        
    }
    void OnMouseExit()
    {
        this.transform.localScale = new Vector3(1, 1,1);

    }
}
