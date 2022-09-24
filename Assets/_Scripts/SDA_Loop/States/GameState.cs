namespace SDA.Loop
{
    public class GameState : BaseState
    {
        public override void Initialize()
        {
            gameController.UIController.GameView.ShowView();
            gameController.LevelSpawner.SpawnChunks(5);
        }

        public override void Tick()
        {         
            gameController.UIController.GameView.UpdateTime(gameController.TimeSystem.GetTime());
        }

        public override void FixedTick()
        {
            gameController.TimeSystem.UpdateTime();
            gameController.PlayerController.MovePlayer();
        }

        public override void Dispose()
        {
            gameController.UIController.GameView.HideView();
        }
    } 
}
