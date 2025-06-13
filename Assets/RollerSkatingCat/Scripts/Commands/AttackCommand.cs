using UnityEngine;

public class AttackCommand : ICommand
{
    private PlayerManager player;

    public AttackCommand(PlayerManager player)
    {
        this.player = player;
    }

    public void Execute()
    {
        player.Attack();
    }
}
