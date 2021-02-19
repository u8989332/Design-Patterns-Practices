using System.Collections.Generic;

namespace ERP
{
    class OuterUser : IOuterUser
    {
        public Dictionary<string, string> GetUserBaseInfo()
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("UserName", "This is user name");
            map.Add("MobileNumber", "This is mobile number");

            return map;
        }

        public Dictionary<string, string> GetUserHomeInfo()
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("HomeTelNumber", "This is home tel number");
            map.Add("HomeAddress", "This is home address");

            return map;
        }

        public Dictionary<string, string> GetUserOfficeInfo()
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("JobPosition", "This is job position");
            map.Add("OfficeTelNumber", "This is office tel number");

            return map;
        }
    }
}
