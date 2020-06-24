using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Guests.Tests.ReusableFixtures;

namespace Guests.Tests.Helpers
{
    public class AuthHelper
    {
        public class ResponseAsObject
        {
            public HttpResponseMessage Message { get; set; }
            public string Role { get; set; }

        }

        public class TestUser
        {
            public string Token { get; set; }
            public string Role { get; set; }

            public string Id { get; set; }
        }
        public static async Task<string> GenerateNonOwnerId(DatabaseFixture fixture)
        {
            HttpResponseMessage registerNonOwnerResponse = await AccountHelper.RegisterUniqueRegisterModel(fixture.httpClient);
            RegisterOutput registerNonOwnerOutput = await JsonHelper.TryDeserializeJson<RegisterOutput>(registerNonOwnerResponse);
            return registerNonOwnerOutput.id;
        }

        public static async Task<AuthHelper.ResponseAsObject> GenerateAuthIdRequest(string endpoint, HttpMethod method, AuthHelper.TestUser user, DatabaseFixture fixture, object body)
        {
            HttpRequestMessage requestMessage = new HttpRequestMessage(method, endpoint);
            if (body != null)
            {
                requestMessage.Content = JsonHelper.CreatePostContent(body);
            }
            AuthenticationHeaderValue authHeader;
            bool isValidHeader = AuthenticationHeaderValue.TryParse($"Bearer {user.Token}", out authHeader);
            requestMessage.Headers.Authorization = authHeader;
            HttpResponseMessage responseWithAuthHeaders = await fixture.httpClient.SendAsync(requestMessage);
            return new ResponseAsObject() { Message = responseWithAuthHeaders, Role = user.Role };
        }
    }
}
