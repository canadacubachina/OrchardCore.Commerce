using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentManagement;

namespace OrchardCore.Commerce.Payment.Stripe.Models;

public class StripePaymentPart : ContentPart
{
    public TextField PaymentIntentId { get; set; } = new();
    public int RetryCounter { get; set; }

    public TextField CardBrand { get; set; } = new();
    public TextField CardLast4 { get; set; } = new();

    public NumericField CardExpMonth { get; set; } = new();

    public NumericField CardExpYear { get; set; } = new();

    public DateTimeField CreatedUtcTime { get; set; } = new();
}
