namespace SDA.Loop
{
    public class GameState : BaseState
    {
        public override void Initialize()
        {
            gameController.UIController.GameView.ShowView();
        }

        public override void Tick()
        {         
            gameController.UIController.GameView.UpdateTime(gameController.TimeSystem.GetTime());
        }

        public override void FixedTick()
        {
            gameController.TimeSystem.UpdateTime();
        }

        public override void Dispose()
        {
            gameController.UIController.GameView.HideView();
        }
    } 
}
