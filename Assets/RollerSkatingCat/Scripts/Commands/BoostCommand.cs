using UnityEngine;

public class BoostCommand : ICommand
{
    private PlayerManager player;

    public BoostCommand(PlayerManager player)
    {
        this.player = player;
    }

    public void Execute()
    {
        player.Boost();
    }
}
