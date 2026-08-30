[![](https://img.shields.io/nuget/v/soenneker.bland.calls.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.bland.calls/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.bland.calls/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.bland.calls/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.bland.calls.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.bland.calls/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.bland.calls/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.bland.calls/actions/workflows/codeql.yml)

# Soenneker.Bland.Calls

A typed .NET utility for creating, retrieving, filtering, and stopping Bland.ai calls.

## Installation

```bash
dotnet add package Soenneker.Bland.Calls
```

## Configuration

```json
{
  "Bland": {
    "ApiKey": "your-api-key"
  }
}
```

`Bland:ApiKey` is required. Set `Bland:EncryptedKey` when your Bland account also requires the `encrypted_key` header.

## Registration

```csharp
using Soenneker.Bland.Calls.Registrars;

services.AddBlandCallUtilAsScoped();
```

`AddBlandCallUtilAsSingleton()` is also available. Both registrations reuse the singleton Bland HTTP client.

## Create a call

```csharp
using Soenneker.Bland.Calls.Abstract;
using Soenneker.Bland.Calls.Requests;
using Soenneker.Bland.Calls.Responses;

var request = new CreateCallRequest
{
    PhoneNumber = "+12125550123",
    Task = "Confirm the customer's appointment for Tuesday at 2 PM.",
    FirstSentence = "Hi, I'm calling to confirm your appointment.",
    WaitForGreeting = true,
    MaxDuration = 5,
    Record = false
};

CreateCallResponse? created = await callUtil.Create(request, cancellationToken);
string? callId = created?.CallId;
```

`Create` initiates a real outbound call. Validate recipients, consent, calling hours, recording rules, and account spend controls in application code before invoking it.

## Retrieve and filter calls

```csharp
CallDetailsResponse? call = await callUtil.Get(callId, cancellationToken);

CallsResponse? completedCalls = await callUtil.Get(
    new CallFilterRequest
    {
        Completed = true,
        StartDate = "2026-08-01",
        EndDate = "2026-08-31",
        Limit = 100
    },
    cancellationToken);
```

Filter property names are serialized to Bland's query names, and null filters are omitted. Date filters are strings in `YYYY-MM-DD` format.

## Stop calls

```csharp
CallStatusResponse? stopped = await callUtil.Stop(callId, cancellationToken);

// Stops every active call for the authenticated account.
CallStatusResponse? stoppedAll = await callUtil.StopAllActive(cancellationToken);
```

`StopAllActive` is account-wide; do not use it as a substitute for tracking and stopping a specific call.

## API behavior

- `Create`, both `Get` overloads, `Stop`, and `StopAllActive` return nullable response models when no response body can be deserialized.
- Cancellation is passed through to client acquisition and the HTTP request.
- The utility does not validate phone numbers, call consent, webhook destinations, or combinations of request options.
- The dependency-injection container owns the shared Bland client and resolved utilities.
