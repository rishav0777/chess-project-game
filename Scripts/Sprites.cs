using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprites : MonoBehaviour
{
     public Sprite[] white_player = new Sprite[6];
     public Sprite[] black_player = new Sprite[6];
    public Sprite white_knight()
    {
        return white_player[0];
    }
    public Sprite white_bishop()
    {
        return white_player[1];
    }
    public Sprite white_queen()
    {
        return white_player[2];
    }
    public Sprite white_king()
    {
        return white_player[3];
    }
    public Sprite white_rook()
    {
        return white_player[4];
    }
    public Sprite white_pawn()
    {
        return white_player[5];
    }









    public Sprite black_knight()
    {
        return black_player[0];
    }
    public Sprite black_bishop()
    {
        return black_player[1];
    }
    public Sprite black_queen()
    {
        return black_player[2];
    }
    public Sprite black_king()
    {
        return black_player[3];
    }
    public Sprite black_rook()
    {
        return black_player[4];
    }
    public Sprite black_pawn()
    {
        return black_player[5];
    }
}
