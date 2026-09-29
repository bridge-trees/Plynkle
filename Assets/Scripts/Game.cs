using UnityEngine;

public class Game : MonoBehaviour
{
    public UI Ui;
    private static bool isGameStarted = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // show the start screen
        isGameStarted = false;
        Ui.ShowStartScreen();
    }

    public void OnStartButtonClicked()
    {
        print("OnStartButtonClicked");
       // hide the start screen
       Ui.HideStartScreen();
       // remember that the game has started
       isGameStarted = true;
    }

    public static bool IsGameStarted()
    {
        return isGameStarted;
    }
}
