using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhitecheckSavoiur : MonoBehaviour
{
    private initialise_player initialise_Player;
    chess_grid chess_Grid;
    ano_player_func Ano_Player_Func;
    checkMate check;

    private void Start()
    {
        initialise_Player = GameObject.FindGameObjectWithTag("chess").GetComponent<initialise_player>();
        chess_Grid = GameObject.FindGameObjectWithTag("chess_grid").GetComponent<chess_grid>();
        Ano_Player_Func = GameObject.FindGameObjectWithTag("chess_grid").GetComponent<ano_player_func>();
        check = GameObject.FindGameObjectWithTag("chess_grid").GetComponent<checkMate>();
    }
    // Start is called before the first frame update
    public void highlight_knight(int row, int colm)
    {

        //print("knight1"+ initialise_Player.playerPosition[row + 1, colm + 2]);
        if (row + 2 < 8 && colm + 1 < 8 && initialise_Player.playerPosition[row + 2, colm + 1] == "blank")
        {

            chess_Grid.Grid_vector[row + 2, colm + 1].transform.GetChild(1).gameObject.SetActive(true);
        }
        else if (row + 2 < 8 && colm + 1 < 8 && initialise_Player.playerPosition[row + 2, colm + 1].Substring(0, 5) == "black")
        {
            chess_Grid.Grid_vector[row + 2, colm + 1].transform.GetComponent<SpriteRenderer>().color = Color.red;
        }


        if (row + 2 < 8 && colm - 1 >= 0 && initialise_Player.playerPosition[row + 2, colm - 1] == "blank")
        {
            chess_Grid.Grid_vector[row + 2, colm - 1].transform.GetChild(1).gameObject.SetActive(true);
        }
        else if (row + 2 < 8 && colm - 1 >= 0 && initialise_Player.playerPosition[row + 2, colm - 1].Substring(0, 5) == "black")
        {
            chess_Grid.Grid_vector[row + 2, colm - 1].transform.GetComponent<SpriteRenderer>().color = Color.red;
        }

        if (row - 2 >= 0 && colm + 1 < 8 && initialise_Player.playerPosition[row - 2, colm + 1] == "blank")
        {
            chess_Grid.Grid_vector[row - 2, colm + 1].transform.GetChild(1).gameObject.SetActive(true);
        }
        else if (row - 2 >= 0 && colm + 1 < 8 && initialise_Player.playerPosition[row - 2, colm + 1].Substring(0, 5) == "black")
        {
            chess_Grid.Grid_vector[row - 2, colm + 1].transform.GetComponent<SpriteRenderer>().color = Color.red;
        }


        if (row - 2 >= 0 && colm - 1 >= 0 && initialise_Player.playerPosition[row - 2, colm - 1] == "blank")
        {
            chess_Grid.Grid_vector[row - 2, colm - 1].transform.GetChild(1).gameObject.SetActive(true);
        }
        else if (row - 2 >= 0 && colm - 1 >= 0 && initialise_Player.playerPosition[row - 2, colm - 1].Substring(0, 5) == "black")
        {
            chess_Grid.Grid_vector[row - 2, colm - 1].transform.GetComponent<SpriteRenderer>().color = Color.red;
        }



        if (row + 1 < 8 && colm + 2 < 8 && initialise_Player.playerPosition[row + 1, colm + 2] == "blank")
        {
            chess_Grid.Grid_vector[row + 1, colm + 2].transform.GetChild(1).gameObject.SetActive(true);
        }
        else if (row + 1 < 8 && colm + 2 < 8 && initialise_Player.playerPosition[row + 1, colm + 2].Substring(0, 5) == "black")
        {
            chess_Grid.Grid_vector[row + 1, colm + 2].transform.GetComponent<SpriteRenderer>().color = Color.red;
        }


        if (row + 1 < 8 && colm - 2 >= 0 && initialise_Player.playerPosition[row + 1, colm - 2] == "blank")
        {
            chess_Grid.Grid_vector[row + 1, colm - 2].transform.GetChild(1).gameObject.SetActive(true);
        }
        else if (row + 1 < 8 && colm - 2 >= 0 && initialise_Player.playerPosition[row + 1, colm - 2].Substring(0, 5) == "black")
        {
            chess_Grid.Grid_vector[row + 1, colm - 2].transform.GetComponent<SpriteRenderer>().color = Color.red;
        }

        if (row - 1 >= 0 && colm + 2 < 8 && initialise_Player.playerPosition[row - 1, colm + 2] == "blank")
        {
            chess_Grid.Grid_vector[row - 1, colm + 2].transform.GetChild(1).gameObject.SetActive(true);
        }
        else if (row - 1 >= 0 && colm + 2 < 8 && initialise_Player.playerPosition[row - 1, colm + 2].Substring(0, 5) == "black")
        {
            chess_Grid.Grid_vector[row - 1, colm + 2].transform.GetComponent<SpriteRenderer>().color = Color.red;
        }


        if (row - 1 >= 0 && colm - 2 >= 0 && initialise_Player.playerPosition[row - 1, colm - 2] == "blank")
        {
            chess_Grid.Grid_vector[row - 1, colm - 2].transform.GetChild(1).gameObject.SetActive(true);
        }
        else if (row - 1 >= 0 && colm - 2 >= 0 && initialise_Player.playerPosition[row - 1, colm - 2].Substring(0, 5) == "black")
        {
            chess_Grid.Grid_vector[row - 1, colm - 2].transform.GetComponent<SpriteRenderer>().color = Color.red;
        }

    }
    public void highlight_bishop(int row, int colm)
    {
        check_digonally(row, colm);
    }
    public void highlight_queen(int row, int colm)
    {
        check_digonally(row, colm);
        check_vertically_horizantally(row, colm);
    }
    public void highlight_king(int row, int colm)
    {

        for (int i = -1; i <= 1; i++)
        {
            for (int j = -1; j <= 1; j++)
            {
                int r = row + i, c = colm + j;
                if (r < 8 && c < 8 && c >= 0 && r >= 0 && initialise_Player.playerPosition[r, c] == "blank")
                {
                    chess_Grid.Grid_vector[r, c].transform.GetChild(1).gameObject.SetActive(true);
                }
                else if (r < 8 && c < 8 && c >= 0 && r >= 0 && initialise_Player.playerPosition[r, c].Substring(0, 5) == "black")
                {
                    chess_Grid.Grid_vector[r, c].transform.GetComponent<SpriteRenderer>().color = Color.red;
                }
            }
        }
    }
    public void highlight_rook(int row, int colm)
    {
        check_vertically_horizantally(row, colm);
    }
    public void highlight_pawn(int row, int colm)
    {
        
        if (row < 8 && colm + 1 < 8 && initialise_Player.playerPosition[row, colm + 1] == "blank")
        {
            chess_Grid.Grid_vector[row, colm + 1].transform.GetChild(1).gameObject.SetActive(true);
        }
        if ((row - 1 >= 0 && colm + 1 < 8) && initialise_Player.playerPosition[row - 1, colm + 1].Substring(0, 5) == "black")
        {
            chess_Grid.Grid_vector[row - 1, colm + 1].transform.GetComponent<SpriteRenderer>().color = Color.red;
        }
        if ((row + 1 < 8 && colm + 1 < 8) && initialise_Player.playerPosition[row + 1, colm + 1].Substring(0, 5) == "black")
        {
            chess_Grid.Grid_vector[row + 1, colm + 1].transform.GetComponent<SpriteRenderer>().color = Color.red;
        }


    }






    public void check_digonally(int row, int colm)
    {

        for (int i = row + 1, j = colm + 1; i < 8 && j < 8; i++, j++)
        {
            if (initialise_Player.playerPosition[i, j].Substring(0, 5) == "white")
            {
                break;
            }
            else if (initialise_Player.playerPosition[i, j] == "blank")
            {
                chess_Grid.Grid_vector[i, j].transform.GetChild(1).gameObject.SetActive(true);
            }
            else if (initialise_Player.playerPosition[i, j].Substring(0, 5) == "black")
            {
                chess_Grid.Grid_vector[i, j].transform.GetComponent<SpriteRenderer>().color = Color.red;
            }
            if (initialise_Player.playerPosition[i, j].Substring(0, 5) == "black")
            {
                break;
            }
        }

        for (int i = row - 1, j = colm - 1; i >= 0 && j >= 0; i--, j--)
        {
            if (initialise_Player.playerPosition[i, j].Substring(0, 5) == "white")
            {
                break;
            }
            else if (initialise_Player.playerPosition[i, j] == "blank")
            {
                chess_Grid.Grid_vector[i, j].transform.GetChild(1).gameObject.SetActive(true);
            }
            else if (initialise_Player.playerPosition[i, j].Substring(0, 5) == "black")
            {
                chess_Grid.Grid_vector[i, j].transform.GetComponent<SpriteRenderer>().color = Color.red;
            }
            if (initialise_Player.playerPosition[i, j].Substring(0, 5) == "black")
            {
                break;
            }
        }


        for (int i = row + 1, j = colm - 1; i < 8 && j >= 0; i++, j--)
        {
            if (initialise_Player.playerPosition[i, j].Substring(0, 5) == "white")
            {
                break;
            }
            else if (initialise_Player.playerPosition[i, j] == "blank")
            {
                chess_Grid.Grid_vector[i, j].transform.GetChild(1).gameObject.SetActive(true);
            }
            else if (initialise_Player.playerPosition[i, j].Substring(0, 5) == "black")
            {
                chess_Grid.Grid_vector[i, j].transform.GetComponent<SpriteRenderer>().color = Color.red;
            }
            if (initialise_Player.playerPosition[i, j].Substring(0, 5) == "black")
            {
                break;
            }
        }

        for (int i = row - 1, j = colm + 1; i >= 0 && j < 8; i--, j++)
        {
            if (initialise_Player.playerPosition[i, j].Substring(0, 5) == "white")
            {
                break;
            }
            else if (initialise_Player.playerPosition[i, j] == "blank")
            {
                chess_Grid.Grid_vector[i, j].transform.GetChild(1).gameObject.SetActive(true);
            }
            else if (initialise_Player.playerPosition[i, j].Substring(0, 5) == "black")
            {
                chess_Grid.Grid_vector[i, j].transform.GetComponent<SpriteRenderer>().color = Color.red;
            }
            if (initialise_Player.playerPosition[i, j].Substring(0, 5) == "black")
            {
                break;
            }
        }
    }
    public void check_vertically_horizantally(int row, int colm)
    {

        for (int i = row + 1; i < 8; i++)
        {
            if (initialise_Player.playerPosition[i, colm].Substring(0, 5) == "white")
            {
                break;
            }
            else if (initialise_Player.playerPosition[i, colm] == "blank")
            {
                chess_Grid.Grid_vector[i, colm].transform.GetChild(1).gameObject.SetActive(true);
            }
            else if (initialise_Player.playerPosition[i, colm].Substring(0, 5) == "black")
            {
                chess_Grid.Grid_vector[i, colm].transform.GetComponent<SpriteRenderer>().color = Color.red;
            }
            if (initialise_Player.playerPosition[i, colm].Substring(0, 5) == "black")
            {
                break;
            }
        }

        for (int i = row - 1; i >= 0; i--)
        {
            if (initialise_Player.playerPosition[i, colm].Substring(0, 5) == "white")
            {
                break;
            }
            else if (initialise_Player.playerPosition[i, colm] == "blank")
            {
                chess_Grid.Grid_vector[i, colm].transform.GetChild(1).gameObject.SetActive(true);
            }
            else if (initialise_Player.playerPosition[i, colm].Substring(0, 5) == "black")
            {
                chess_Grid.Grid_vector[i, colm].transform.GetComponent<SpriteRenderer>().color = Color.red;
            }
            if (initialise_Player.playerPosition[i, colm].Substring(0, 5) == "black")
            {
                break;
            }
        }

        for (int i = colm + 1; i < 8; i++)
        {
            if (initialise_Player.playerPosition[row, i].Substring(0, 5) == "white")
            {
                break;
            }
            else if (initialise_Player.playerPosition[row, i] == "blank")
            {
                chess_Grid.Grid_vector[row, i].transform.GetChild(1).gameObject.SetActive(true);
            }
            else if (initialise_Player.playerPosition[row, i].Substring(0, 5) == "black")
            {
                chess_Grid.Grid_vector[row, i].transform.GetComponent<SpriteRenderer>().color = Color.red;
            }
            if (initialise_Player.playerPosition[row, i].Substring(0, 5) == "black")
            {
                break;
            }
        }

        for (int i = colm - 1; i >= 0; i--)
        {
            if (initialise_Player.playerPosition[row, i].Substring(0, 5) == "white")
            {
                break;
            }
            else if (initialise_Player.playerPosition[row, i] == "blank")
            {
                chess_Grid.Grid_vector[row, i].transform.GetChild(1).gameObject.SetActive(true);
            }
            else if (initialise_Player.playerPosition[row, i].Substring(0, 5) == "black")
            {
                chess_Grid.Grid_vector[row, i].transform.GetComponent<SpriteRenderer>().color = Color.red;
            }
            if (initialise_Player.playerPosition[row, i].Substring(0, 5) == "black")
            {
                break;
            }

        }
    }
}
