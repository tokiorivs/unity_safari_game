using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public int x; //creamos los enteros que representaran las coordenadas  en la casillo del tablero
    public int y;
    public Board board;

    public void Setup(int x_, int y_, Board board_)
    {
        x = x_;
        y = y_;
        board = board_;
    }
    // Start is called before the first frame update

}
