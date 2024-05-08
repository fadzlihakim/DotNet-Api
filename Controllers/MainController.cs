using ETIQA.Model.Delete;
using ETIQA.Model.Get;
using ETIQA.Model.Post;
using ETIQA.Model.Put;
using Microsoft.AspNetCore.Mvc;

namespace ETIQA.Controllers
{
    [ApiController]
    public class MainController : Controller
    {
        long tick = DateTime.Now.Ticks;

        [Route("GetData")]
        [HttpGet]
        public GetDataResponse GetData()
        {
            GetDataResponse response = new GetDataResponse();
            GetDataDB db = new GetDataDB();
            List<GetDataModel> models = db.Data();
            response.Tick = tick;
            response.Items = models;
            response.Status = "Get Data Response";

            return response;
        }

        [Route("PostData")]
        [HttpPost]
        public PostDataResponse PostData([FromBody] PostDataRequest request)
        {
            PostDataResponse response = new PostDataResponse();
            PostDataDB dB = new PostDataDB();

            return response;
        }

        [Route("PutData")]
        [HttpPut]
        public PutDataResponse PutData([FromBody]PutDataRequest request)
        {
            PutDataResponse response = new PutDataResponse();
            PutDataDB db = new PutDataDB();

            return response;
        }

        [Route("DeleteData")]
        [HttpDelete]
        public DeleteDataResponse DeleteData(int id)
        {
            DeleteDataResponse response = new DeleteDataResponse();
            DeleteDataDB db = new DeleteDataDB();

            return response;
        }
    }
}
