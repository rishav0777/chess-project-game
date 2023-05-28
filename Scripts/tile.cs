using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tile : MonoBehaviour
{
    [SerializeField] private int row, colm;
    chess_grid chess_grid_script;
    private initialise_player initialise_Player;
    Players_function players_Function;
    ano_player_func Ano_Player_Func;

   
    

    private void Start()
    {
        chess_grid_script = GameObject.FindGameObjectWithTag("chess_grid").GetComponent<chess_grid>();
        initialise_Player = GameObject.FindGameObjectWithTag("chess").GetComponent<initialise_player>();
        players_Function=GameObject.FindGameObjectWithTag("chess_grid").GetComponent<Players_function>();
        Ano_Player_Func = GameObject.FindGameObjectWithTag("chess_grid").GetComponent<ano_player_func>();

    }

    public void tile_position(int r,int c)
    {
        row = r;
        colm = c;
    }
 
    private void OnMouseDown()
    {
        if (chess_grid_script.select_chance())
        {
            int x = initialise_Player.getWhiteX(), y = initialise_Player.getWhiteY();
            if (chess_grid_script.Grid_vector[x, y].transform.GetComponent<SpriteRenderer>().color == Color.red &&
                 !initialise_Player.playerPosition[row, colm].Substring(6).Equals("king")) { return; }

            if (initialise_Player.playerPosition[row, colm].Substring(0, 5) == "white")
            {
                chess_grid_script.decent_grid();
                transform.GetComponent<SpriteRenderer>().color = Color.green;

                if (initialise_Player.playerPosition[row, colm].Substring(0, 5) == "white") Highlight_moves_pos();
                

            }
            players_Function.select_player(row, colm);
        }
        else {
            if (initialise_Player.playerPosition[row, colm].Substring(0, 5) == "black")
            {
                int x = initialise_Player.getBlackX(), y = initialise_Player.getBlackY();
                if ( chess_grid_script.Grid_vector[x, y].transform.GetComponent<SpriteRenderer>().color == Color.red &&
                     !initialise_Player.playerPosition[row, colm].Substring(6).Equals("king")) { return; }

                chess_grid_script.decent_grid();
                transform.GetComponent<SpriteRenderer>().color = Color.green;

                if (initialise_Player.playerPosition[row, colm].Substring(0, 5) == "black") Highlight_moves_pos1();

                
            }
            Ano_Player_Func.select_player(row, colm); 
        }
    }





    public void Highlight_moves_pos()
    {
        string grid_name = "" + initialise_Player.playerPosition[row, colm].Substring(6);
        

        if (grid_name=="pawn")  players_Function.highlight_pawn(row, colm);
        else if(grid_name=="king")  players_Function.highlight_king(row, colm);
        else if(grid_name=="queen")  players_Function.highlight_queen(row, colm); 
        else if(grid_name=="bishop")  players_Function.highlight_bishop(row, colm);
        else if(grid_name=="knight")  players_Function.highlight_knight(row, colm);
        else if(grid_name=="rook")  players_Function.highlight_rook(row, colm); 

    }

    public void Highlight_moves_pos1()
    {
        string grid_name = "" + initialise_Player.playerPosition[row, colm].Substring(6);


        if (grid_name == "pawn") Ano_Player_Func.highlight_pawn(row, colm);
        else if (grid_name == "king") Ano_Player_Func.highlight_king(row, colm);
        else if (grid_name == "queen") Ano_Player_Func.highlight_queen(row, colm);
        else if (grid_name == "bishop") Ano_Player_Func.highlight_bishop(row, colm);
        else if (grid_name == "knight") Ano_Player_Func.highlight_knight(row, colm);
        else if (grid_name == "rook") Ano_Player_Func.highlight_rook(row, colm);

    }






}