using UnityEngine;

namespace SDA.Loop
{
    public class MenuState : BaseState
    {
        public override void Initialize()
        {
            gameController.UIController.MenuView.ShowView();
        }

        public override void Tick()
        {
            if (Input.GetKeyDown(KeyCode.Space)) gameController.ChangeState(new GameState()); 
        }

        public override void Dispose()
        {
            gameController.UIController.MenuView.HideView();
        }
    } 
}
