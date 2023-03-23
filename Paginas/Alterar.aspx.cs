using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSiteExemplo.Classes;
using WebSiteExemplo.Persistencia;

public partial class Paginas_Alterar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            FuncionarioBD bd = new FuncionarioBD();
            Funcionario funcionario = bd.Select(Convert.ToInt32(Session["ID"]));
            txtNome.Text = funcionario.Nome;
            txtSalario.Text = funcionario.Salario.ToString();
            txtCracha.Text = funcionario.Cracha;
        }
    }

    protected void btnSalvar_click(object sender, EventArgs e)
    {

        if (String.IsNullOrEmpty(txtNome.Text))
        {
            errorNome.Visible = true;
            errorNome.Text = "Você precisa informar seu nome";
            return;
        }

        if (string.IsNullOrEmpty(txtSalario.Text))
        {
            errorSalario.Visible = true;
            errorSalario.Text = "Você precisa informar o salário";
            return;
        }

        double salario;
        if (!Double.TryParse(txtSalario.Text, out salario))
        {
            errorSalario.Visible = true;
            errorSalario.Text = "Salário inválido. Informe apenas números com ponto e vírgula.";
            return;
        }

        if (String.IsNullOrEmpty(txtCracha.Text))
        {
            errorCracha.Visible = true;
            errorCracha.Text = "Você precisa informar o crachá";
            return;
        }

        errorNome.Visible = false;
        errorSalario.Visible = false;
        errorCracha.Visible = false;

        FuncionarioBD bd = new FuncionarioBD();
        Funcionario funcionario = bd.Select(Convert.ToInt32(Session["ID"]));
        funcionario.Nome = txtNome.Text;
        funcionario.Salario = Convert.ToDouble(txtSalario.Text);
        funcionario.Cracha = txtCracha.Text;
        if (bd.Update(funcionario))
        {
            lblMensagem.Text = "Funcionário alterado";
            txtNome.Focus();
        }
        else
        {
            lblMensagem.Text = "Erro ao salvar.";
        }
    }
}