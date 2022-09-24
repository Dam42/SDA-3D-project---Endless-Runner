using UnityEngine;
using SDA.Data;

namespace SDA.Loop
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] GameDataStorage gameDataStorage;
        public GameDataStorage GameDataStorage => gameDataStorage;

        private BaseState currentState;

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
            currentState?.Dispose();
        }

        private void ChangeState(BaseState newState)
        {
            currentState?.Dispose();
            currentState = newState;
            currentState.BeforeInitizalize(this);
            currentState.Initialize();
        }
    } 
}
