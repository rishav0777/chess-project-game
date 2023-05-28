using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text : MonoBehaviour
{
    public tile t;
    // Start is called before the first frame update
    void Start()
    {
        t = gameObject.transform.GetComponent<tile>();
    }

    // Update is called once per frame
    void Update()
    {
        t.tile_position(2, 3);
    }

    void function()
    {
        for(int j = 2; j < 100; j++)
        {
            int fag = 0;
            for(int l = 2; l <= j; l++)//pow
            {
                if (j % l == 0)
                {
                    fag = 1;break;
                }
            }
            if (fag==1) print("not a prime no");
            else print("prime no");
        }
    }

    void func(int n)
    {
        int ll = 1;
        for (int j = 1; j <= n; j++)
        {
            
            for(int l = 0; l < j; l++)
            {
                print(ll++);
            }
            print("/n");
        }
        
    }
    void func2(int n)
    {
        int ll = 1;
        for(int i = 1; i <= n; i++)
        {
          
            int k = ll;
            for(int j = n; j > 0; j--)
            {
                if (i >= j) print(k--);
                else print(" ");
                
            }
            ll += i+1;
        }
    }
}
