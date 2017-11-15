using System;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinAdvanced.Behaviors;

namespace XamarinAdvanced.Behaviors
{
    public class ListViewItemTappedBehavior : BehaviorBase<ListView>
    {
        public static readonly BindableProperty CommandProperty = BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(ListViewItemTappedBehavior));

        public ICommand Command
        {
            get => (ICommand)base.GetValue(ListViewItemTappedBehavior.CommandProperty);
            set => base.SetValue(ListViewItemTappedBehavior.CommandProperty, value);
        }

        protected override void OnAttachedTo(ListView bindable)
        {
            base.OnAttachedTo(bindable);
            (bindable as ListView).ItemTapped += ListView_ItemTapped;
        }

        protected override void OnDetachingFrom(ListView bindable)
        {
            (bindable as ListView).ItemTapped -= ListView_ItemTapped;
            base.OnDetachingFrom(bindable);
        }

        void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            (sender as ListView).SelectedItem = null;
            if (Command == null)
            {
                return;
            }
            if (Command.CanExecute(e.Item))
            {
                Command.Execute(e.Item);
            }
        }
    }
}
