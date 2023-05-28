using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkMate : MonoBehaviour
{

    chess_grid chess_Grid;
    private initialise_player initialise_Player;
    Players_function players_Function;
    ano_player_func Ano_Player_Func;

    ArrayList rowArray = new ArrayList();
    ArrayList colArray = new ArrayList();

    private bool trackFlag=false;
    bool fl = false;


    // Start is called before the first frame update
    void Start()
    {
        chess_Grid = GameObject.FindGameObjectWithTag("chess_grid").GetComponent<chess_grid>();
        initialise_Player = GameObject.FindGameObjectWithTag("chess").GetComponent<initialise_player>();
        players_Function = GameObject.FindGameObjectWithTag("chess_grid").GetComponent<Players_function>();
        Ano_Player_Func = GameObject.FindGameObjectWithTag("chess_grid").GetComponent<ano_player_func>();
    }


    public int getrowArrayElement(int i)
    {
        return (int)rowArray[i];
    }
    public int getcolmArrayElement(int i)
    {
        return (int)colArray[i];
    }



    public void checkForwhiteMate(string s)
    {
        print(s);
        check_digonally(initialise_Player.getWhiteX(), initialise_Player.getWhiteY(),s);
        check_vertically_horizantally(initialise_Player.getWhiteX(), initialise_Player.getWhiteY(),s);
        
        print(trackFlag);
       if(trackFlag)
        {
            chess_Grid.playAudiocheck();
            trackFlag = false;
        }
    }
    public void checkForblackMate(string s)
    {
        print(s);
        check_digonally(initialise_Player.getBlackX(), initialise_Player.getBlackY(), s);
        check_vertically_horizantally(initialise_Player.getBlackX(), initialise_Player.getBlackY(), s);
        print(trackFlag);
        if (trackFlag)
        {
            chess_Grid.playAudiocheck();
            trackFlag = false;
        }
    }



    public void check_digonally(int row, int colm,string player)
    {
        int i, j;

        // string player = initialise_Player.playerPosition[row, colm].Substring(0, 5);
        int flag = 0;fl = false;
        print(player + row + " "+colm);
        for ( i = row + 1, j = colm + 1; i < 8 && j < 8; i++, j++)
        {
            if (initialise_Player.playerPosition[i, j].Substring(0, 5).Equals(player))
            {
                break;
            }
            else if (initialise_Player.playerPosition[i, j] == "blank")
            {
                flag = 1; continue;
            }
            else if (!initialise_Player.playerPosition[i, j].Substring(0, 5).Equals(player))
            {
                if (initialise_Player.playerPosition[i, j].Substring(6) == "bishop" ||
                    initialise_Player.playerPosition[i, j].Substring(6) == "queen" ||
                    (initialise_Player.playerPosition[i, j].Substring(6) == "pawn" && flag==0))
                {
                    print("1");
                    trackFlag = true;
                    fl = true;
                    chess_Grid.Grid_vector[row, colm].transform.GetComponent<SpriteRenderer>().color = Color.red;
                    break;
                }
                
            }
            if (!initialise_Player.playerPosition[i, j].Substring(0, 5).Equals(player))
            {
                break;
            }
        }

        if (fl == true)
        {
            for (i = i - 1, j = j - 1; i > row && j > colm; i--, j--)
            {
                rowArray.Add(i); colArray.Add(j);
                return;
            }
        }





        flag = 0;fl = false;
        for ( i = row - 1, j = colm - 1; i >= 0 && j >= 0; i--, j--)
        {
            print(initialise_Player.playerPosition[i, j].Substring(0, 5).Equals(player)+"yy");
            if (initialise_Player.playerPosition[i, j].Substring(0, 5).Equals(player))
            {
                break;
            }
            else if (initialise_Player.playerPosition[i, j] == "blank")
            {
                flag = 1; continue;
            }
            else if (!initialise_Player.playerPosition[i, j].Substring(0, 5).Equals(player))
            {
                if (initialise_Player.playerPosition[i, j].Substring(6) == "bishop" ||
                   initialise_Player.playerPosition[i, j].Substring(6) == "queen" ||
                   (initialise_Player.playerPosition[i, j].Substring(6) == "pawn" && flag == 0))
                {
                   
                    chess_Grid.Grid_vector[row, colm].transform.GetComponent<SpriteRenderer>().color = Color.red;
                    print("2"+i+" "+j);
                    fl = true;
                    trackFlag = true;
                    break; ;
                }
            }
            if (!initialise_Player.playerPosition[i, j].Substring(0, 5).Equals(player))
            {
                break;
            }
        }

        if (fl == true)
        {
            for (i = i + 1, j = j + 1; i < row && j < colm; i++, j++)
            {
                rowArray.Add(i); colArray.Add(j);
                return;
            }
        }




        flag = 0;fl = false;
        for ( i = row + 1, j = colm - 1; i < 8 && j >= 0; i++, j--)
        {
            if (initialise_Player.playerPosition[i, j].Substring(0, 5).Equals(player))
            {
                break;
            }
            else if (initialise_Player.playerPosition[i, j] == "blank")
            {
                flag = 1; continue;
            }
            else if (!initialise_Player.playerPosition[i, j].Substring(0, 5).Equals(player))
            {
                if (initialise_Player.playerPosition[i, j].Substring(6) == "bishop" ||
                    initialise_Player.playerPosition[i, j].Substring(6) == "queen" ||
                    (initialise_Player.playerPosition[i, j].Substring(6) == "pawn" && flag == 0))
                {
                    print("3");
                    trackFlag = true;
                    fl = true;
                    chess_Grid.Grid_vector[row, colm].transform.GetComponent<SpriteRenderer>().color = Color.red;
                    break;
                }
            }
            if (!initialise_Player.playerPosition[i, j].Substring(0, 5).Equals(player))
            {
                break;
            }
        }

        if (fl == true)
        {
            for (i = i - 1, j = j + 1; i > row && j < colm; i--, j++)
            {
                rowArray.Add(i); colArray.Add(j);
                return;
            }
        }





        flag = 0;fl = false;
        for ( i = row - 1, j = colm + 1; i >= 0 && j < 8; i--, j++)
        {
            if (initialise_Player.playerPosition[i, j].Substring(0, 5).Equals(player))
            {
                break;
            }
            else if (initialise_Player.playerPosition[i, j] == "blank")
            {
                flag = 1; continue;
            }
            else if (!initialise_Player.playerPosition[i, j].Substring(0, 5).Equals(player))
            {
                if (initialise_Player.playerPosition[i, j].Substring(6) == "bishop" ||
                   initialise_Player.playerPosition[i, j].Substring(6) == "queen" ||
                   (initialise_Player.playerPosition[i, j].Substring(6) == "pawn" && flag == 0))
                {
                    print("4");
                    fl = true;
                    trackFlag = true;
                    chess_Grid.Grid_vector[row, colm].transform.GetComponent<SpriteRenderer>().color = Color.red;
                   break;
                }
            }
            if (!initialise_Player.playerPosition[i, j].Substring(0, 5).Equals(player))
            {
                break;
            }

        }

        if (fl == true)
        {
            for (i = i + 1, j = j - 1; i < row && j > colm; i++, j--)
            {
                rowArray.Add(i); colArray.Add(j);
                return;
            }
        }

    }
    public void check_vertically_horizantally(int row, int colm,string player)
    {
        int i, j;fl = false;
        //string player = "" + initialise_Player.playerPosition[row, colm].Substring(0, 5);
        for ( i = row + 1; i < 8; i++)
        {
            if (initialise_Player.playerPosition[i, colm].Substring(0, 5).Equals(player))
            {
                break;
            }
            else if (initialise_Player.playerPosition[i, colm] == "blank")
            {
                continue;
            }
            else if (!initialise_Player.playerPosition[i, colm].Substring(0, 5).Equals(player))
            {
                if (initialise_Player.playerPosition[i, colm].Substring(6) == "queen" ||
                    initialise_Player.playerPosition[i, colm].Substring(6) == "rook")
                {
                    print("5");
                    trackFlag = true;fl = true;
                    chess_Grid.Grid_vector[row, colm].transform.GetComponent<SpriteRenderer>().color = Color.red;
                    break; 
                }
            }
            if (!initialise_Player.playerPosition[i, colm].Substring(0, 5).Equals(player))
            {
                break;
            }
        }

        if (fl == true)
        {
            for (i = i - 1; i > row; i--)
            {
                rowArray.Add(i);colArray.Add(colm);
                return;
            }
        }


        fl = false;
        for ( i = row - 1; i >= 0; i--)
        {
            if (initialise_Player.playerPosition[i, colm].Substring(0, 5).Equals(player))
            {
                break;
            }
            else if (initialise_Player.playerPosition[i, colm] == "blank")
            {
                continue;
            }
            else if (!initialise_Player.playerPosition[i, colm].Substring(0, 5).Equals(player))
            {
                if (initialise_Player.playerPosition[i, colm].Substring(6) == "queen" ||
                    initialise_Player.playerPosition[i, colm].Substring(6) == "rook")
                {
                    print("6");
                    trackFlag = true;fl = true;
                    chess_Grid.Grid_vector[row, colm].transform.GetComponent<SpriteRenderer>().color = Color.red;
                    break; 
                }
            }
            if (!initialise_Player.playerPosition[i, colm].Substring(0, 5).Equals(player))
            {
                break;
            }
        }

        if (fl == true)
        {
            for (i = i + 1; i < row; i++)
            {
                rowArray.Add(i); colArray.Add(colm);
                return;
            }
        }



        fl = false;
        for ( i = colm + 1; i < 8; i++)
        {
            if (initialise_Player.playerPosition[row, i].Substring(0, 5).Equals(player))
            {
                break;
            }
            else if (initialise_Player.playerPosition[row, i] == "blank")
            {
                continue;
            }
            else if (!initialise_Player.playerPosition[row, i].Substring(0, 5).Equals(player))
            {
                if (initialise_Player.playerPosition[row,i].Substring(6) == "queen" ||
                    initialise_Player.playerPosition[row, i].Substring(6) == "rook")
                {
                    print("7");
                    trackFlag = true;fl = true;
                    chess_Grid.Grid_vector[row, colm].transform.GetComponent<SpriteRenderer>().color = Color.red;
                    break;
                }
            }
            if (!initialise_Player.playerPosition[row, i].Substring(0, 5).Equals(player))
            {
                break;
            }
        }

        if (fl == true)
        {
            for (i = i - 1; i > row; i--)
            {
                rowArray.Add(row); colArray.Add(i);
                return;
            }
        }





        fl = false;
        for ( i = colm - 1; i >= 0; i--)
        {
            if (initialise_Player.playerPosition[row, i].Substring(0, 5).Equals(player))
            {
                break;
            }
            else if (initialise_Player.playerPosition[row, i] == "blank")
            {
                continue;
            }
            else if (!initialise_Player.playerPosition[row, i].Substring(0, 5).Equals(player))
            {
                if (initialise_Player.playerPosition[row, i].Substring(6) == "queen" ||
                    initialise_Player.playerPosition[row, i].Substring(6) == "rook")
                {
                    print("8");
                    trackFlag = true;fl = true;
                    chess_Grid.Grid_vector[row, colm].transform.GetComponent<SpriteRenderer>().color = Color.red;
                    break ;
                }
            }
            if (!initialise_Player.playerPosition[row, i].Substring(0, 5).Equals(player))
            {
                break;
            }

        }

        if (fl == true)
        {
            for (i = i + 1; i < row; i++)
            {
                rowArray.Add(row); colArray.Add(i);
                return;
            }
        }
    }
}
