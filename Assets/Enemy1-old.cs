using System;

public class Enemy1old : Receiver
{

    protected override void InteractWithTarget()
    {
        if (target == null) { return; }
        print("I'm going to move toward my target with tag " + target.tag + " and name " + target.name);
    }

    protected override void Transmitter_TransmissionChanged(Transmitter sender, EventArgs e)
    {
        if (sender.Transmission == "1")
        {
            print("Found a new target that is transmitting signal 1!");
            target = sender.gameObject;
        }
        else if (sender.Transmission != "1" && target == sender.gameObject)
        {
            print("My old target stopped transmitting signal 1.");
            target = null;
        }
    }
}
