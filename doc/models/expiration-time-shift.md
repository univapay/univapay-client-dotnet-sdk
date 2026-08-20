
# Expiration Time Shift

Time-of-day override applied when calculating expirations, shared by convenience-store and bank-transfer configuration.

*This model accepts additional fields of type object.*

## Structure

`ExpirationTimeShift`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MValue` | `string` | Optional | ISO-8601 offset time (HH:mm:ssXXX) that overrides the expiration cutoff. Omitted entirely when no override is configured. |
| `Enabled` | `bool?` | Optional | Whether the time-of-day override is applied. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

ExpirationTimeShift expirationTimeShift = new ExpirationTimeShift
{
    MValue = "23:59:59+09:00",
    Enabled = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

