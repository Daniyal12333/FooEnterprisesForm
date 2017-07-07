using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FooEnterprisesApp
{
    public partial class Form1 : Form
    {
        int count1 = 1;
        int count2 = 1;
        int count3 = 1;
        public void enterData()
        {
            // it is function which warns to enter tha data if any field is remain empty
            if (firstName.Text == "" || lastName.Text == "" || saleCost.Text == "" || wholeSaleCost.Text == "")
            {
                MessageBox.Show("Enter all fields");
            }
        }

        public void clearForm()
        {
            //it is function which is clearing form.
            firstName.Clear();
            lastName.Clear();
            productName.Clear();
            saleCost.Clear();
            wholeSaleCost.Clear();
            customerProductId.Clear();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd(object sender, EventArgs e)
        {
            // it is a button which is adding data into a database
            enterData();
            var customer = new BusinessLayer.Customer();
            var product = new BusinessLayer.Product();
            var purchases = new BusinessLayer.CustomerProduct();
            customer.FirstName = firstName.Text;
            customer.LastName = lastName.Text;
            customer.Save();
            product.ProductName = productName.Text;
            product.SaleCost = Convert.ToDecimal(saleCost.Text);
            product.WholesaleCost = Convert.ToDecimal(wholeSaleCost.Text);
            product.Save();
            purchases.CustomerId = customer.CustomerId;
            purchases.ProductId = product.ProductId;
            purchases.Save();

            MessageBox.Show("Data Updated Successfully");
            clearForm();
        }

        private void btnUpdate(object sender, EventArgs e)
        {
            //it is a button which is updating data of customer and product.. we give cutomerProductId through it, customer and product change.
            var customerProduct = new BusinessLayer.CustomerProduct(Convert.ToInt32(customerProductId.Text));
            int cusId = customerProduct.CustomerId;
            int prdId = customerProduct.ProductId;
            var customer = new BusinessLayer.Customer(cusId);
            customer.FirstName = firstName.Text;
            customer.LastName = lastName.Text;
            customer.Save();
            var product = new BusinessLayer.Product(prdId);
            product.ProductName = productName.Text;
            product.SaleCost = Convert.ToInt32(saleCost.Text);
            product.WholesaleCost = Convert.ToInt32(wholeSaleCost.Text);
            product.Save();

            MessageBox.Show("Data Updated Successfully");
            clearForm();
        }

        private void btnDelete(object sender, EventArgs e)
        {
            //deleting record (customer).............
            var delCustomerProduct = new BusinessLayer.CustomerProduct(Convert.ToInt32(customerProductId.Text));
            int CusId = delCustomerProduct.CustomerId;
            int PrdId = delCustomerProduct.ProductId;
            delCustomerProduct.Delete();
            var delCustomer = new BusinessLayer.Customer(CusId);
            delCustomer.Delete();
            var delProduct = new BusinessLayer.Product(PrdId);
            delProduct.Delete();

            clearForm();
        }

        private void btnShow(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'fooEnterprisesDataSet2.Product' table. You can move, or remove it, as needed.
            //this.productTableAdapter.Fill(this.fooEnterprisesDataSet2.Product);
            //// TODO: This line of code loads data into the 'fooEnterprisesDataSet1.CustomerProduct' table. You can move, or remove it, as needed.
            //this.customerProductTableAdapter.Fill(this.fooEnterprisesDataSet1.CustomerProduct);
            //// TODO: This line of code loads data into the 'fooEnterprisesDataSet.Customer' table. You can move, or remove it, as needed.
            //this.customerTableAdapter.Fill(this.fooEnterprisesDataSet.Customer);


            //showing data through layerGen
            var customers = new BusinessLayer.Customers(true);
            var products = new BusinessLayer.Products(true);
            var purchases = new BusinessLayer.CustomerProducts(true);
            int n = 0;
            int o = 0;
            int p = 0;
            customers.GetAll();
            products.GetAll();
            purchases.GetAll();
            //showing data of customer in customer table
            foreach (BusinessLayer.Customer customer in customers)
            {
                if (count1 <= customers.Count)
                {
                    dataGridView1.Rows.Add();
                    count1++;
                }

                    dataGridView1.Rows[n].Cells[0].Value = customer.CustomerId;
                    dataGridView1.Rows[n].Cells[1].Value = customer.FirstName;
                    dataGridView1.Rows[n].Cells[2].Value = customer.LastName;
                    n++;
                
            }
            //showing data of customerproduct in customerproduct table
            foreach (BusinessLayer.CustomerProduct purchase in purchases)
            {
                if (count2 <= customers.Count)
                {
                    dataGridView2.Rows.Add();
                    count2++;
                }

                dataGridView2.Rows[p].Cells[0].Value = purchase.CustomerProductId;
                dataGridView2.Rows[p].Cells[1].Value = purchase.CustomerId;
                dataGridView2.Rows[p].Cells[2].Value = purchase.ProductId;
                p++;
            }
            //showing data of product in product table
            foreach (BusinessLayer.Product product in products)
            {
                if (count3 <= customers.Count)
                {
                    dataGridView3.Rows.Add();
                    count3++;
                }
                dataGridView3.Rows[o].Cells[0].Value = product.ProductId;
                dataGridView3.Rows[o].Cells[1].Value = product.ProductName;
                dataGridView3.Rows[o].Cells[2].Value = product.WholesaleCost;
                dataGridView3.Rows[o].Cells[3].Value = product.SaleCost;
                o++;
            }
        }

        private void SearchData(object sender, EventArgs e)
        {
            //searching record or customer using foreing key
            int n = 0;
            var purchases = new BusinessLayer.CustomerProducts();
            purchases.GetByCustomerId(Convert.ToInt32(SearchCustomerId.Text)); //giving and converting the id from textbox

            foreach (BusinessLayer.CustomerProduct purchase in purchases)
            {
                //FCutomerId and FProduct is being used as a foreing Key
                 dataGridView4.Rows[n].Cells[0].Value = purchase.FCustomerId.CustomerId;
                 dataGridView4.Rows[n].Cells[1].Value = purchase.FCustomerId.FirstName;
                 dataGridView4.Rows[n].Cells[2].Value = purchase.FCustomerId.LastName;
                 dataGridView6.Rows[n].Cells[0].Value = purchase.FProductId.ProductId;
                 dataGridView6.Rows[n].Cells[1].Value = purchase.FProductId.ProductName;
                 dataGridView6.Rows[n].Cells[2].Value = purchase.FProductId.WholesaleCost;
                 dataGridView6.Rows[n].Cells[3].Value = purchase.FProductId.SaleCost;

            }


           
        }

        //not using
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        //not using
        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //not using
        private void btnSearchData(object sender, EventArgs e)
        {

        }

        private void cellClkEvent(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    firstName.Text = dataGridView4.Rows[0].Cells[1].Value.ToString();
                    lastName.Text = dataGridView4.Rows[0].Cells[2].Value.ToString();
                    productName.Text = dataGridView6.Rows[0].Cells[1].Value.ToString();
                    wholeSaleCost.Text = dataGridView6.Rows[0].Cells[2].Value.ToString();
                    saleCost.Text = dataGridView6.Rows[0].Cells[3].Value.ToString();
                }
            }
        }
    }
}

