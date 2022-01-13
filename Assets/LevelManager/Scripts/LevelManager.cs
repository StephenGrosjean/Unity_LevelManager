using UnityEngine.SceneManagement;
public class LevelManager
{
    //Level enum
    public enum Level
    {
        Menu,
        Options,
        Game
    }

    
    //Scene names, WARNING: must be in the same order than the Level enum
    private static string[] scenesNames = {
        "Menu",
        "Options",
        "Game"
    };

    /// <summary>
    /// Load the selected level
    /// </summary>
    /// <param name="level">Level to load</param>
    public static void LoadLevel(Level level) {
        FadeScreen.instance.actionAfterFade = delegate { SceneManager.LoadScene(scenesNames[(int)level]); }; //Set the action to execute after the fade as occured
        FadeScreen.instance.FadeOut(true); //Execute the fade out
    }
}  
