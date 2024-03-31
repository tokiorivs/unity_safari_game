using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Piece : MonoBehaviour
{
    public int x;
    public int y;
    public Board board;

    Tile[,] Tiles; //este es un arraya de dos dimensiones se utlizan para colocar coordenadas guardaremos los espacios de cuadriculas
    Piece [,] pieces; // lo usaremos para guardar las piezas

    public enum type
    {
        elephant,
        giraffe,
        hippo,
        monkey,
        panda,
        parrot,
        penguin,
        pig,
        rabbit,
        snake
    };
    public type pieceType;

    public void Setup(int x_, int y_, Board board_)
    {
        x = x_;
        y = y_;
        board = board_;
    }

    public void Move(int desX, int desY)
    {
        transform.DOMove(new Vector3(desX, desY, -5f), 0.25f).SetEase(Ease.InOutCubic).onComplete =()=>
        {
            x = desX;
            y = desY;
        }; //que se mueva el elemento, de modo 
    }

    [ContextMenu("test move")]
    public void MoveTest()
    {
        Move(0, 0);
    }


}
