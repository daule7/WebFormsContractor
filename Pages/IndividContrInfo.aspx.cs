using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormsContractor.ServiceReference1;
using System.Data;
using System.Data.SqlClient;



namespace WebFormsContractor.Pages
{
    public partial class IndividContrInfo : System.Web.UI.Page
        
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }
        private void LoadData()
        {
            WebService1SoapClient service = new WebService1SoapClient();
            DataSet dataSet = service.Read(1);
            dgViewIndividContr.DataSource = dataSet;
            dgViewIndividContr.DataBind();
        }

     

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            WebService1SoapClient service = new WebService1SoapClient();
            int id = int.Parse(lblid.Text);
            string iin = txtIIN.Text;
            string name = txtName.Text;
            int age = int.Parse(txtAge.Text);
            DateTime createdDate = DateTime.Parse(txtCrtDate.Text);
            DateTime editedDate = DateTime.Parse(txtEdtDate.Text);
            string gender = ddlGender.SelectedValue;

            service.Update(id, iin, name, age, createdDate, editedDate,gender);

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            WebService1SoapClient service = new WebService1SoapClient();

            string iin = txtIIN.Text;
            string name = txtName.Text;
            int age = int.Parse(txtAge.Text);
            DateTime createdDate = DateTime.Parse(txtCrtDate.Text);
            DateTime editedDate = DateTime.Parse(txtEdtDate.Text);
            string gender = ddlGender.SelectedValue;

            service.Create(iin, name, age, createdDate, editedDate, gender);
        }
    }
    }
  
}