namespace SmokeTest
{
    using Microsoft.Practices.Prism.ViewModel;
    using PropertyChanged;

    [AddINotifyPropertyChangedInterface]
    public class Class1 : NotificationObject
    {
        public string Property1 { get; set; }
    }
}
