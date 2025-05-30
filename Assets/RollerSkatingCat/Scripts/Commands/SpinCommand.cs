using UnityEngine;

public class SpinCommand : ICommand
{

    private PlayerController player;

    public SpinCommand(PlayerController player)
    {
        this.player = player;
    }

    public void Execute()
    {
        player.Spin(-1);
    }
}
