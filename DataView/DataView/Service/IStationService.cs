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
    public interface IStationService
    {
        private static void PrintDebug(APIResponseCode ErrorCode, string ErrorMessage)
        {
            Debug.WriteLine(String.Format("[StationService]: ErrorCode = {0}, Description: {1}", ErrorCode, ErrorMessage));
        }

        public static List<StationModel> GetAll()
        {
            List<StationModel> myStationList = new List<StationModel>();
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
                    return myStationList;
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
                        var myResponseData = myResponseModel.Data.ToString();
                        myStationList = JsonConvert.DeserializeObject<List<StationModel>>(myResponseData);
                    }
                    else
                    {
                        PrintDebug(myResponseModel.Code, myResponseModel.Message);
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

        
        public static StationModel GetByName(string stationCode)
        {
            StationModel myStation = new StationModel();
            string ApiServ = "station";
            string ApiAction = "get";
            string ApiParameter = "stationcode=" + stationCode;
            try
            {
                var client = new RestClient();

                var request = new RestRequest(ConstantHelper.APIURL + "/" + ApiServ + "/" + ApiAction + "?" + ApiParameter, Method.Get);
                request.AddHeader("Content-type", "application/json");
                var response = client.Execute(request);
                if (response.Content == null)
                {
                    return myStation;
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
                        myStation = JsonConvert.DeserializeObject<StationModel>((string)myResponseModel.Data);
                    }
                    else
                    {
                        // do nothing
                    }
                }

                return myStation;
            }
            catch (Exception ex)
            {
                return myStation;
            }
        }

        public static bool New(StationModel newStation)
        {
            bool retVal = false;
            string ApiServ = "station";
            string ApiAction = "new";
            try
            {
                var client = new RestClient();

                var request = new RestRequest(ConstantHelper.APIURL + "/" + ApiServ + "/" + ApiAction, Method.Post);
                request.AddHeader("Content-type", "application/json");
                request.AddBody(newStation);
                var response = client.Execute(request);
                if (response.Content == null)
                {
                    return retVal;
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
                        retVal = true;
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
                return retVal;
            }
        }

        public static bool Edit(StationModel checkStation) 
        {
            bool retVal = false;
            string ApiServ = "station";
            string ApiAction = "edit";
            try
            {
                var client = new RestClient();

                var request = new RestRequest(ConstantHelper.APIURL + "/" + ApiServ + "/" + ApiAction, Method.Put);
                request.AddHeader("Content-type", "application/json");
                request.AddBody(checkStation);
                var response = client.Execute(request);
                if (response.Content == null)
                {
                    return retVal;
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
                        retVal = true;
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
                return retVal;
            }
        }

        public static bool Delete(StationModel deleteStation)
        {
            bool retVal = false;
            string ApiServ = "station";
            string ApiAction = "delete";
            try
            {
                var client = new RestClient();

                var request = new RestRequest(ConstantHelper.APIURL + "/" + ApiServ + "/" + ApiAction, Method.Delete);
                request.AddHeader("Content-type", "application/json");
                request.AddBody(deleteStation);
                var response = client.Execute(request);
                if (response.Content == null)
                {
                    return retVal;
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
                        retVal = true;
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
                return retVal;
            }

        }

    }
}
