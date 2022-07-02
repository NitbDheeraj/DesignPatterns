using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// The command pattern encapsulates a request as an object, 
/// thereby letting us parameterize other objects with different requests, queue or log requests, 
/// and support undoable operations.
/// </summary>
namespace CommandDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            RemotecontrolInvoker remoteControl = new RemotecontrolInvoker();

            LightOnCommand lon = new LightOnCommand();
            LightOffCommand loff = new LightOffCommand();

            StereoOnCommand son = new StereoOnCommand();
            StereoOffCommand soff = new StereoOffCommand();

            remoteControl.setCommand(0, lon, loff);
            remoteControl.setCommand(1, son, soff);

            remoteControl.onButtonWasPushed(0);
            remoteControl.offButtonWasPushed(1);

            Console.Read();
        }
    }



    public class RemotecontrolInvoker
    {
        ICommand[] onCommands, offCommands;

        public RemotecontrolInvoker()
        {
            onCommands = new ICommand[2];
            offCommands = new ICommand[2];

            ICommand noCommand = new NoCommand();
            for (int i = 0; i < 2; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
        }

        public void setCommand(int slot, ICommand onCommand, ICommand offCommand )
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void onButtonWasPushed(int slot) => onCommands[slot].Execute();

        public void offButtonWasPushed(int slot) => offCommands[slot].Execute();

    }

    // An interface for command
    public interface ICommand
    {
        void Execute();
    }

    // Light On Command
    public class LightOnCommand: ICommand
    {
        public void Execute() => Console.WriteLine("Lights are on");
    }

    // Light Off Command
    public class LightOffCommand : ICommand
    {
        public void Execute() => Console.WriteLine("Lights are off");
    }

    public class StereoOnCommand: ICommand
    {
        public void Execute() => Console.WriteLine("Stereo is on");
    }

    public class StereoOffCommand : ICommand
    {
        public void Execute() => Console.WriteLine("Stereo is off");
    }

    public class NoCommand : ICommand
    {
        public void Execute() { }
    }


}
