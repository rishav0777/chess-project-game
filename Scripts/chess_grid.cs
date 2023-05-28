using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chess_grid : MonoBehaviour
{
    [SerializeField] private GameObject tile_object;
    [SerializeField] private GameObject grid_container;
    [SerializeField] private GameObject player_sprite;

    public GameObject[,] Grid_vector = new GameObject[8, 8];


    private initialise_player initialise_Player;

    [SerializeField] private AudioSource audio1,audio2,audio3;
    

    bool chance = true;


   
    // Start is called before the first frame update
    void Start()
    {
       
        initialise_Player = GameObject.FindGameObjectWithTag("chess").transform.GetComponent<initialise_player>();
        make_grid();
        
     
    }

    public void playAudioMove()
    {
        audio1.Play();
    }
    public void playAudioTake()
    {
        audio2.Play();
    }
    public void playAudiocheck()
    {
        audio3.Play();
    }



    public void make_grid()
    {
        for(int i = 0; i < 8; i++)
        {
            for(int j = 0; j < 8; j++)
            {
                var grid = Instantiate(tile_object, new Vector2(i, j), Quaternion.identity);
                grid.name = "grid" + i + j;
                grid.transform.parent = grid_container.transform;
                color_grid(i, j,grid);
                // bool Tile_color = (i % 2 == 0 && j % 2 == 0) || (i % 2 != 0 && j % 2 != 0);
                // grid.GetComponent<SpriteRenderer>().color = Tile_color ? Color.blue : Color.white;
                print("chessgrid");

                try
                {
                    string pla = "" + i + j;print(pla);
                    Sprite grid_sprite = initialise_Player.Initialize(pla);print(grid_sprite+"chess griddd");
                    if (grid_sprite != null)
                    {
                        grid.transform.GetChild(0).gameObject.SetActive(true);
                        grid.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = grid_sprite;
                    }
                    else
                    {
                        grid.transform.GetChild(0).gameObject.SetActive(false);
                    }
                    

                    grid.GetComponent<tile>().tile_position(i, j);
                    Grid_vector[i, j] = grid;
                }
                catch (System.Exception e)
                {
                   System.Console.WriteLine(e.ToString());
                    print(e);
                }

               
                
            }
        }
    }


    public void color_grid(int i,int j,GameObject grid)
    {
        bool Tile_color = (i % 2 == 0 && j % 2 == 0) || (i % 2 != 0 && j % 2 != 0);
        grid.GetComponent<SpriteRenderer>().color = Tile_color ? Color.blue : Color.white;
    }


    public void decent_grid()
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                int rr = initialise_Player.getWhiteX(), cc = initialise_Player.getWhiteY();
                int rr1 = initialise_Player.getBlackX(), cc1 = initialise_Player.getBlackY();
                if (Grid_vector[rr, cc].transform.GetComponent<SpriteRenderer>().color == Color.red && (i==rr && j==cc))
                 {
                    
                 }
                else if (Grid_vector[rr1, cc1].transform.GetComponent<SpriteRenderer>().color == Color.red && (i == rr1 && j == cc1))
                 {
                   
                 }
                else
                {
                    bool Tile_color = (i % 2 == 0 && j % 2 == 0) || (i % 2 != 0 && j % 2 != 0);
                    Grid_vector[i, j].GetComponent<SpriteRenderer>().color = Tile_color ? Color.blue : Color.white;
                    Grid_vector[i, j].transform.GetChild(1).gameObject.SetActive(false);
                }
            }
        }
    }


    public bool select_chance()
    {
        return chance;
    }
    public void change_chance()
    {
        chance = !chance;
    }
}