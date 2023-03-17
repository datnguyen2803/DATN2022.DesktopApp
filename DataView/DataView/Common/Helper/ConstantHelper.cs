using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataView.Common.Helper
{
    public class ConstantHelper
    {
        public static readonly string APIURL = "https://localhost:44393/api";

        public enum APIResponseCode
        {
            CODE_SUCCESS = 0,
            CODE_FAIL,
            CODE_RESOURCE_NOT_FOUND,
            CODE_RESOURCE_DUPLICATE,
        }

        public struct APIResponseMessage
        {
            public static readonly string MESSAGE_OK = "";

            public static readonly string MESSAGE_USER_WRONG_NAME = "Wrong user name, cannot get user data";
            public static readonly string MESSAGE_USER_WRONG_PASS = "Wrong password, try again";
            public static readonly string MESSAGE_USER_DUPLICATE = "Cannot register the same user";

            public static readonly string MESSAGE_STATION_EMPTY_FOUND = "No stations found";
            public static readonly string MESSAGE_STATION_NOT_FOUND = "No station matches the station name";
            public static readonly string MESSAGE_STATION_DUPLICATE = "Cannot add the same station";

            public static readonly string MESSAGE_PUMP_EMPTY_FOUND = "No pump matches the station name";
            public static readonly string MESSAGE_PUMP_NOT_FOUND = "No pump matches the station name and pump name";
            public static readonly string MESSAGE_PUMP_DUPLICATE = "Cannot add the same pump";
        }

        public enum INTERNAL_MESSAGE_CODE
        {
            CODE_INTERNAL_MESSAGE_NONE = 0,

            CODE_INTERNAL_MESSAGE_ON_LOGIN,
            CODE_INTERNAL_MESSAGE_LOGIN_SUCCESS,
            CODE_INTERNAL_MESSAGE_LOGIN_FAIL,

            CODE_INTERNAL_MESSAGE_CHANGETO_HOME,
            CODE_INTERNAL_MESSAGE_CHANGETO_STATION_MENU,
            CODE_INTERNAL_MESSAGE_CHANGETO_PUMP_MENU,
            CODE_INTERNAL_MESSAGE_CHANGETO_PUMP_UPDATE,
            CODE_INTERNAL_MESSAGE_CHANGETO_SEARCH,

            CODE_INTERNAL_MESSAGE_GO_BACK,

            CODE_INTERNAL_MESSAGE_QUIT,

            CODE_INTERNAL_MESSAGE_MAX
        }

        public enum INTERNAL_VIEW_CODE
        {
            CODE_INTERNAL_VIEW_NONE = 0,

            CODE_INTERNAL_VIEW_LOGIN,
            CODE_INTERNAL_VIEW_HOME,
            CODE_INTERNAL_VIEW_STATION_MENU,
            CODE_INTERNAL_VIEW_PUMP_MENU,
            CODE_INTERNAL_VIEW_PUMP_UPDATE,
            CODE_INTERNAL_VIEW_SEARCH,

            CODE_INTERNAL_VIEW_MAX
        }

        public enum SIDEBAR_ITEM_CODE
        {
            SIDEBAR_ITEM_NONE = 0,

            SIDEBAR_ITEM_HOME,
            SIDEBAR_ITEM_SEARCH,
            SIDEBAR_ITEM_ABOUT,
            SIDEBAR_ITEM_QUIT,

            SIDEBAR_ITEM_MAX
        }
    }
}
