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
    /// Interaction logic for AllCalls.xaml
    /// </summary>
    public partial class AllCalls : Window
    {
        public AllCalls(Stack<Request> req)
        {
            InitializeComponent();
            foreach(Request request in req)
            {
                allCallsList.Items.Add("Numero: " + request.PhoneNumber);
                allCallsList.Items.Add("Productos: ");
                foreach (Product prod in request.Products)
                {
                    allCallsList.Items.Add("Producto: " + prod.Name + " | Cantidad: " + prod.Qty + " | " + prod.Type);
                }
                allCallsList.Items.Add("-------------------------------------------------------");
            }
        }
    }
}
