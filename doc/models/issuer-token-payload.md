
# Issuer Token Payload

A dictionary containing necessary key-value pairs for sending the request.

*This model accepts additional fields of type object.*

## Structure

`IssuerTokenPayload`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestData` | `string` | Optional | Generic payload key used by most payment providers. |
| `SSpcd` | `string` | Optional | d-barai payment service code. |
| `SCptok` | `string` | Optional | d-barai coupon token. |
| `STerkn` | `string` | Optional | d-barai terminal key. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;

IssuerTokenPayload issuerTokenPayload = new IssuerTokenPayload
{
};
```

