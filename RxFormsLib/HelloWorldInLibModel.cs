using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using ReactiveUI;
using System.Reactive;
using System.Threading.Tasks;

namespace RxFormsLib
{
    public class HelloWorldInLibModel : ReactiveUI.ReactiveObject
    {
        public HelloWorldInLibModel()
        {
            //The is line causes: 
            //  System.TypeInitializationException : The type initializer for 'ReactiveUI.RxApp' threw an exception.
            //      ---- > System.TypeInitializationException : The type initializer for 'Splat.ModeDetector' threw an exception.
            //      ---- > System.IO.FileNotFoundException : Could not load file or assembly 'System.Core, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e' or one of its dependencies.
            //this.Say = ReactiveCommand.CreateAsyncTask<Unit>(x => Task.FromResult(Unit.Default));
        }

        public IReactiveCommand Say { get; set; }
    }
}

