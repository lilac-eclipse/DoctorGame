using DoctorGame.globals;
using Godot;

namespace DoctorGame.menus.main_menu;

public partial class MainMenu : CanvasLayer
{
    private Button _startButton;
    private Button _exitButton;
    private Button _loadButton;
    
    public override void _Ready()
    {
        _startButton = GetNode<Button>("%StartButton");
        _loadButton = GetNode<Button>("%LoadButton");
        _exitButton = GetNode<Button>("%ExitButton");

        _startButton.Pressed += OnStartButtonPressed;
        _loadButton.Pressed += OnLoadButtonPressed;
        _exitButton.Pressed += OnExitButtonPressed;

        _loadButton.Disabled = true;
    }
    
    private void OnStartButtonPressed()
    {
        Events.Instance.EmitSignal(Events.SignalName.LifecycleStartGameRequested);
    }
    
    private void OnLoadButtonPressed()
    {
        
    }
    
    private void OnExitButtonPressed()
    {
        GetTree().Quit();
    }
}