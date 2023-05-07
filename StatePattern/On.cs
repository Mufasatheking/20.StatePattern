namespace StatePattern
{
    class On : IPossibleStates
    {
        TV tvContext;
        public On(TV context)
        {
            Console.WriteLine("TV is On now.");
            this.tvContext = context;
        }
        //Users can press any of these buttons at this state-On, Off or Mute
        //TV is On already, user is pressing On button again
        public void PressOnButton(TV context)
        {
            Console.WriteLine("You pressed On button. TV is already in On state.");
        }
        //TV is On now, user is pressing Off button
        public void PressOffButton(TV context)
        {
            Console.WriteLine("You pressed Off button. Going from On to Off state.");
            tvContext.CurrentState = new Off(context);
        }
        //TV is On now, user is pressing Mute button
        public void PressMuteButton(TV context)
        {
            Console.WriteLine("You pressed Mute button. Going from On to Mute mode.");
            tvContext.CurrentState = new Mute(context);
        }
    }
}