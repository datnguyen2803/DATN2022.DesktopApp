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
    public interface IUserService
    {

        public static bool Register(UserModel regUSer)
        {
            bool retVal = false;
            string ApiServ = "user";
            string ApiAction = "register";
            try
            {
                var client = new RestClient();

                var request = new RestRequest(ConstantHelper.APIURL + "/" + ApiServ + "/" + ApiAction, Method.Post);
                request.AddHeader("Content-type", "application/json");
                request.AddBody(regUSer);
                var response = client.Execute(request);
                var myResponseModel = response == null ? null : JsonConvert.DeserializeObject<ResponseModel>(response.Content);

                if (myResponseModel == null)
                {
                    retVal = false;
                }
                else
                {
                    if (myResponseModel.Code == ConstantHelper.APIResponseCode.CODE_SUCCESS)
                    {
                        retVal = true;
                    }
                    else
                    {
                        retVal = false;
                    }
                }

                return retVal;
            }
            catch (Exception ex)
            {
                return retVal;
            }
        }

        public static bool Login(UserModel loginUSer)
        {
            bool retVal = false;
            string ApiServ = "user";
            string ApiAction = "login";
            try
            {
                var client = new RestClient();

                var request = new RestRequest(ConstantHelper.APIURL + "/" + ApiServ + "/" + ApiAction, Method.Post);
                request.AddHeader("Content-type", "application/json");
                request.AddBody(loginUSer);
                var response = client.Execute(request);
                var myResponseModel = (response == null) ? null : JsonConvert.DeserializeObject<ResponseModel>(response.Content);

                if (myResponseModel == null)
                {
                    retVal = false;
                }
                else
                {
                    if (myResponseModel.Code == ConstantHelper.APIResponseCode.CODE_SUCCESS)
                    {
                        retVal = true;
                    }
                    else
                    {
                        retVal = false;
                    }
                }

                return retVal;
            }
            catch (Exception ex)
            {
                return retVal;
            }
        }
    
        public static UserModel Info(string userName)
        {
            UserModel myUser = new UserModel();
            string ApiServ = "user";
            string ApiAction = "info";
            string ApiParameter = "username=" + userName;
            try
            {
                var client = new RestClient();

                var request = new RestRequest(ConstantHelper.APIURL + "/" + ApiServ + "/" + ApiAction + "?" + ApiParameter, Method.Get);
                request.AddHeader("Content-type", "application/json");
                var response = client.Execute(request);
                if(response.Content == null) 
                {
                    return myUser;
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
                        myUser = JsonConvert.DeserializeObject<UserModel>((string)myResponseModel.Data);
                        Debug.WriteLine(String.Format("[UserService]: Name = {0}, Pass = {1}", myUser.Name, myUser.Password));
                    }
                    else
                    {
                        // do nothing
                    }
                }

                return myUser;
            }
            catch (Exception ex)
            {
                return myUser;
            }
        }
    
    }
}
