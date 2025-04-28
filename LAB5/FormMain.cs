using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vubcaffe;

namespace VubCaffe;
public partial class FormMain : Form
{
    private Reciept reciept;

    public FormMain()
    {
        InitializeComponent();
        reciept = new Reciept();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Jeste li sigurni da želite izaći iz programa?", "Izlaz iz programa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
        {
            Close();
        }
    }

    private void RefreshReciept()
    {
        RefreshItems();
        RefreshTotal();
    }

    private void RefreshItems()
    {
        lbItems.Items.Clear();
        foreach (var product in reciept.Products)
        {
            lbItems.Items.Add(product);
        }
    }

    private void RefreshTotal()
    {
        lblTotalPrice.Text = string.Format("{0:0.00}€", reciept.Total());
    }

    private void btnCocaCola_Click(object sender, EventArgs e)
    {
        reciept.AddProduct(new CocaCola()); 
        RefreshReciept();
    }
    private void btnFanta_Click(object sender, EventArgs e)
    {
        reciept.AddProduct(new Fanta());
        RefreshReciept();
    }

    private void btnEspresso_Click(object sender, EventArgs e)
    {
        reciept.AddProduct(new Espresso());
        RefreshReciept();
    }

    private void btnLatte_Click(object sender, EventArgs e)
    {
        reciept.AddProduct(new Latte());
        RefreshReciept();
    }

    private void btnSprite_Click(object sender, EventArgs e)
    {
        reciept.AddProduct(new Sprite());
        RefreshReciept();
    }

    private void btnVoucher100Eur_Click(object sender, EventArgs e)
    {
        reciept.AddProduct(new GiftVoucher100());
        RefreshReciept();
    }

    private void btnNewBill_Click(object sender, EventArgs e)
    {
        reciept = new Reciept();
        RefreshReciept();
    }

    private void btnReciept_Click(object sender, EventArgs e)
    {
        double totalAmount = reciept.Total();

        DialogResult result = MessageBox.Show(
            $"Ukupno za plaćanje je: {totalAmount:0.00} €",
            "Naplata",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Information
        );

   
        if (result == DialogResult.OK)
        {
            
            reciept = new Reciept(); 
            RefreshReciept(); 
        }
    }


    private void btnSladoled_Click(object sender, EventArgs e)
    {
        reciept.AddProduct(new IceCream());
        RefreshReciept();
    }   
   
   private void btnKolac_Click(object sender, EventArgs e)
    {
        reciept.AddProduct(new Cake());
        RefreshReciept();
    }

  private void btnCappucino_Click(object sender, EventArgs e)
    {
        reciept.AddProduct(new Cappuchino());
        RefreshReciept();  
    }
   
}

