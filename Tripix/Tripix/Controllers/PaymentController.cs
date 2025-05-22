// Controllers/PaymentController.cs
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class PaymentController : ControllerBase
{
    private readonly PaymobService _paymobService;

    public PaymentController ( PaymobService paymobService )
    {
        _paymobService = paymobService;
    }

    [HttpPost("add-credit")]
    public async Task<IActionResult> AddCredit ( [FromBody] AddCreditRequest request )
    {
        try
        {
            var orderId = await _paymobService.CreateOrderAsync(request.Amount);
            var paymentKey = await _paymobService.GetPaymentKeyAsync(orderId, request.Amount);

            return Ok(new
            {
                PaymentUrl = $"https://accept.paymob.com/api/acceptance/iframes/905497?payment_token={paymentKey}"
                // «” »œ· 123456 »‹ iframe_id «·Œ«’ »ﬂ
            });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { Error = ex.Message });
        }
    }
}

public class AddCreditRequest
{
    public decimal Amount { get; set; }
}