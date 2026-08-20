
# Checkout Installment Card Processor

Card-processor capabilities available for installment payments.

*This model accepts additional fields of type object.*

## Structure

`CheckoutInstallmentCardProcessor`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Revolving` | `bool?` | Optional | Whether revolving installment payments are allowed. |
| `FixedCycle` | `bool?` | Optional | Whether fixed-cycle installment payments are allowed. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

CheckoutInstallmentCardProcessor checkoutInstallmentCardProcessor = new CheckoutInstallmentCardProcessor
{
    Revolving = true,
    FixedCycle = true,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

