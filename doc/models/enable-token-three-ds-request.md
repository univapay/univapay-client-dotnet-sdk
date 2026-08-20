
# Enable Token Three Ds Request

Request payload for enabling 3DS on a recurring token. Both the body and `redirect_endpoint` are optional.

*This model accepts additional fields of type object.*

## Structure

`EnableTokenThreeDsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RedirectEndpoint` | `string` | Optional | URL to redirect the customer to after 3DS authentication. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;

EnableTokenThreeDsRequest enableTokenThreeDsRequest = new EnableTokenThreeDsRequest
{
};
```

