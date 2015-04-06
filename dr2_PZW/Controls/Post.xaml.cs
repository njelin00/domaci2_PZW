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
    /// Interaction logic for Post.xaml
    /// </summary>
    public partial class Post : UserControl
    {
        public Post()
        {
            InitializeComponent();
        }

        private void PostControl_Loaded(object sender, RoutedEventArgs e)
        {
            this.DeleteIcon_post.MouseDown += (obj, eventHandler) => RaiseDeleteEvent();
            this.EditIcon_post.MouseDown += (obj, eventHandler) => RaiseEditEvent();
        }

        //delete
        public static readonly RoutedEvent DeleteEvent = EventManager.RegisterRoutedEvent
                 (
                    "Delete",
                     RoutingStrategy.Bubble,
                     typeof(RoutedEventHandler),
                     typeof(Post)
                 );

        public event RoutedEventHandler Delete
        {
            add { AddHandler(DeleteEvent, value); }
            remove { RemoveHandler(DeleteEvent, value); }
        }

        void RaiseDeleteEvent()
        {
            RoutedEventArgs newEventArgs = new RoutedEventArgs(Post.DeleteEvent);
            RaiseEvent(newEventArgs);
        }


        //edit
        public static readonly RoutedEvent EditEvent = EventManager.RegisterRoutedEvent
                 (
                    "Edit",
                     RoutingStrategy.Bubble,
                     typeof(RoutedEventHandler),
                     typeof(Post)
                 );

        public event RoutedEventHandler Edit
        {
            add { AddHandler(EditEvent, value); }
            remove { RemoveHandler(EditEvent, value); }
        }

        void RaiseEditEvent()
        {
            RoutedEventArgs newEventArgs = new RoutedEventArgs(Post.EditEvent);
            RaiseEvent(newEventArgs);
        }

        //za ime
        public string UserName_post
        {
            get { return (string)GetValue(UserName_postProperty); }
            set { SetValue(UserName_postProperty, value); }
        }

        // Using a DependencyProperty as the backing store for UserName_post.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UserName_postProperty =
            DependencyProperty.Register("UserName_post", typeof(string), typeof(Post), new UIPropertyMetadata("Name"));


        //za postove
        public string Comment
        {
            get { return (string)GetValue(CommentProperty); }
            set { SetValue(CommentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Comment.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CommentProperty =
            DependencyProperty.Register("Comment", typeof(string), typeof(Post), new UIPropertyMetadata("Comment"));


        //za sliku
        public string UserPath_post
        {
            get { return (string)GetValue(UserPath_postProperty); }
            set { SetValue(UserPath_postProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Putanja_post.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UserPath_postProperty =
            DependencyProperty.Register("UserPath_post", typeof(string), typeof(Post), new UIPropertyMetadata("/Resources/Images/user5.png"));

    }
}
