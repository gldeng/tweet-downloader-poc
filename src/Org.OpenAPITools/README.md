# Created with Openapi Generator

<a id="cli"></a>
## Run the following powershell command to generate the library

```ps1
$properties = @(
    'apiName=Api',
    'targetFramework=net9.0',
    'validatable=true',
    'nullableReferenceTypes=true',
    'hideGenerationTimestamp=true',
    'packageVersion=1.0.0',
    'packageAuthors=OpenAPI',
    'packageCompany=OpenAPI',
    'packageCopyright=No Copyright',
    'packageDescription=A library generated from a OpenAPI doc',
    'packageName=Org.OpenAPITools',
    'packageTags=',
    'packageTitle=OpenAPI Library'
) -join ","

$global = @(
    'apiDocs=true',
    'modelDocs=true',
    'apiTests=true',
    'modelTests=true'
) -join ","

java -jar "<path>/openapi-generator/modules/openapi-generator-cli/target/openapi-generator-cli.jar" generate `
    -g csharp-netcore `
    -i <your-swagger-file>.yaml `
    -o <your-output-folder> `
    --library generichost `
    --additional-properties $properties `
    --global-property $global `
    --git-host "github.com" `
    --git-repo-id "GIT_REPO_ID" `
    --git-user-id "GIT_USER_ID" `
    --release-note "Minor update"
    # -t templates
```

<a id="usage"></a>
## Using the library in your project

```cs
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace YourProject
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            var api = host.Services.GetRequiredService<IBookmarksApi>();
            GetUsersIdBookmarkFolderPostsApiResponse apiResponse = await api.GetUsersIdBookmarkFolderPostsAsync("todo");
            BookmarkFolderPostsResponse model = apiResponse.Ok();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
          .ConfigureApi((context, options) =>
          {
              // the type of token here depends on the api security specifications
              ApiKeyToken token = new("<your token>", ClientUtils.ApiKeyHeader.Authorization);
              options.AddTokens(token);

              // optionally choose the method the tokens will be provided with, default is RateLimitProvider
              options.UseProvider<RateLimitProvider<ApiKeyToken>, ApiKeyToken>();

              options.ConfigureJsonOptions((jsonOptions) =>
              {
                  // your custom converters if any
              });

              options.AddApiHttpClients(builder: builder => builder
                .AddRetryPolicy(2)
                .AddTimeoutPolicy(TimeSpan.FromSeconds(5))
                .AddCircuitBreakerPolicy(10, TimeSpan.FromSeconds(30))
                // add whatever middleware you prefer
              );
          });
    }
}
```
<a id="questions"></a>
## Questions

- What about HttpRequest failures and retries?
  If supportsRetry is enabled, you can configure Polly in the ConfigureClients method.
- How are tokens used?
  Tokens are provided by a TokenProvider class. The default is RateLimitProvider which will perform client side rate limiting.
  Other providers can be used with the UseProvider method.
- Does an HttpRequest throw an error when the server response is not Ok?
  It depends how you made the request. If the return type is ApiResponse<T> no error will be thrown, though the Content property will be null. 
  StatusCode and ReasonPhrase will contain information about the error.
  If the return type is T, then it will throw. If the return type is TOrDefault, it will return null.
- How do I validate requests and process responses?
  Use the provided On and After methods in the Api class from the namespace Org.OpenAPITools.Rest.DefaultApi.
  Or provide your own class by using the generic ConfigureApi method.

<a id="dependencies"></a>
## Dependencies

- [Microsoft.Extensions.Hosting](https://www.nuget.org/packages/Microsoft.Extensions.Hosting/) - 5.0.0 or later
- [Microsoft.Extensions.Http](https://www.nuget.org/packages/Microsoft.Extensions.Http/) - 5.0.0 or later
- [Microsoft.Extensions.Http.Polly](https://www.nuget.org/packages/Microsoft.Extensions.Http.Polly/) - 5.0.1 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 4.7.0 or later

<a id="documentation-for-authorization"></a>
## Documentation for Authorization


Authentication schemes defined for the API:
<a id="BearerToken"></a>
### BearerToken

- **Type**: Bearer Authentication

<a id="OAuth2UserToken"></a>
### OAuth2UserToken

- **Type**: OAuth
- **Flow**: accessCode
- **Authorization URL**: https://api.twitter.com/2/oauth2/authorize
- **Scopes**:   
- block.read: Accounts you’ve blocked.  
- bookmark.read: Allows an app to read bookmarked Tweets  
- bookmark.write: Allows an app to create and delete bookmarks  
- dm.read: All your Direct Messages  
- dm.write: Send and manage Direct Messages for you  
- follows.read: People who follow you and people who you follow.  
- follows.write: Follow and unfollow people for you.  
- like.read: Tweets you’ve liked and likes you can view.  
- like.write: Like and un-like Tweets for you.  
- list.read: Lists, list members, and list followers of lists you’ve created or are a member of, including private lists.  
- list.write: Create and manage Lists for you.  
- media.write: Upload media like photos and videos for you.  
- mute.read: Accounts you’ve muted.  
- mute.write: Mute and unmute accounts for you.  
- offline.access: App can request refresh token.  
- space.read: Access all of the Spaces you can see.  
- timeline.read: All the Custom Timelines you can see, including public Custom Timelines from other developers.  
- tweet.moderate.write: Hide and unhide replies to your Tweets.  
- tweet.read: All the Tweets you can see, including Tweets from protected accounts.  
- tweet.write: Tweet and retweet for you.  
- users.read: Any account you can see, including protected accounts. Any account you can see, including protected accounts.

<a id="UserToken"></a>
### UserToken



## Build
- SDK version: 1.0.0
- Generator version: 7.12.0-SNAPSHOT
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

## Api Information
- appName: Twitter API v2
- appVersion: 2.128
- appDescription: Twitter API v2 available endpoints

## [OpenApi Global properties](https://openapi-generator.tech/docs/globals)
- generateAliasAsModel: 
- supportingFiles: 
- models: omitted for brevity
- apis: omitted for brevity
- apiDocs: true
- modelDocs: true
- apiTests: true
- modelTests: true

## [OpenApi Generator Parameters](https://openapi-generator.tech/docs/generators/csharp-netcore)
- allowUnicodeIdentifiers: 
- apiName: Api
- caseInsensitiveResponseHeaders: 
- conditionalSerialization: false
- disallowAdditionalPropertiesIfNotPresent: 
- gitHost: github.com
- gitRepoId: GIT_REPO_ID
- gitUserId: GIT_USER_ID
- hideGenerationTimestamp: true
- interfacePrefix: I
- library: generichost
- licenseId: 
- modelPropertyNaming: 
- netCoreProjectFile: false
- nonPublicApi: false
- nullableReferenceTypes: true
- optionalAssemblyInfo: 
- optionalEmitDefaultValues: false
- optionalMethodArgument: true
- optionalProjectFile: 
- packageAuthors: OpenAPI
- packageCompany: OpenAPI
- packageCopyright: No Copyright
- packageDescription: A library generated from a OpenAPI doc
- packageGuid: {219DB112-CE3A-4888-9602-0092E6440212}
- packageName: Org.OpenAPITools
- packageTags: 
- packageTitle: OpenAPI Library
- packageVersion: 1.0.0
- releaseNote: Minor update
- returnICollection: false
- sortParamsByRequiredFlag: 
- sourceFolder: src
- targetFramework: net9.0
- useCollection: false
- useDateTimeOffset: false
- useOneOfDiscriminatorLookup: false
- validatable: true
For more information, please visit [https://developer.twitter.com/](https://developer.twitter.com/)

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project.
