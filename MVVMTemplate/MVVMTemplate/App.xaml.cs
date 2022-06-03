using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using Logic;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMTemplate
{
    internal class MyIoc : SimpleIoc, IServiceLocator
    {
        public static MyIoc Instance { get; private set; } = new MyIoc();
    }
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            ServiceLocator.SetLocatorProvider(() => MyIoc.Instance);
            MyIoc.Instance.Register<IExampleLogic, ExampleLogic>();
        }
    }
}
