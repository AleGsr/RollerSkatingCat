using UnityEngine;

public class MoveCommand : ICommand
{
    private PlayerManager player;

    public MoveCommand(PlayerManager player)
    {
        this.player = player;
    }

    public void Execute()
    {
        player.Move();
    }
}
