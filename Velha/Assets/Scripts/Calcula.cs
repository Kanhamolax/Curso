using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calcula
{
    // Start is called before the first frame update
    public static int[,] matris = new int[3, 3];
    public static int player, vencedor,empate;


    public static void Inicia()
    {
        player = 1;
        vencedor = 0;
        empate = 0;
      
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matris[i, j] = 0;
            }
        }

    }
    public static void inseri(int x, int y, int op)
    {
        if (player == 1)
        {
            matris[x, y] = 1;
        }
       else if (player == 2)
        {
            matris[x, y] = 10;
        }

    }


    public static void Vencedor1()
    {

        if (vencedor == 0)
        {
            if (matris[0, 0] + matris[0, 1] + matris[0, 2] == 3)
            {
                vencedor = 1;
            }
            if (matris[1, 0] + matris[1, 1] + matris[1, 2] == 3)
            {
                vencedor = 1;
            }
            if (matris[2, 0] + matris[2, 1] + matris[2, 2] == 3)
            {
                vencedor = 1;
            }
            if (matris[0, 0] + matris[1, 0] + matris[2, 0] == 3)
            {
                vencedor = 1;
            }
            if (matris[0, 1] + matris[1, 1] + matris[2, 1] == 3)
            {
                vencedor = 1;
            }
            if (matris[0, 2] + matris[1, 2] + matris[2, 2] == 3)
            {
                vencedor = 1;
            }
            if (matris[0, 0] + matris[1, 1] + matris[2, 2] == 3)
            {
                vencedor = 1;
            }
            if (matris[0, 2] + matris[1, 1] + matris[2, 0] == 3)
            {
                vencedor = 1;
            }

        }


    }

    public static void Vencedor2()
    {
        if (vencedor == 0)
        {
            if (matris[0, 0] + matris[0, 1] + matris[0, 2] == 30)
            {
                vencedor = 2;
            }

            if (matris[1, 0] + matris[1, 1] + matris[1, 2] == 30)
            {
                    vencedor = 2;
            }
            if (matris[2, 0] + matris[2, 1] + matris[2, 2] == 30)
            {
                    vencedor = 2;
            }
            if (matris[0, 0] + matris[1, 0] + matris[2, 0] == 30)
            {
                    vencedor = 2;
            }
             if (matris[0, 1] + matris[1, 1] + matris[2, 1] == 30)
             {
                    vencedor = 2;
             }
             if (matris[0, 2] + matris[1, 2] + matris[2, 2] == 30)
             {
                    vencedor = 2;
             }
             if (matris[0, 0] + matris[1, 1] + matris[2, 2] == 30)
             {
                    vencedor = 2;
             }
             if (matris[0, 2] + matris[1, 1] + matris[2, 0] == 30)
             {
                    vencedor = 2;
             }
        }


    }
    public static void Empate()
    {
        if(vencedor==0)
        {
            empate = 0;
            for (int k = 0; k < 3; k++)
            {
                for (int w = 0; w < 3; w++)
                {
                    if (matris[k, w] == 0)
                    {
                        empate++;
                    }

                }
            }
            if (empate == 0)
            {
                vencedor = 3;
            }
        }
       




    }
}
