using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public TMP_Text ScoreText;
    public CanvasGroup CanvasGroup;
    public CanvasGroup GuiCanvasGroup;
    
    public void ShowScore(int score)
    {
        ScoreText.text = score.ToString();
    }

    public void ShowStartScreen()
    {
        CanvasGroupDisplayer.Show(CanvasGroup);
    }

    public void HideStartScreen()
    {
        CanvasGroupDisplayer.Hide(CanvasGroup);
    }
    
    public void ShowGui()
    {
        CanvasGroupDisplayer.Show(GuiCanvasGroup);
    }

    public void HideGui()
    {
        CanvasGroupDisplayer.Hide(GuiCanvasGroup);
    }
    
    
    
}
