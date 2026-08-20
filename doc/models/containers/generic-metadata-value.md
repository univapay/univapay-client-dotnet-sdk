
# Generic Metadata Value

Allowed values for metadata properties. Values may be a string, number, boolean, null, or an array of any of the above — but not a nested object; the server rejects metadata whose direct property values are JSON objects.

## Class Name

`GenericMetadataValue`

## Cases

| Type | Factory Method |
|  --- | --- |
| `string` | GenericMetadataValue.FromString(string mString) |
| `double` | GenericMetadataValue.FromPrecision(double precision) |
| `bool` | GenericMetadataValue.FromBoolean(bool boolean) |
| `object` | GenericMetadataValue.FromListOfObject(object listOfObject) |

## string

### Initialization Code

#### Example

```csharp
GenericMetadataValue value = GenericMetadataValue.FromString("sale");
```

## double

### Initialization Code

#### Example

```csharp
GenericMetadataValue value = GenericMetadataValue.FromPrecision(10);
```

## bool

### Initialization Code

#### Example

```csharp
GenericMetadataValue value = GenericMetadataValue.FromBoolean(true);
```

## object

### Initialization Code

#### Example

```csharp
GenericMetadataValue value = GenericMetadataValue.FromListOfObject(
    new List<object>
    {
        ApiHelper.JsonDeserialize<object>("\"sale\""),
        ApiHelper.JsonDeserialize<object>("\"promo\""),
    }
);
```

