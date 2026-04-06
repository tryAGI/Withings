<div class="docs-hero">
  <h1>Withings</h1>
  <p class="docs-hero-lead">Modern .NET SDK for Withings generated from the provider's OpenAPI definition with AutoSDK.</p>
  <div class="docs-badge-row">
    <a href="https://www.nuget.org/packages/Withings/"><img alt="Nuget package" src="https://img.shields.io/nuget/vpre/Withings"></a>
    <a href="https://github.com/tryAGI/Withings/actions/workflows/dotnet.yml"><img alt="dotnet" src="https://github.com/tryAGI/Withings/actions/workflows/dotnet.yml/badge.svg?branch=main"></a>
    <a href="https://github.com/tryAGI/Withings/blob/main/LICENSE.txt"><img alt="License: MIT" src="https://img.shields.io/github/license/tryAGI/Withings"></a>
    <a href="https://discord.gg/Ca2xhfBf3v"><img alt="Discord" src="https://img.shields.io/discord/1115206893015662663?label=Discord&amp;logo=discord&amp;logoColor=white&amp;color=d82679"></a>
  </div>
  <div class="docs-hero-actions">
    <a href="#usage">Get started</a>
    <a href="#support">Get support</a>
  </div>
</div>

<div class="docs-feature-grid">
  <div class="docs-feature-card">
    <h3>Generated from the source spec</h3>
    <p>Built from a manually-crafted OpenAPI spec covering Withings's Health API so the SDK stays close to the upstream API surface.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Auto-updated</h3>
    <p>Designed for fast regeneration and low-friction updates when the upstream API changes without breaking compatibility.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Modern .NET</h3>
    <p>Targets current .NET practices including nullability, trimming, NativeAOT awareness, and source-generated serialization.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Docs from examples</h3>
    <p>Examples stay in sync between the README, MkDocs site, and integration tests through the AutoSDK docs pipeline.</p>
  </div>
</div>

## Usage

```csharp
using Withings;

// Pass your OAuth2 access token (see Authentication below)
using var client = new WithingsClient(accessToken);
```

<!-- EXAMPLES:START -->
<!-- EXAMPLES:END -->

## Authentication

Withings uses **OAuth 2.0 Authorization Code** flow. This SDK handles API calls with a Bearer token — you are responsible for obtaining the access token via OAuth2.

### Step 1: Register your application

Register at the [Withings Partner Hub](https://developer.withings.com/) to get your `client_id` and `client_secret`.

### Step 2: Redirect the user to authorize

```
https://account.withings.com/oauth2_user/authorize2
  ?response_type=code
  &client_id=YOUR_CLIENT_ID
  &state=RANDOM_STATE
  &scope=user.info,user.metrics,user.activity
  &redirect_uri=YOUR_CALLBACK_URL
```

**Available scopes:** `user.info`, `user.metrics`, `user.activity`, `user.sleepevents`

### Step 3: Exchange the authorization code for tokens

```http
POST https://wbsapi.withings.net/v2/oauth2
Content-Type: application/x-www-form-urlencoded

action=requesttoken
&grant_type=authorization_code
&client_id=YOUR_CLIENT_ID
&client_secret=YOUR_CLIENT_SECRET
&code=AUTH_CODE_FROM_CALLBACK
&redirect_uri=YOUR_CALLBACK_URL
```

The response contains `access_token` (valid ~3 hours) and `refresh_token` (valid ~1 year).

### Step 4: Use the access token

```csharp
using var client = new WithingsClient(accessToken);

// Get body measurements (weight, BP, SpO2, etc.)
var measurements = await client.Measure.MeasureGetmeasAsync(...);

// Get sleep summary
var sleep = await client.Sleep.Sleepv2GetsummaryAsync(...);

// Get daily activity (steps, calories)
var activity = await client.Activity.Measurev2GetactivityAsync(...);
```

### Step 5: Refresh tokens

```http
POST https://wbsapi.withings.net/v2/oauth2
Content-Type: application/x-www-form-urlencoded

action=requesttoken
&grant_type=refresh_token
&client_id=YOUR_CLIENT_ID
&client_secret=YOUR_CLIENT_SECRET
&refresh_token=YOUR_REFRESH_TOKEN
```

## Support

<div class="docs-card-grid">
  <div class="docs-card">
    <h3>Bugs</h3>
    <p>Open an issue in <a href="https://github.com/tryAGI/Withings/issues">tryAGI/Withings</a>.</p>
  </div>
  <div class="docs-card">
    <h3>Ideas and questions</h3>
    <p>Use <a href="https://github.com/tryAGI/Withings/discussions">GitHub Discussions</a> for design questions and usage help.</p>
  </div>
  <div class="docs-card">
    <h3>Community</h3>
    <p>Join the <a href="https://discord.gg/Ca2xhfBf3v">tryAGI Discord</a> for broader discussion across SDKs.</p>
  </div>
</div>

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
