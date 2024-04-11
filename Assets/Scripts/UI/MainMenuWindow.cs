using UnityEngine;

namespace Scripts.UI
{
    public class MainMenuWindow : BaseWindow
    {
        public void OnShowSettings()
        {
            var window = Resources.Load<GameObject>("UI/SettingsWindow");
            var canvas = FindObjectOfType<Canvas>();
            Instantiate(window, canvas.transform);
        }
        public void OnStart()
        {
            var window = Resources.Load<GameObject>("UI/ScrollsWindow");
            var canvas = FindObjectOfType<Canvas>();
            Instantiate(window, canvas.transform);
        }
    }
}