using UnityEngine;

public class SpinCommand : ICommand
{

    private PlayerManager player;

    public SpinCommand(PlayerManager player)
    {
        this.player = player;
    }

    public void Execute()
    {
        player.Spin();
    }
}
