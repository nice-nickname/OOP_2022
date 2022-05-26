namespace lab4.viewmodel
{
    using System;
    using System.Collections.ObjectModel;
    using System.Windows.Input;

    public class ButtonCommand : ICommand
    {
        private readonly Action<object> _o;
        public ButtonCommand(Action<object> o)
        {
            _o = o;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _o(parameter);
        }

        public event EventHandler CanExecuteChanged;
    }

    public class AviaryViewModel
    {
        private int index = 0;
        public AviaryViewModel(OfType type)
        {
            
            Vet = new VetEmployee();
            Employee = new DefaultEmployee();
            Aviaries = new ObservableCollection<Aviary>();
            AddAviaryCommand = new ButtonCommand(o =>
                                                 {
                                                     var s = SelectedType.Split(' ')[1][0];
                                                     if (s == 'О')
                                                     {
                                                         Aviaries.Add(new Aviary(OfType.Open, index++));
                                                     }
                                                     else
                                                     {
                                                         Aviaries.Add(new Aviary(OfType.Closed, index++));
                                                     }
                                                 });
        }

        public EmployeeBase Vet { get; set; }
        public EmployeeBase Employee { get; set; }

        public ObservableCollection<Aviary> Aviaries { get; set; }

        public ButtonCommand AddAviaryCommand { get; set; }
        public string SelectedType { get; set; }
    }
}
