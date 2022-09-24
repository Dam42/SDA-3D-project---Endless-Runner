using UnityEngine;
using TMPro;

namespace SDA.UI
{
    public class GameView : BaseView
    {
        [SerializeField] private TextMeshProUGUI timeValue;

        public void UpdateTime(int time)
        {
            timeValue.text = $"{time}";
        }
    } 
}
