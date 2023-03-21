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
using static DataView.Common.Helper.ConstantHelper;

namespace DataView.Service
{
    interface IHistoryService
    {
        private static void PrintDebug(APIResponseCode ErrorCode, string ErrorMessage)
        {
            Debug.WriteLine(String.Format("[HistoryService]: ErrorCode = {0}, Description: {1}", ErrorCode, ErrorMessage));
        }

        private static int GetHistoryByState(string StationName, string PumpPosition, string Date, int State)
        {
            int retVal = -1;
            string ApiServ = "history";
            string ApiAction = "GetHistoryByState";
            string ApiParameter = "stationname=" + StationName + "&" + "pumpposition=" + PumpPosition + "date=" + Date + "state=" + State;
            try
            {
                var client = new RestClient();
                var request = new RestRequest(ConstantHelper.APIURL + "/" + ApiServ + "/" + ApiAction + "?" + ApiParameter, Method.Get);
                request.AddHeader("Content-type", "application/json");
                var response = client.Execute(request);
                if (response.Content == null)
                {
                    return retVal = -1;
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
                        string responseData = myResponseModel.Data.ToString();
                        retVal = JsonConvert.DeserializeObject<int>(responseData);
                    }
                    else
                    {
                        PrintDebug(myResponseModel.Code, myResponseModel.Message);
                        // do nothing
                    }
                }

                return retVal;
            }
            catch (Exception ex)
            {
                return retVal = -1;
            }
        }
        
        public static int GetTimeOnByDate(string StationName, string PumpPosition, string Date)
        {
            int retVal = 0;
            retVal = GetHistoryByState(StationName, PumpPosition, Date, 1);
            return retVal;
        }

        public static int GetTimeOffByDate(string StationName, string PumpPosition, string Date)
        {
            int retVal = 0;
            retVal = GetHistoryByState(StationName, PumpPosition, Date, 0);
            return retVal;
        }


    }
}
