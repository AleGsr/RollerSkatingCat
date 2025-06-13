using UnityEngine;

public class JumpCommand : ICommand
{
    private PlayerManager player;

    public JumpCommand(PlayerManager player)
    {
        this.player = player;
    }

    public void Execute()
    {
        player.Spin();
    }
}
