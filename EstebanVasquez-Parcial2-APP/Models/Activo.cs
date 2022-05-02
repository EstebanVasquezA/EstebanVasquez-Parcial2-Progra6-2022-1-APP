using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using RestSharp;
using System.Threading.Tasks;
using System.Net;


namespace EstebanVasquez_Parcial2_APP.Models
{
    public partial class Activo
{
        public RestRequest request { get; set; }

        const string mimetype = "application/json";
        const string contentType = "Content-Type";

        public Activo()
        {
            request = new RestRequest();
        }

        public string nombre { get; set; }
        public string area { get; set; }
        public decimal costo { get; set; }

        public async Task<bool> AgregarActivo()
        {
            bool R = false;
            try
            {
                string FinalApiRoute = CnnToAPI.ProductionRoute + "Activos";

                RestClient client = new RestClient(FinalApiRoute);

                request = new RestRequest(FinalApiRoute, Method.Post);

                string SerializedClass = JsonConvert.SerializeObject(this);
                request.AddBody(SerializedClass, mimetype);

                RestResponse response = await client.ExecuteAsync(request);
                HttpStatusCode statusCode = response.StatusCode;

                if (statusCode == HttpStatusCode.Created)
                {
                    R = true;
                }
            }
            catch (Exception e)
            {
                string msg = e.Message;
                throw;
            }
            return R;
        }
    }
}
