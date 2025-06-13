using UnityEngine;

public class ShootCommand : ICommand
{
    private PlayerManager player;

    public ShootCommand(PlayerManager player)
    {
        this.player = player;
    }

    public void Execute()
    {
        player.Shoot();
    }
}
