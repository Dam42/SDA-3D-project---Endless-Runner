namespace SDA.Loop
{
    public class BaseState
    {
        protected GameController gameController;

        public virtual void BeforeInitizalize(GameController gameController) 
        {
            this.gameController = gameController;
        }

        public virtual void Initialize() { }

        public virtual void Tick() { }

        public virtual void FixedTick() { }

        public virtual void LastTick() { }

        public virtual void Dispose() { }
    } 
}
