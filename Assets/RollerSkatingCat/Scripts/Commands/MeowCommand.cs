using UnityEngine;

public class MeowCommand : ICommand
{
    private PlayerManager player;

    public MeowCommand(PlayerManager player)
    {
        this.player = player;
    }

    public void Execute()
    {
        player.Meow();
    }
}
