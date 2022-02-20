using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using Madelinette.Common;

public class GameManager : MonoBehaviour
{
    private CheckForEmpty cfe;
    private Game game;

    [SerializeField]
    private Transform[] boardPositions;
    private bool loop;
    public ConsoleKeyInfo input;

    // Start is called before the first frame update
    void Start()
    {
        cfe = new CheckForEmpty();
        game = new Game();
        game.BoardSpots = new int[7] { 1, 2, 2, 0, 1, 1, 2 };
        loop = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            input = new ConsoleKeyInfo('1', ConsoleKey.D1, false, false, false);
        if (Input.GetKeyDown(KeyCode.Alpha2))
            input = new ConsoleKeyInfo('2', ConsoleKey.D2, false, false, false);
        if (Input.GetKeyDown(KeyCode.Alpha3))
            input = new ConsoleKeyInfo('3', ConsoleKey.D3, false, false, false);
        if (Input.GetKeyDown(KeyCode.Alpha4))
            input = new ConsoleKeyInfo('4', ConsoleKey.D4, false, false, false);
        if (Input.GetKeyDown(KeyCode.Alpha5))
            input = new ConsoleKeyInfo('5', ConsoleKey.D5, false, false, false);
        if (Input.GetKeyDown(KeyCode.Alpha6))
            input = new ConsoleKeyInfo('6', ConsoleKey.D6, false, false, false);
        if (Input.GetKeyDown(KeyCode.Alpha7))
            input = new ConsoleKeyInfo('7', ConsoleKey.D7, false, false, false);
        if (cfe.CheckForEmptySpot(input)) { Debug.Log("true"); }
        if (cfe.CheckForEmptySpot(input) == false) { Debug.Log("false"); }
        else Debug.Log("idk");
    }
}
