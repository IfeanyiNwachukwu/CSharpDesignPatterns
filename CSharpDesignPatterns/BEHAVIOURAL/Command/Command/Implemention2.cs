using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandImplementation2
{
    /// <summary>
    /// Command Interface
    /// </summary>
    public interface ICommand
    {
        void Execute();
    }
    /// <summary>
    /// Receiver
    /// </summary>
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Light turned on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Light turned off");
        }
    }
    /// <summary>
    /// Concrete Command
    /// </summary>
    public class LightOnCommand : ICommand
    {
        private Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.TurnOn();
        }
    }
    /// <summary>
    /// ConcreteCommand
    /// </summary>
    public class LightOffCommand : ICommand
    {
        private Light light;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.TurnOff();
        }
    }
    /// <summary>
    /// Invoker
    /// </summary>
    public class RemoteControl
    {
        private ICommand command;

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void PressButton()
        {
            command.Execute();
        }
    }
}
