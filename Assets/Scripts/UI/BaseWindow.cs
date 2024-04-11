using UnityEngine;

namespace Scripts.UI
{
    public class BaseWindow : MonoBehaviour
    {
        [SerializeField] GameObject _panel;

        protected virtual void Start()
        {
            Open();
        }
        public virtual void Open()
        {
            _panel.SetActive(true);
        }

        public virtual void Close()
        {
            OnCloseAnimationComplete();
        }

        public virtual void OnCloseAnimationComplete()
        {
            Destroy(gameObject);
        }
    }
}