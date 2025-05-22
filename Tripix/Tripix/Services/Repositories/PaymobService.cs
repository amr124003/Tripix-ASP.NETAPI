// Services/PaymobService.cs
using Newtonsoft.Json;
using RestSharp;

public class PaymobService
{
    private readonly string _apiKey;
    private readonly string _merchantId;

    public PaymobService ( string apiKey, string merchantId )
    {
        _apiKey = apiKey;
        _merchantId = merchantId;
    }

    public async Task<string> GetAuthTokenAsync ()
    {
        var client = new RestClient("https://accept.paymob.com/api/auth/tokens");
        var request = new RestRequest();
        request.Method = Method.Post;
        request.AddJsonBody(new
        {
            api_key = _apiKey
        });

        var response = await client.ExecuteAsync(request);
        dynamic result = JsonConvert.DeserializeObject(response.Content);
        return result.token;
    }

    public async Task<string> CreateOrderAsync ( decimal amount, string currency = "EGP" )
    {
        var token = await GetAuthTokenAsync();

        var client = new RestClient("https://accept.paymob.com/api/ecommerce/orders");
        var request = new RestRequest();
        request.Method = Method.Post;

        request.AddJsonBody(new
        {
            auth_token = token,
            delivery_needed = "false",
            merchant_id = _merchantId,
            amount_cents = amount * 100, // Paymob uses cents
            currency,
            items = new object[] { }
        });

        var response = await client.ExecuteAsync(request);
        dynamic result = JsonConvert.DeserializeObject(response.Content);
        return result.id.ToString();
    }

    public async Task<string> GetPaymentKeyAsync ( string orderId, decimal amount )
    {
        var token = await GetAuthTokenAsync();

        var client = new RestClient("https://accept.paymob.com/api/acceptance/payment_keys");
        var request = new RestRequest();
        request.Method = Method.Post;

        request.AddJsonBody(new
        {
            auth_token = token,
            amount_cents = amount * 100,
            expiration = 3600,
            order_id = orderId,
            billing_data = new
            {
                first_name = "John",
                last_name = "Doe",
                email = "user@example.com",
                phone_number = "+201234567890",
                country = "Egypt",
                city = "Cairo",
                street = "Nile Corniche",
                building = "15",
                floor = "5",
                apartment = "10"
            },
            currency = "EGP",
            integration_id = 5004462 // «” »œ· » Integration ID «·Œ«’ »ﬂ
        });

        var response = await client.ExecuteAsync(request);
        dynamic result = JsonConvert.DeserializeObject(response.Content);
        return result.token;
    }
}