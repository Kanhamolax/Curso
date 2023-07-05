using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ia : MonoBehaviour
{
    //    // Start is called before the first frame update
    //    private Player[] board;
    //    private Player currentPlayer;
    //    enum Player
    //    {
    //        None, X, O
    //    }

    //    void Start()
    //    {
    //       // turn = Mathf.Round(UnityEngine.Random.Range(0, 1)) == 1;
    //        RestartGame();
    //    }

    //    void RestartGame()
    //    {
    //        board = new Player[9];
    //        currentPlayer = Player.X;
    //    }

    //    void OnGUI()
    //    {
    //        if (GUI.Button(new Rect(10, 10, 100, 30), "Restart"))
    //        {
    //            RestartGame();
    //        }

    //        for (int i = 0; i < 9; i++)
    //        {
    //            int row = i / 3;
    //            int col = i % 3;
    //            Rect rect = new Rect(10 + col * 70, 50 + row * 70, 70, 70);

    //            if (GUI.Button(rect, ""))
    //            {
    //                if (board[i] == Player.None && !CheckGameOver())
    //                {
    //                    board[i] = currentPlayer;
    //                    currentPlayer = (currentPlayer == Player.X) ? Player.O : Player.X;

    //                    if (currentPlayer == Player.O && !CheckGameOver())
    //                    {
    //                        int bestMoveIndex = Minimax(board, currentPlayer);
    //                        if (bestMoveIndex != -1)
    //                        {
    //                            board[bestMoveIndex] = currentPlayer;
    //                            currentPlayer = Player.X;
    //                        }
    //                    }
    //                }
    //            }

    //            GUIStyle style = new GUIStyle(GUI.skin.button);
    //            style.fontSize = 40;
    //            style.alignment = TextAnchor.MiddleCenter;
    //            GUI.Button(rect, GetPlayerSymbol(board[i]), style);
    //        }

    //        if (CheckGameOver())
    //        {
    //            GUI.Label(new Rect(10, 170, 100, 30), "Game Over");
    //        }
    //    }

    //    private int Minimax(Player[] board, Player currentPlayer)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    string GetPlayerSymbol(Player player)
    //    {
    //        switch (player)
    //        {
    //            case Player.X:
    //                return "X";
    //            case Player.O:
    //                return "O";
    //            default:
    //                return "";
    //        }
    //    }

}
