using UnityEngine;
using UnityEngine.UI;

namespace Scripts.UI.ScrollWindow
{
    [RequireComponent(typeof(Button))]
    public class ScrollWindowItem : MonoBehaviour
    {
        private Button _button;

        private void Start()
        {
            _button = GetComponent<Button>();

            _button.onClick.AddListener(OnClick);
        }
        public void OnClick()
        {
            Destroy(this.gameObject);
        }
        private void OnDestroy()
        {
            _button.onClick.RemoveListener(OnClick);
        }
    }
}