using UnityEngine;

namespace SDA.UI
{
    public class UIController : MonoBehaviour
    {
        [SerializeField] private MenuView menuView;
        [SerializeField] private GameView gameView;

        public MenuView MenuView => menuView;
        public GameView GameView => gameView;
    } 
}
