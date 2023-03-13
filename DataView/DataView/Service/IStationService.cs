using DataView.Common.Helper;
using DataView.DataModel;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataView.Service
{
    public interface IStationService
    {

        public static List<StationModel> GetAll()
        {
            List<StationModel> myStationList = null;
            string ApiServ = "station";
            string ApiAction = "getall";
            try
            {
                var client = new RestClient();

                var request = new RestRequest(ConstantHelper.APIURL + "/" + ApiServ + "/" + ApiAction, Method.Get);
                request.AddHeader("Content-type", "application/json");
                var response = client.Execute(request);
                if (response.Content == null)
                {
                    return null;
                }
                var myResponseModel = JsonConvert.DeserializeObject<ResponseModel>(response.Content);

                if (myResponseModel == null)
                {
                    // do nothing
                }
                else
                {
                    if (myResponseModel.Code == ConstantHelper.APIResponseCode.CODE_SUCCESS)
                    {
                        myStationList = JsonConvert.DeserializeObject<List<StationModel>>((string)myResponseModel.Data);
                    }
                    else
                    {
                        // do nothing
                    }
                }

                return myStationList;
            }
            catch (Exception ex)
            {
                return myStationList;
            }
        }

    }
}
