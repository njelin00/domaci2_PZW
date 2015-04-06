using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace dr2_PZW.Controls
{
    /// <summary>
    /// Interaction logic for User.xaml
    /// </summary>
    public partial class User : UserControl
    {
        public User()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            this.DeleteIcon.MouseDown += (obj, eventHandler) => RaiseDeleteEvent();
            this.EditIcon.MouseDown += (obj, eventHandler) => RaiseEditEvent();

        }

        public static readonly RoutedEvent DeleteEvent = EventManager.RegisterRoutedEvent
                 (
                    "Delete",
                     RoutingStrategy.Bubble,
                     typeof(RoutedEventHandler),
                     typeof(User)
                 );

        public event RoutedEventHandler Delete
        {
            add { AddHandler(DeleteEvent, value); }
            remove { RemoveHandler(DeleteEvent, value); }
        }

        void RaiseDeleteEvent()
        {
            RoutedEventArgs newEventArgs = new RoutedEventArgs(User.DeleteEvent);
            RaiseEvent(newEventArgs);
        }


        public static readonly RoutedEvent EditEvent = EventManager.RegisterRoutedEvent
                 (
                    "Edit",
                     RoutingStrategy.Bubble,
                     typeof(RoutedEventHandler),
                     typeof(User)
                 );

        public event RoutedEventHandler Edit
        {
            add { AddHandler(EditEvent, value); }
            remove { RemoveHandler(EditEvent, value); }
        }

        void RaiseEditEvent()
        {
            RoutedEventArgs newEventArgs = new RoutedEventArgs(User.EditEvent);
            RaiseEvent(newEventArgs);
        }

        public string UserName
        {
            get { return (string)GetValue(UserNameProperty); }
            set { SetValue(UserNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for UserName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UserNameProperty =
            DependencyProperty.Register("UserName", typeof(string), typeof(User), new UIPropertyMetadata("UserName"));


        public string UserPath
        {
            get { return (string)GetValue(UserPathProperty); }
            set { SetValue(UserPathProperty, value); }
        }

        // Using a DependencyProperty as the backing store for UserPath.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UserPathProperty =
            DependencyProperty.Register("UserPath", typeof(string), typeof(User), new UIPropertyMetadata("/Resources/Images/user5.png"));
    }
}
