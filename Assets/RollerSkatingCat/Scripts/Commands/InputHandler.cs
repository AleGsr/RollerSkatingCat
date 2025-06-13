using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public PlayerManager player;
    private CommandInvoker invoker = new CommandInvoker();

    private ICommand moveCommand;
    private ICommand jumpCommand;
    private ICommand shootCommand;
    private ICommand attackCommand;
    private ICommand spinCommand;
    private ICommand meowCommand;
    private ICommand boostCommand;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        moveCommand = new MoveCommand(player);
        jumpCommand = new JumpCommand(player);
        shootCommand = new ShootCommand(player);
        attackCommand = new AttackCommand(player);
        spinCommand = new SpinCommand(player);
        meowCommand = new MeowCommand(player);
        boostCommand = new BoostCommand(player);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            invoker.ExecuteCommand(moveCommand);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            invoker.ExecuteCommand(shootCommand);
        }
        if (Input.GetMouseButton(0))
        {
            invoker.ExecuteCommand(attackCommand);
        }
        if (Input.GetKey(KeyCode.F))
        {
            invoker.ExecuteCommand(spinCommand);
        }
        if (Input.GetKey(KeyCode.C))
        {
            invoker.ExecuteCommand(meowCommand);
        }
        if (Input.GetKey(KeyCode.E))
        {
            invoker.ExecuteCommand(boostCommand);
        }
    }
}
