# Com.DaDaPush.Client.Api.DaDaPushMessageApi

All URIs are relative to *https://www.dadapush.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateMessage**](DaDaPushMessageApi.md#createmessage) | **POST** /api/v1/message | push Message to a Channel
[**DeleteMessage**](DaDaPushMessageApi.md#deletemessage) | **DELETE** /api/v1/message/{messageId} | delete a Channel Message
[**GetMessage**](DaDaPushMessageApi.md#getmessage) | **GET** /api/v1/message/{messageId} | get a Channel Message
[**GetMessages**](DaDaPushMessageApi.md#getmessages) | **GET** /api/v1/messages | get Message List



## CreateMessage

> ResultOfMessagePushResponse CreateMessage (MessagePushRequest body, string xChannelToken = null)

push Message to a Channel

<h2>Rate Limit:</h2><ul><li>1 request per 1s</li><li>30 request per 1m</li><li>500 request per 1h</li></ul><h2>Result code/errmsg List:</h2><ul><li>0: ok</li><li>1: server error</li><li>101: channel is exists</li><li>102: channel is not exists</li><li>103: channel token error</li><li>104: channel is not exists</li><li>105: message is not exists</li><li>204: bad request</li><li>205: permission deny</li><li>206: too many request, please after 5 minutes to try!</li><li>301: duplicate username/email</li><li>302: user is not exists</li><li>303: user password is error</li><li>304: client push token is error</li><li>305: user is disabled</li><li>306: your subscription is expired</li><li>307: user not subscribe channel</li></ul>

### Example

```csharp
using System.Diagnostics;
using Com.DaDaPush.Client.Api;
using Com.DaDaPush.Client.Client;
using Com.DaDaPush.Client.Model;

namespace Example
{
    public class CreateMessageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://www.dadapush.com";
            var apiInstance = new DaDaPushMessageApi(Configuration.Default);
            var body = new MessagePushRequest(); // MessagePushRequest | body
            var xChannelToken = xChannelToken_example;  // string | see: https://www.dadapush.com/channel/list (optional) 

            try
            {
                // push Message to a Channel
                ResultOfMessagePushResponse result = apiInstance.CreateMessage(body, xChannelToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DaDaPushMessageApi.CreateMessage: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MessagePushRequest**](MessagePushRequest.md)| body | 
 **xChannelToken** | **string**| see: https://www.dadapush.com/channel/list | [optional] 

### Return type

[**ResultOfMessagePushResponse**](ResultOfMessagePushResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteMessage

> Result DeleteMessage (long? messageId, string xChannelToken = null)

delete a Channel Message

<h2>Rate Limit:</h2><ul><li>10 request per 1s</li><li>100 request per 1m</li><li>1000 request per 1h</li></ul><h2>Result code/errmsg List:</h2><ul><li>0: ok</li><li>1: server error</li><li>101: channel is exists</li><li>102: channel is not exists</li><li>103: channel token error</li><li>104: channel is not exists</li><li>105: message is not exists</li><li>204: bad request</li><li>205: permission deny</li><li>206: too many request, please after 5 minutes to try!</li><li>301: duplicate username/email</li><li>302: user is not exists</li><li>303: user password is error</li><li>304: client push token is error</li><li>305: user is disabled</li><li>306: your subscription is expired</li><li>307: user not subscribe channel</li></ul>

### Example

```csharp
using System.Diagnostics;
using Com.DaDaPush.Client.Api;
using Com.DaDaPush.Client.Client;
using Com.DaDaPush.Client.Model;

namespace Example
{
    public class DeleteMessageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://www.dadapush.com";
            var apiInstance = new DaDaPushMessageApi(Configuration.Default);
            var messageId = 789;  // long? | messageId
            var xChannelToken = xChannelToken_example;  // string | see: https://www.dadapush.com/channel/list (optional) 

            try
            {
                // delete a Channel Message
                Result result = apiInstance.DeleteMessage(messageId, xChannelToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DaDaPushMessageApi.DeleteMessage: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageId** | **long?**| messageId | 
 **xChannelToken** | **string**| see: https://www.dadapush.com/channel/list | [optional] 

### Return type

[**Result**](Result.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetMessage

> ResultOfMessageObject GetMessage (long? messageId, string xChannelToken = null)

get a Channel Message

<h2>Rate Limit:</h2><ul><li>10 request per 1s</li><li>100 request per 1m</li><li>1000 request per 1h</li></ul><h2>Result code/errmsg List:</h2><ul><li>0: ok</li><li>1: server error</li><li>101: channel is exists</li><li>102: channel is not exists</li><li>103: channel token error</li><li>104: channel is not exists</li><li>105: message is not exists</li><li>204: bad request</li><li>205: permission deny</li><li>206: too many request, please after 5 minutes to try!</li><li>301: duplicate username/email</li><li>302: user is not exists</li><li>303: user password is error</li><li>304: client push token is error</li><li>305: user is disabled</li><li>306: your subscription is expired</li><li>307: user not subscribe channel</li></ul>

### Example

```csharp
using System.Diagnostics;
using Com.DaDaPush.Client.Api;
using Com.DaDaPush.Client.Client;
using Com.DaDaPush.Client.Model;

namespace Example
{
    public class GetMessageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://www.dadapush.com";
            var apiInstance = new DaDaPushMessageApi(Configuration.Default);
            var messageId = 789;  // long? | messageId
            var xChannelToken = xChannelToken_example;  // string | see: https://www.dadapush.com/channel/list (optional) 

            try
            {
                // get a Channel Message
                ResultOfMessageObject result = apiInstance.GetMessage(messageId, xChannelToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DaDaPushMessageApi.GetMessage: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageId** | **long?**| messageId | 
 **xChannelToken** | **string**| see: https://www.dadapush.com/channel/list | [optional] 

### Return type

[**ResultOfMessageObject**](ResultOfMessageObject.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetMessages

> ResultOfPageResponseOfMessageObject GetMessages (int? page, int? pageSize, string xChannelToken = null)

get Message List

<h2>Rate Limit:</h2><ul><li>1 request per 1s</li><li>45 request per 1m</li></ul><h2>Result code/errmsg List:</h2><ul><li>0: ok</li><li>1: server error</li><li>101: channel is exists</li><li>102: channel is not exists</li><li>103: channel token error</li><li>104: channel is not exists</li><li>105: message is not exists</li><li>204: bad request</li><li>205: permission deny</li><li>206: too many request, please after 5 minutes to try!</li><li>301: duplicate username/email</li><li>302: user is not exists</li><li>303: user password is error</li><li>304: client push token is error</li><li>305: user is disabled</li><li>306: your subscription is expired</li><li>307: user not subscribe channel</li></ul>

### Example

```csharp
using System.Diagnostics;
using Com.DaDaPush.Client.Api;
using Com.DaDaPush.Client.Client;
using Com.DaDaPush.Client.Model;

namespace Example
{
    public class GetMessagesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://www.dadapush.com";
            var apiInstance = new DaDaPushMessageApi(Configuration.Default);
            var page = 1;  // int? | greater than 1 (default to 1)
            var pageSize = 10;  // int? | range is 1,50 (default to 10)
            var xChannelToken = xChannelToken_example;  // string | see: https://www.dadapush.com/channel/list (optional) 

            try
            {
                // get Message List
                ResultOfPageResponseOfMessageObject result = apiInstance.GetMessages(page, pageSize, xChannelToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DaDaPushMessageApi.GetMessages: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| greater than 1 | [default to 1]
 **pageSize** | **int?**| range is 1,50 | [default to 10]
 **xChannelToken** | **string**| see: https://www.dadapush.com/channel/list | [optional] 

### Return type

[**ResultOfPageResponseOfMessageObject**](ResultOfPageResponseOfMessageObject.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

