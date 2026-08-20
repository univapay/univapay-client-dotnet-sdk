
# Direct Debit Bank Transfer Error

Reason a transfer failed, as reported by the bank.
| Value | Meaning | | :--- | :--- | | `insufficient_funds` | The account did not hold enough money on the debit date. | | `no_deposit_transaction` | The account exists but has no deposit activity. | | `transfer_stopped_by_depositor` | The consumer instructed their bank to stop the debit. | | `no_account_transfer_request` | No valid direct debit mandate is on file for the account. | | `transfer_stopped_by_trustee` | The collecting bank stopped the debit. | | `other_error` | The bank reported a failure outside the categories above. | | `unknown_error` | The failure reason could not be determined. |

## Enumeration

`DirectDebitBankTransferError`

## Fields

| Name |
|  --- |
| `InsufficientFunds` |
| `NoDepositTransaction` |
| `TransferStoppedByDepositor` |
| `NoAccountTransferRequest` |
| `TransferStoppedByTrustee` |
| `OtherError` |
| `UnknownError` |

## Example

```csharp
using UnivaPay.Models;

DirectDebitBankTransferError directDebitBankTransferError = DirectDebitBankTransferError.NoAccountTransferRequest;
```

