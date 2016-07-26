using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    class Program
    {/// <summary>
     /// MainApp startup class for Structural
     /// State Design Pattern.
     /// </summary>
        // <summary>
        /// Entry point into console application.
        /// </summary>
        public static void Main()
        {
            // Setup context in a state
            Context c = new Context(new ConcreteStateA());

            // Issue requests, which toggles state
            c.Request();
            c.Request();
            c.Request();
            c.Request();
            c.Request();
            c.Request();
            // Wait for user
            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'State' abstract class
    /// </summary>
    abstract class State
    {
        public abstract void Handle(Context context);
    }

    /// <summary>
    /// A 'ConcreteState' class
    /// </summary>
    class ConcreteStateA : State
    {
        static int i = 0;
        public override void Handle(Context context)
        {
            if (i++ >= 1)
            {
                context.State = new ConcreteStateB();

            }
            else
                context.State = this;

        }
    }

    /// <summary>
    /// A 'ConcreteState' class
    /// </summary>
    class ConcreteStateB : State
    {
      
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateC();

           
        }
    }
    class ConcreteStateC : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }

    /// <summary>
    /// The 'Context' class
    /// </summary>
    class Context
    {
        private State _state;

        // Constructor
        public Context(State state)
        {
            this.State = state;
        }

        // Gets or sets the state
        public State State
        {
            get { return _state; }
            set
            {
                _state = value;
                Console.WriteLine("State: " +
                  _state.GetType().Name);
            }
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }

}
