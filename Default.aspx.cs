using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
  
    DataBase.Service db = new DataBase.Service();

    protected void Page_Load(object sender, EventArgs e)
    {
        db.Timeout = -1;
        DataSet ds = db.Get("Customers");

        if (!IsPostBack) //Bind GridView only when IsPostBack is false
        {          
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        //foreach (DataRow item in ds.Tables[0].Rows)
        //{
        //    Label2.Text += item["Name"].ToString() + item["Country"].ToString();
        //}
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
    }
    

    protected void Button1_Click1(object sender, EventArgs e)
    {

        DataBase.Service db = new DataBase.Service();
        DataBase.fieldnameandvalue[] lstFieldNameAndValue = new DataBase.fieldnameandvalue[3];
        DataBase.fieldnameandvalue vFieldNameAndValue = null;

        vFieldNameAndValue = new DataBase.fieldnameandvalue();
        vFieldNameAndValue.fieldname = "ID";
        vFieldNameAndValue.value = Guid.NewGuid().ToString();
        lstFieldNameAndValue[0] = vFieldNameAndValue;

        vFieldNameAndValue = new DataBase.fieldnameandvalue();
        vFieldNameAndValue.fieldname = "Name";
        vFieldNameAndValue.value = TextBox1.Text;
        lstFieldNameAndValue[1] = vFieldNameAndValue;

        vFieldNameAndValue = new DataBase.fieldnameandvalue();
        vFieldNameAndValue.fieldname = "Country";
        vFieldNameAndValue.value = TextBox2.Text;
        lstFieldNameAndValue[2] = vFieldNameAndValue;

        db.Ekle("Customers", lstFieldNameAndValue);
    }

    protected void Button2_Click1(object sender, EventArgs e)
    {
        //DataBase.Service db = new DataBase.Service();
        //DataBase.fieldnameandvalue[] pCreteria = new DataBase.fieldnameandvalue[3];
        //DataBase.fieldnameandvalue[] pFieldNameAndValue = null;
     

        //db.ekl("Customers", pCreteria, pFieldNameAndValue);
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        //string userid = GridView1.DataKeys[e.RowIndex].Value.ToString();
        //GridView1.DeleteRow(e.RowIndex);
        //GridView1.DataBind();
        //DataBase.Service db = new DataBase.Service();
        //int customerId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
        //string query = "DELETE FROM Customers WHERE CustomerId=@CustomerId";
        //string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;

        //using (SqlConnection con = new SqlConnection(constr))
        //{
        //    using (SqlCommand cmd = new SqlCommand(query))
        //    {
        //        cmd.Parameters.AddWithValue("@ID", customerId);
        //        cmd.Connection = con;
        //        con.Open();
        //        cmd.ExecuteNonQuery();
        //        con.Close();
        //    }
        //}
    }

    protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
    {
        //DataBase.Service db = new DataBase.Service();
        //DataBase.fieldnameandvalue[] pCreteria = new DataBase.fieldnameandvalue[3];
        //DataBase.fieldnameandvalue[] pFieldNameAndValue = null;

        //db.Guncelle("Customers", pCreteria, pFieldNameAndValue);
    }

    protected void GridView1_RowUpdating2(object sender, GridViewUpdateEventArgs e)
    {
        DataBase.fieldnameandvalue[] pCreteria = new DataBase.fieldnameandvalue[3];
        DataBase.fieldnameandvalue[] pFieldNameAndValue = new DataBase.fieldnameandvalue[4];
        DataBase.fieldnameandvalue[] pFieldCountry = new DataBase.fieldnameandvalue[4];

        string userid = GridView1.DataKeys[e.RowIndex].Value.ToString();
        DataBase.Service db = new DataBase.Service();
        DataBase.fieldnameandvalue pCreteriaItem = new DataBase.fieldnameandvalue();
        pCreteriaItem.fieldname = GridView1.DataKeyNames[0].ToString();
        pCreteriaItem.value = userid;
        pCreteria[0] = pCreteriaItem;

        GridViewRow row = GridView1.Rows[e.RowIndex];
        //Label lblID = (Label)row.FindControl("lblID");        

        string textName = e.NewValues["Name"].ToString();// row.Cells[2].Text.ToString();
        DataBase.fieldnameandvalue pItem = new DataBase.fieldnameandvalue();
        pItem.fieldname = "Name";
        pItem.value = textName;
        pFieldNameAndValue[0] = pItem;

        string textName1 = e.NewValues["Country"].ToString();// row.Cells[2].Text.ToString();
        DataBase.fieldnameandvalue pItem1 = new DataBase.fieldnameandvalue();
        pItem1.fieldname = "Country";
        pItem1.value = textName1;
        pFieldNameAndValue[1] = pItem1;
        
        //string textadd = ((TextBox)(row.Cells[1].Controls[0])).Text;//row.Cells[3].Text.ToString();
        //pItem = new DataBase.fieldnameandvalue();
        //pItem.fieldname = "Country";
        //pItem.value = textadd;
        //pFieldNameAndValue[0] = pItem;

        db.Guncelle("Customers", pCreteria, pFieldNameAndValue);
        Page_Load(sender,e);
}
    
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {

    }

    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        DataSet ds = db.Get("Customers");

        if (!IsPostBack) //Bind GridView only when IsPostBack is false
        {
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

    }

    protected void GridView1_RowDeleting1(object sender, GridViewDeleteEventArgs e)
    {
        DataBase.fieldnameandvalue[] pCreteria = new DataBase.fieldnameandvalue[3];
        string userid = GridView1.DataKeys[e.RowIndex].Value.ToString();
        DataBase.Service db = new DataBase.Service();
        DataBase.fieldnameandvalue pCreteriaItem = new DataBase.fieldnameandvalue();
        pCreteriaItem.fieldname = GridView1.DataKeyNames[0].ToString();
        pCreteriaItem.value = userid;
        pCreteria[0] = pCreteriaItem;

        db.Sil("Customers", pCreteria);
        
    }
}



