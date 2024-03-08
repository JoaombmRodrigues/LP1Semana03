using System;

namespace RPS
{
    [Flags]
    enum GameStatus
    {
        Draw = 0,
        Player1Wins = 1,
        Player2Wins = 2
    };
}