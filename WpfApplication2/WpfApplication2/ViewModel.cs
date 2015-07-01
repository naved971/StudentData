using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Windows;

namespace WpfApplication2
{
    public class ViewModel
    {

        public ViewModel()
        {
            Model1 = GetValue();
        }

        private ObservableCollection<int> model;
        public ObservableCollection<Int32> Model1
        {
            get { return model; }

            set
            {
                model = GetValue();
            }
        }

        private ObservableCollection<int> GetValue()
        {
            int count = 10;
            ObservableCollection<int> m = new ObservableCollection<int>();
            if (DesignerProperties.GetIsInDesignMode(new DependencyObject()))
            {
                count = 5;
            }
            for (int i = 1; i <= count; i++)
            {
                m.Add(i + 1);
            }
            return m;
        }




    }
}
