
# Checkout Mode

Store processing mode reflected in the checkout configuration: `live` and `test` reflect the credential used to authenticate, while `live_test` is reserved for privileged callers testing against live-mode data.

## Enumeration

`CheckoutMode`

## Fields

| Name |
|  --- |
| `Live` |
| `Test` |
| `LiveTest` |

## Example

```csharp
using UnivaPay.Models;

CheckoutMode checkoutMode = CheckoutMode.Live;
```

