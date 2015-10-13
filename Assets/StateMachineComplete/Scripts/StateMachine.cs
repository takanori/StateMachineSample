namespace StateMachineSample
{
    /// <summary>
    /// 
    /// 有限状態機械（ステートマシン）
    ///
    /// </summary>
    public class StateMachine<T>
    {
        private State<T> currentState;
    
        public StateMachine()
        {
            currentState = null;
        }
    
        public State<T> CurrentState
        {
            get { return currentState; }
        }
    
        public void ChangeState(State<T> state)
        {
            if (currentState != null)
            {
                currentState.Exit();
            }
            currentState = state;
            currentState.Enter();
        }
    
        public void Update()
        {
            if (currentState != null)
            {
                currentState.Execute();
            }
        }
    }
}