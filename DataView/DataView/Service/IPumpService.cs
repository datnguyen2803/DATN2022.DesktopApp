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
    public interface IPumpService
    {

        private static void PrintDebug(APIResponseCode ErrorCode, string ErrorMessage)
        {
            Debug.WriteLine(String.Format("[PumpService]: ErrorCode = {0}, Description: {1}", ErrorCode, ErrorMessage));
        }

        public static List<PumpModel> GetAll()
        {
            var myPumpList = new List<PumpModel>();
            string ApiServ = "pump";
            string ApiAction = "getall";
            try
            {
                var client = new RestClient();

                var request = new RestRequest(ConstantHelper.APIURL + "/" + ApiServ + "/" + ApiAction, Method.Get);
                request.AddHeader("Content-type", "application/json");
                var response = client.Execute(request);
                if (response.Content == null)
                {
                    return myPumpList;
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
                        myPumpList = JsonConvert.DeserializeObject<List<PumpModel>>((string)myResponseModel.Data);
                    }
                    else
                    {
                        PrintDebug(myResponseModel.Code, myResponseModel.Message);
                        // do nothing
                    }
                }

                return myPumpList;
            }
            catch (Exception ex)
            {
                return myPumpList;
            }
        }

        public static List<PumpModel> GetByStationName(string StationName)
        {
            var myPumpList = new List<PumpModel>();
            string ApiServ = "pump";
            string ApiAction = "GetByStationName";
            string ApiParameter = "stationname=" + StationName;
            try
            {
                var client = new RestClient();

                var request = new RestRequest(ConstantHelper.APIURL + "/" + ApiServ + "/" + ApiAction + "?" + ApiParameter, Method.Get);
                request.AddHeader("Content-type", "application/json");
                var response = client.Execute(request);
                if (response.Content == null)
                {
                    return myPumpList;
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
                        myPumpList = JsonConvert.DeserializeObject<List<PumpModel>>(responseData);
                    }
                    else
                    {
                        PrintDebug(myResponseModel.Code, myResponseModel.Message);
                        // do nothing
                    }
                }

                return myPumpList;
            }
            catch (Exception ex)
            {
                return myPumpList;
            }
        }

        public static PumpModel GetByPumpName(string StationName, string Position)
        {
            var myPump = new PumpModel();
            string ApiServ = "pump";
            string ApiAction = "get";
            string ApiParameter = "stationname=" + StationName + "&" + "position=" + Position;
            try
            {
                var client = new RestClient();

                var request = new RestRequest(ConstantHelper.APIURL + "/" + ApiServ + "/" + ApiAction + "?" + ApiParameter, Method.Get);
                request.AddHeader("Content-type", "application/json");
                var response = client.Execute(request);
                if (response.Content == null)
                {
                    return myPump;
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
                        myPump = JsonConvert.DeserializeObject<PumpModel>((string)myResponseModel.Data);
                    }
                    else
                    {
                        PrintDebug(myResponseModel.Code, myResponseModel.Message);
                        // do nothing
                    }
                }

                return myPump;
            }
            catch (Exception ex)
            {
                return myPump;
            }
        }

        public static bool New (PumpModel newPump)
        {
            bool retVal = false;
            string ApiServ = "pump";
            string ApiAction = "new";
            try
            {
                var client = new RestClient();

                var request = new RestRequest(ConstantHelper.APIURL + "/" + ApiServ + "/" + ApiAction, Method.Post);
                request.AddHeader("Content-type", "application/json");
                request.AddBody(newPump);
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

        public static bool Edit(PumpModel checkPump)
        {
            bool retVal = false;
            string ApiServ = "pump";
            string ApiAction = "edit";
            try
            {
                var client = new RestClient();

                var request = new RestRequest(ConstantHelper.APIURL + "/" + ApiServ + "/" + ApiAction, Method.Put);
                request.AddHeader("Content-type", "application/json");
                request.AddBody(checkPump);
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

        public static bool Delete(PumpModel deletePump)
        {
            bool retVal = false;
            string ApiServ = "pump";
            string ApiAction = "delete";
            try
            {
                var client = new RestClient();

                var request = new RestRequest(ConstantHelper.APIURL + "/" + ApiServ + "/" + ApiAction, Method.Delete);
                request.AddHeader("Content-type", "application/json");
                request.AddBody(deletePump);
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
