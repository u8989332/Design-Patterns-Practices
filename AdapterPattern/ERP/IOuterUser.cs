using System.Collections.Generic;

namespace ERP
{
    interface IOuterUser
    {
        Dictionary<string, string> GetUserBaseInfo();
        Dictionary<string, string> GetUserOfficeInfo();
        Dictionary<string, string> GetUserHomeInfo();
    }
}
