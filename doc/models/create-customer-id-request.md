
# Create Customer Id Request

Request payload for deriving a deterministic customer ID.

*This model accepts additional fields of type object.*

## Structure

`CreateCustomerIdRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CustomerId` | `string` | Required | The merchant's own local identifier for the customer, used as the seed for a deterministic per-store UUID.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `64` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;

CreateCustomerIdRequest createCustomerIdRequest = new CreateCustomerIdRequest
{
    CustomerId = "local-customer-1902",
};
```

