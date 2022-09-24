using UnityEngine;
using SDA.Data;
using SDA.UI;
using SDA.Score;

namespace SDA.Loop
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] GameDataStorage gameDataStorage;
        [SerializeField] UIController uiController;
        private TimeSystem timeSystem;
        public GameDataStorage GameDataStorage => gameDataStorage;
        public UIController UIController => uiController;
        public TimeSystem TimeSystem => timeSystem;
        
        private BaseState currentState;

        private void Awake()
        {
            timeSystem = new TimeSystem();
        }

        private void Start()
        {
            //System Initializers

            //GameStart
            ChangeState(new MenuState());
        }

        private void Update()
        {
            currentState?.Tick();
        }

        private void FixedUpdate()
        {
            currentState?.FixedTick();
        }

        private void LateUpdate()
        {
            currentState?.LastTick();
        }

        private void OnDestroy()
        {
           // currentState?.Dispose();
        }

        public void ChangeState(BaseState newState)
        {
            currentState?.Dispose();
            currentState = newState;
            currentState.BeforeInitizalize(this);
            currentState.Initialize();
        }
    } 
}
