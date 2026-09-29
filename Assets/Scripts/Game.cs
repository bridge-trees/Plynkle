using UnityEngine;

public class Game : MonoBehaviour
{
    public CanvasGroup CanvasGroup;
    private static bool isGameStarted = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // show the start screen
        isGameStarted = false;
        CanvasGroupDisplayer.Show(CanvasGroup);
    }

    public void OnStartButtonClicked()
    {
        print("OnStartButtonClicked");
       // hide the start screen
       CanvasGroupDisplayer.Hide(CanvasGroup);
       // remember that the game has started
       isGameStarted = true;
    }

    public static bool IsGameStarted()
    {
        return isGameStarted;
    }
}
