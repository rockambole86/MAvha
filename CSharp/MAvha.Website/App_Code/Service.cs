using System.Collections.Generic;
using System.Web.Script.Services;
using System.Web.Services;
using MAvha.Business;
using MAvha.DAL;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[ScriptService]
public class Service : WebService
{
    [WebMethod]
    public List<Person> List()
    {
        return DataManager.PersonList();
    }

    [WebMethod]
    public string ListJson()
    {
        var js = new System.Web.Script.Serialization.JavaScriptSerializer();

        return js.Serialize(DataManager.PersonList());
    }

    [WebMethod]
    public void Save(Person person)
    {
        DataManager.PersonSave(person);
    }

    [WebMethod]
    public void Delete(int id)
    {

        DataManager.PersonDelete(id);
    }
}