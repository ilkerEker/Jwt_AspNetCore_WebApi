namespace Jwt_AspNetCore_webApi.Model
{
    public class UserConstants
    {
        public static List<UserModel> Users = new()
            {
                    new UserModel(){ Username="ilker",Password="ilker_admin",Role="Admin"}
            };
    }
}