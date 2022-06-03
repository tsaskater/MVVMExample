using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMTemplate.VM
{
    internal class ExampleViewModel : ViewModelBase
    {
        #region Binding
        public ICommand AddNumbers { get; private set; }
        public ICommand DontClickThis { get; private set; }
        private string _number1;
        public string Number1
        {
            get { return _number1; }
            set { Set(ref this._number1, value); }
        }
        private string _number2;
        public string Number2
        {
            get { return _number2; }
            set { Set(ref this._number2, value); }
        }
        private string _result;
        public string Result
        {
            get { return _result; }
            private set { Set(ref this._result, value); }
        }
        #endregion Binding

        private IExampleLogic _exampleLogic;
        public ExampleViewModel(IExampleLogic exampleLogic)
        {
            _exampleLogic = exampleLogic;
            if (!IsInDesignMode)
            {
                Result = "";
                AddNumbers = new RelayCommand(() => SumNumbers(), true);
                DontClickThis = new RelayCommand(() => DontClick(), true);
            }
            else
            {
                Number1 = "Number 1 goes here...";
                Number2 = "Number 2 goes here...";
                Result = "Result goes here...";
            }
        }

        #region IOC
        public ExampleViewModel()
            : this(IsInDesignModeStatic ? null : ServiceLocator.Current.GetInstance<IExampleLogic>())
        {
        }
        #endregion

        private void SumNumbers()
        {
            Result = _exampleLogic.AddNumbersFromString(Number1, Number2);
        }
        private void DontClick()
        {
            _exampleLogic.DontClick();
        }
    }
}
