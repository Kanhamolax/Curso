using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu1 : MonoBehaviour
{
    public int op;
    public string cena;
    // Start is called before the first frame update
    void OnMouseOver()
    {
        this.transform.localScale = new Vector2(1.09f, 1.09f);



        if (Input.GetMouseButtonUp(0))
        {
           if(op==1) 
            {
                Calcula.Inicia();
                SceneManager.LoadScene(cena);
                print("inicia jogo");

            }
            if (op == 2)
            {

                SceneManager.LoadScene(cena);
                print("inicia Creditos");

            }
            if (op == 3)
            {
                print("sair");
                Application.Quit();
               

            }




        }
    }

    void OnMouseExit()
    {
        this.transform.localScale = new Vector2(1, 1);

    }
}
