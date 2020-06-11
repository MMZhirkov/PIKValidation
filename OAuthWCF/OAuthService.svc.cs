using OAuthWCF.Assets;
using OAuthWCF.BaseOperation;
using OAuthWCF.Context;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace OAuthWCF
{
    public class OAuthService : IOAuthService
    {
        public BaseResponse CheckLogin(string login)
        {
            try
            {
                Log.GetLogger().Info($"Запущен метод {MethodBase.GetCurrentMethod().Name}, login = {login}");

                if (string.IsNullOrEmpty(login))
                {
                    Log.GetLogger().Info($"Метод {MethodBase.GetCurrentMethod().Name} успешно отработал");
                    return new BaseResponse("Передан пустой логин");
                }

                var path = Path.Combine((Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)).Parent.FullName, @"OAuthWebAngularJS\App_Data\Users.mdf");
                var hasRegistrationUser = false;

                using (var context = new UserContext($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='{path}';Integrated Security=True"))
                    hasRegistrationUser = context.Users.Any(s => s.Login == login);

                if (hasRegistrationUser)
                {
                    Log.GetLogger().Info($"Метод {MethodBase.GetCurrentMethod().Name} успешно отработал, login = {login} найден в бд");
                    return new BaseResponse();
                }

                Log.GetLogger().Info($"Метод {MethodBase.GetCurrentMethod().Name} успешно отработал, login = {login} не найден в бд");
                return new BaseResponse("Ошибка. Не найден логин");
            }
            catch (ApplicationException ex)
            {
                Log.GetLogger().Error($"Произошла ошибка в {MethodBase.GetCurrentMethod().Name}", ex);
                return new BaseResponse(ex.Message);
            }
            catch (Exception ex)
            {
                Log.GetLogger().Error($"Произошла непредвиденная ошибка в {MethodBase.GetCurrentMethod().Name}", ex);
                return new BaseResponse(ex.Message);
            }
        }
    }
}
