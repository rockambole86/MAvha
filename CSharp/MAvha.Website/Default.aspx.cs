using System;
using System.Collections.Generic;
using System.Web.Services;
using MAvha.Business;
using MAvhaService;

public partial class _Default : System.Web.UI.Page 
{
    private static readonly ServiceSoapClient _client = new ServiceSoapClient();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    [WebMethod]
    public static string ListJson()
    {
        return _client.ListJson();
    }

    [WebMethod]
    public static void Save(Person person)
    {
        _client.Save(person);
    }

    [WebMethod]
    public static void Delete(int id)
    {
        _client.Delete(id);
    }
}