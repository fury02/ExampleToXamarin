using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExampleToXamarin.View.ContentViewCustom
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UCLabelView : ContentView
    {
        // BindableProperty
        public static readonly BindableProperty PropertyRandomPublic = BindableProperty.Create(
                propertyName: nameof(PropertyRandomPublic),
                returnType: typeof(string),
                declaringType: typeof(UCLabelView),
                defaultValue: default(string),
                propertyChanged: HandleTextPropertyChanged,
                defaultBindingMode: BindingMode.TwoWay);

        public string RandomPublic
        {
            get => (string)GetValue(PropertyRandomPublic);
            set => SetValue(PropertyRandomPublic, value);
        }

        // Handler
        private static void HandleTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (UCLabelView)bindable;
            if (control != null)
            {
                control.LabelRandomPublic.Text = (string)newValue;
            }
        }

        public UCLabelView()
        {
            InitializeComponent();
        }
    }
}