﻿using LoginRadiusSDK.V2.Models.UserProfile;

namespace LoginRadiusSDK.V2.Models
{
    public class LoginRadiusPostResponse
    {
        public bool IsPosted { get; set; }
    }

    public class LoginRadiusPostResponse<T> : LoginRadiusPostResponse
    {
        public T Data { get; set; }
    }


    public class Data
    {
        public string Email { get; set; }
        public LoginRadiusUserIdentity Profile { get; set; }
        public string access_token { get; set; }
        public string refresh_token { get; set; }
        public string expires_in { get; set; }
    }
}