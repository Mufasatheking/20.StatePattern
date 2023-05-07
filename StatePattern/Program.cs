using StatePattern;

Console.WriteLine("***State Pattern Demo***\n");
//Initially TV is Off
TV tv = new TV();
Console.WriteLine("User is pressing buttons in the following sequence:");
Console.WriteLine("Off->Mute->On->On->Mute->Mute->Off\n");
//TV is already in Off state
tv.PressOffButton();
//TV is already in Off state, still pressing the Mute button
tv.PressMuteButton();
//Making the TV on
tv.PressOnButton();
//TV is already in On state, pressing On button again
tv.PressOnButton();
//Putting the TV in Mute mode
tv.PressMuteButton();
//TV is already in Mute, pressing Mute button again
tv.PressMuteButton();
//Making the TV off
tv.PressOffButton();
// Wait for user
Console.Read();