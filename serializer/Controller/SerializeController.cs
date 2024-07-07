using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using serializer.Helper;
using serializer.Model;

namespace serializer.Controller;

[ApiController]
public class SerializeController : Microsoft.AspNetCore.Mvc.Controller
{
    // GET
    [HttpGet]
    [Route("getdata")]
    public List<designItem> getData()
    {
        SerializeHelper helper = new SerializeHelper();
        return helper.getStoredData();
    }

    [HttpPost]
    [Route("update")]
    public bool storeState(List<designItem> data)
    {
        SerializeHelper helper = new SerializeHelper();
        return helper.StoreData(data);
    }
}