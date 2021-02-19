using System;
using System.Collections.Generic;

namespace ERP
{
    class OuterUserInfo : OuterUser, IUserInfo
    {
        private Dictionary<string, string> baseInfo;
        private Dictionary<string, string> homeInfo;
        private Dictionary<string, string> officeInfo;
        public OuterUserInfo()
        {
            baseInfo = base.GetUserBaseInfo();
            homeInfo = base.GetUserHomeInfo();
            officeInfo = base.GetUserOfficeInfo();
        }

        public string GetHomeAddress()
        {
            Console.WriteLine(homeInfo["HomeAddress"]);
            return null;
        }

        public string GetHomeTelNumber()
        {
            Console.WriteLine(homeInfo["HomeTelNumber"]);
            return null;
        }

        public string GetJobPosition()
        {
            Console.WriteLine(officeInfo["JobPosition"]);
            return null;
        }

        public string GetMobileNumber()
        {
            Console.WriteLine(baseInfo["MobileNumber"]);
            return null;
        }

        public string GetOfficeTelNumber()
        {
            Console.WriteLine(officeInfo["OfficeTelNumber"]);
            return null;
        }

        public string GetUserName()
        {
            Console.WriteLine(baseInfo["UserName"]);
            return null;
        }
    }
}
