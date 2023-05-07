namespace StatePattern
{
    public class TV
    {
        private IPossibleStates currentState;
        public IPossibleStates CurrentState
        {
            //get;set;//Not working as expected
            get
            {
                return currentState;
            }
            /*Usually this value will be set by the class that
              implements the interface "IPossibleStates"*/
            set
            {
                currentState = value;
            }
        }
        public TV()
        {
            this.currentState = new Off(this);
        }
        public void PressOffButton()
        {
            currentState.PressOffButton(this);//Delegating the state
        }
        public void PressOnButton()
        {
            currentState.PressOnButton(this);//Delegating the state
        }
        public void PressMuteButton()
        {
            currentState.PressMuteButton(this);//Delegating the state
        }
    }
}