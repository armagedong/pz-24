using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace salon.Admin.AdminControl
{
    public partial class ServisecCombo : UserControl
    {
        public event EventHandler<List<ServicesEnt>> ItemAdded;

        public ServisecCombo()
        {
            InitializeComponent();
            foreach (var i in Serialize.ShowUser())
            {
                ComboUsers.Items.Add(i.FIO);
            }

            ItemAdded += OnItemAdded; // Подписываемся на событие один раз
        }

        private void ComboUsers_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboUsers.SelectedIndex >= 0)
            {
                GridUsers.ItemsSource = Serialize.ShowUser()[ComboUsers.SelectedIndex].RecordServices;
            }
        }

        private void Save_OnClick(object sender, RoutedEventArgs e)
        {
            if (GridUsers != null && ComboUsers != null)
            {
                Serialize.completeServiceUser(ComboUsers.SelectedIndex, GridUsers.SelectedIndex);
                ItemAdded?.Invoke(this, Serialize.ShowUser()[ComboUsers.SelectedIndex].RecordServices);
            }
        }

        private void OnItemAdded(object sender, List<ServicesEnt> newItem)
        {
            GridUsers.ItemsSource = newItem;
        }

        private void GridUsers_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Можно оставить пустым, если не требуется дополнительных действий при изменении выбранного элемента
        }
    }
}