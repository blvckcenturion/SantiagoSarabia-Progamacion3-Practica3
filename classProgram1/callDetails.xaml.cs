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
using System.Windows.Shapes;

namespace classProgram1
{
    /// <summary>
    /// Interaction logic for callDetails.xaml
    /// </summary>
    public partial class callDetails : Window
    {
        public Request request;
        public Stack<Request> stack;
        
        public callDetails(Request req, Stack<Request> res)
        {
            InitializeComponent();
            request = req;
            stack = res;

        }

        private void addProductBtn_Click(object sender, RoutedEventArgs e)
        {
            if(nameTxt.Text != "" || qtyTxt.Text != "" || typeTxt.Text != "")
            {
                request.Products.Add(new Product(nameTxt.Text, int.Parse(qtyTxt.Text), (ProductType)int.Parse(typeTxt.Text)));
                nameTxt.Text = "";
                qtyTxt.Text = "";
                typeTxt.Text = "";
            }
        }

        private void finalizeOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            
            stack.Push(request);
            this.Close();
        }
    }
}
