using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initialise_player : MonoBehaviour
{
    Sprites sprites;
    chess_grid c_grid;
    public string[,] playerPosition = new string[8, 8];
    private int whitex,whitey,blackx,blacky;


    private void Awake()
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                playerPosition[i, j] = "blank";
            }
        }
        print("iniPlayer1");
    }
    
    private void Start()
    {
        print("initilize");
        sprites =GameObject.FindGameObjectWithTag("chess_grid").GetComponent<Sprites>();
        c_grid = GameObject.FindGameObjectWithTag("chess_grid").GetComponent<chess_grid>();

       
        print("iniPlayer");
    }

    public int getWhiteX()
    {
        return whitex;
    }
    public int getWhiteY()
    {
        return whitey;
    }
    public int getBlackX()
    {
        return blackx;
    }
    public int getBlackY()
    {
        return blacky;
    }
    public void setWhiteX(int val)
    {
        whitex = val ;
    }
    public void setWhiteY(int val)
    {
         whitey=val;
    }
    public void setBlackX(int val)
    {
        blackx=val;
    }
    public void setBlackY(int val)
    {
        blacky=val;
    }

    public Sprite Initialize(string p_pos)
    {
        sprites = GameObject.FindGameObjectWithTag("chess_grid").GetComponent<Sprites>();
        c_grid = GameObject.FindGameObjectWithTag("chess_grid").GetComponent<chess_grid>();
        // playerPosition[1, 0] = "white_knight";
        print("ppos " + p_pos + playerPosition[1,0]);
        //if (p_pos == "10") { print("true2"); playerPosition[1, 0] = "white_knight"; print("true1"); return sprites.white_knight(); print("true"); }
        switch (p_pos)
        {
            case "00": playerPosition[0, 0] = "white_rook"; return sprites.white_rook(); 
            case "10": playerPosition[1, 0] = "white_knight"; return sprites.white_knight();
            case "20": playerPosition[2, 0] = "white_bishop"; return sprites.white_bishop();
            case "30": playerPosition[3, 0] = "white_queen"; return sprites.white_queen();
            case "40": playerPosition[4, 0] = "white_king"; whitex = 4;whitey = 0; return sprites.white_king();
            case "50": playerPosition[5, 0] = "white_bishop"; return sprites.white_bishop();
            case "60": playerPosition[6, 0] = "white_knight"; return sprites.white_knight();
            case "70": playerPosition[7, 0] = "white_rook"; return sprites.white_rook();

            case "07": playerPosition[0, 7] = "black_rook"; return sprites.black_rook();
            case "17": playerPosition[1, 7] = "black_knight"; return sprites.black_knight();
            case "27": playerPosition[2, 7] = "black_bishop"; return sprites.black_bishop();
            case "37": playerPosition[3, 7] = "black_queen"; return sprites.black_queen();
            case "47": playerPosition[4, 7] = "black_king"; blackx = 4;blacky = 7; return sprites.black_king();
            case "57": playerPosition[5, 7] = "black_bishop"; return sprites.black_bishop();
            case "67": playerPosition[6, 7] = "black_knight"; return sprites.black_knight();
            case "77": playerPosition[7, 7] = "black_rook"; return sprites.black_rook();


            case "01": playerPosition[0, 1] = "white_pawn"; return sprites.white_pawn();
            case "11": playerPosition[1, 1] = "white_pawn"; return sprites.white_pawn();
            case "21": playerPosition[2, 1] = "white_pawn"; return sprites.white_pawn();
            case "31": playerPosition[3, 1] = "white_pawn"; return sprites.white_pawn();
            case "41": playerPosition[4, 1] = "white_pawn"; return sprites.white_pawn();
            case "51": playerPosition[5, 1] = "white_pawn"; return sprites.white_pawn();
            case "61": playerPosition[6, 1] = "white_pawn"; return sprites.white_pawn();
            case "71": playerPosition[7, 1] = "white_pawn"; return sprites.white_pawn();

            case "06": playerPosition[0, 6] = "black_pawn"; return sprites.black_pawn();
            case "16": playerPosition[1, 6] = "black_pawn"; return sprites.black_pawn();
            case "26": playerPosition[2, 6] = "black_pawn"; return sprites.black_pawn();
            case "36": playerPosition[3, 6] = "black_pawn"; return sprites.black_pawn();
            case "46": playerPosition[4, 6] = "black_pawn"; return sprites.black_pawn();
            case "56": playerPosition[5, 6] = "black_pawn"; return sprites.black_pawn();
            case "66": playerPosition[6, 6] = "black_pawn"; return sprites.black_pawn();
            case "76": playerPosition[7, 6] = "black_pawn"; return sprites.black_pawn();





            //case "44": playerPosition[4, 4] = "white_queen"; return sprites.white_queen();


        }
        return null;
    }



}
