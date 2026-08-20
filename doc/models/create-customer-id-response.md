
# Create Customer Id Response

Response payload returned after deriving a deterministic customer ID.

*This model accepts additional fields of type object.*

## Structure

`CreateCustomerIdResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CustomerId` | `Guid?` | Optional | Deterministic UUID derived from the store and the supplied local `customer_id`. Identical for repeated calls with the same inputs. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;

CreateCustomerIdResponse createCustomerIdResponse = new CreateCustomerIdResponse
{
    CustomerId = new Guid("8a3f1b8e-2c1a-4b7a-9c2e-6f6b6f6e2b10"),
};
```

