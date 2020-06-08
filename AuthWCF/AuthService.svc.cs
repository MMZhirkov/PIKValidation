using AuthWCF.BaseOperation;
using AuthWCF.Context;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AuthWCF
{
    public class Service1 : AuthService
    {
        public BaseResponse CheckLogin(BaseRequest request)
        {
            try
            {
                //Log.GetLogger().Info($"Запущен метод {MethodBase.GetCurrentMethod().Name}");

                if (string.IsNullOrEmpty(request.Login))
                {
                    //Log.GetLogger().Info($"Метод {MethodBase.GetCurrentMethod().Name} успешно отработал");
                    return new BaseResponse("Передан пустой логин");
                }

                var path = Path.Combine((Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)).Parent.FullName, @"WebApplication2\App_Data\Users.mdf");
                var hasRegistrationUser = false;

                using (var context = new UserContext($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='{path}';Integrated Security=True"))
                    hasRegistrationUser = context.Users.Any(s => s.Login == request.Login);

                if (hasRegistrationUser)
                {
                    //Log.GetLogger().Info($"Метод {MethodBase.GetCurrentMethod().Name} успешно отработал");
                    return new BaseResponse();
                }

                //Log.GetLogger().Info($"Метод {MethodBase.GetCurrentMethod().Name} успешно отработал");
                return new BaseResponse("Ошибка. Не найден логин");
            }
            catch (ApplicationException ex)
            {
                //Log.GetLogger().Error($"Произошла ошибка в {MethodBase.GetCurrentMethod().Name}", ex);
                return new BaseResponse(ex.Message);
            }
            catch (Exception ex)
            {
                //Log.GetLogger().Error($"Произошла непредвиденная ошибка в {MethodBase.GetCurrentMethod().Name}", ex);
                return new BaseResponse(ex.Message);
            }
        }
    }
}
