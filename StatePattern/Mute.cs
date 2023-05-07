namespace StatePattern
{
    class Mute : IPossibleStates
    {
        TV tvContext;
        public Mute(TV context)
        {
            Console.WriteLine("TV is in Mute mode now.");
            this.tvContext = context;
        }
        //Users can press any of these buttons at this state-On, Off or Mute
        //TV is in mute, user is pressing On button
        public void PressOnButton(TV context)
        {
            Console.WriteLine("You pressed On button. Going from Mute mode to On state.");
            tvContext.CurrentState = new On(context);
        }
        //TV is in mute, user is pressing Off button
        public void PressOffButton(TV context)
        {
            Console.WriteLine("You pressed Off button. Going to Mute mode to Off state.");
            tvContext.CurrentState = new Off(context);
        }
        //TV is in mute already, user is pressing mute button again
        public void PressMuteButton(TV context)
        {
            Console.WriteLine(" You pressed Mute button. TV is already in Mute mode.");
        }
    }
}