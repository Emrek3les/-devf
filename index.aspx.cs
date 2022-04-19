using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.OleDb;
public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btKaydet_Click(object sender, EventArgs e)
    {
        OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["baglanti_cumlem"].ConnectionString); //olmalı
        OleDbCommand komut;  //olmalı
        string sorgu = "insert into mesajlar (isim, eposta, konu, icerik) values (@isim,@eposta,@konu,@icerik)"; // uyarlanmış halde olmalı !
        komut = new OleDbCommand(sorgu, con); //olmalı
        komut.Parameters.AddWithValue("@isim", tbIsim.Text);
        komut.Parameters.AddWithValue("@eposta", tbEposta.Text);
        komut.Parameters.AddWithValue("@konu", tbKonu.Text);
        komut.Parameters.AddWithValue("@icerik", tbMesajiniz.Text);
        con.Open();
        komut.ExecuteNonQuery();
        con.Close();
        //    gv1.DataBind();
        // tbDersAdi.Text = ""; // aslolan null yazmak

    }
}