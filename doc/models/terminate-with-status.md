
# Terminate with Status

The status the subscription would transition to on this payment's due date, if a termination is scheduled. `null` when no termination applies.

## Enumeration

`TerminateWithStatus`

## Fields

| Name |
|  --- |
| `Suspended` |
| `Canceled` |

## Example

```csharp
using UnivaPay.Models;

TerminateWithStatus terminateWithStatus = TerminateWithStatus.Suspended;
```

