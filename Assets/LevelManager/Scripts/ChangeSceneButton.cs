using UnityEngine;
using UnityEngine.UI;

public class ChangeSceneButton : MonoBehaviour
{
    public LevelManager.Level levelToLoad;

    private void Awake() {
        GetComponent<Button>().onClick.AddListener(delegate { LevelManager.LoadLevel(levelToLoad); });
    }
}
