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

namespace classProgram1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Queue<Request> requests = new Queue<Request>();
        public Stack<Request> finalizedRequests = new Stack<Request>();
        callDetails call;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void enterCallBtn_Click(object sender, RoutedEventArgs e)
        {
            if (numTxt.Text != "")
            {
                requests.Enqueue(new Request(numTxt.Text));
                pendingGrid.ItemsSource = null;
                pendingGrid.ItemsSource = requests;
            }
        }

        private void receiveCallBtn_Click(object sender, RoutedEventArgs e)
        {
            call = new callDetails(requests.Dequeue(), finalizedRequests);
            call.Show();
            pendingGrid.ItemsSource = null;
            pendingGrid.ItemsSource = requests;
        }

        private void viewCallsBtn_Click(object sender, RoutedEventArgs e)
        {
            if(call !=null)
            {
                finalizedRequests = call.stack;
                new AllCalls(finalizedRequests).Show();
            }
        }
    }
}
