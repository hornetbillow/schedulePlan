using System;
using System.IO;
using System.Net;
using System.Text;

namespace Raise.Monitor.Tools {
    public class HttpUtils {
        /// <summary>
        /// Soap协议Post方法
        /// </summary>
        /// <param name="uri">WebService地址</param>
        /// <param name="body">传入Soap协议格式数据</param>
        /// <returns>执行结果</returns>
        public static MessageInformation PostWebServiceWithoutCredential(string uri, string body) {
            var messageInformation = new MessageInformation();
            try {
                var webRequest = WebRequest.Create(uri);
                webRequest.ContentType = "text/xml; charset=utf-8";
                webRequest.Method = "POST";
                webRequest.Timeout = int.MaxValue;
                using(Stream requestStream = webRequest.GetRequestStream()) {
                    byte[] paramBytes = Encoding.UTF8.GetBytes(body);
                    requestStream.Write(paramBytes, 0, paramBytes.Length);
                }
                WebResponse webResponse = webRequest.GetResponse();

                // ReSharper disable once AssignNullToNotNullAttribute
                HttpWebResponse httpWebResponse = webRequest.GetResponse() as HttpWebResponse;
                if(httpWebResponse != null) {
                    messageInformation.ExecuteStatusCode((int)httpWebResponse.StatusCode, httpWebResponse.StatusDescription);
                }
                // ReSharper disable once AssignNullToNotNullAttribute
                using(StreamReader streamReader = new StreamReader(webResponse.GetResponseStream(), Encoding.UTF8)) {
                    messageInformation.ExecuteSuccess(streamReader.ReadToEnd());
                    messageInformation.ExecuteResponseMessage(streamReader.ReadToEnd());
                }
            } catch(WebException ex) {
                HttpWebResponse httpWebResponse = ex.Response as HttpWebResponse;
                if(httpWebResponse != null) {
                    messageInformation.ExecuteStatusCode((int)httpWebResponse.StatusCode, httpWebResponse.StatusDescription);
                }
                if(ex.Response?.GetResponseStream() != null) {
                    // ReSharper disable once AssignNullToNotNullAttribute
                    using(var streamReader = new StreamReader(ex.Response.GetResponseStream())) {
                        messageInformation.ExecuteResponseMessage(streamReader.ReadToEnd());
                    }
                }
                messageInformation.ExecuteError(ex.Message);
            } catch(Exception ex) {
                messageInformation.ExecuteError(ex.Message);
            }
            return messageInformation;
        }

        /// <summary>
        /// Soap协议Post方法,且需要oData身份认证
        /// </summary>
        /// <param name="uri">WebService地址</param>
        /// <param name="body">传入Soap协议格式数据</param>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>执行结果</returns>
        public static MessageInformation PostWebServiceWithCredential(string uri, string body, string userName, string password) {
            var messageInformation = new MessageInformation();
            try {
                var webRequest = WebRequest.Create(uri);
                CredentialCache mycache = new CredentialCache { { webRequest.RequestUri, "Basic", new NetworkCredential(userName, password) } };
                webRequest.Credentials = mycache;
                webRequest.ContentType = "text/xml; charset=utf-8";
                webRequest.Method = "POST";
                webRequest.Timeout = int.MaxValue;
                using(Stream requestStream = webRequest.GetRequestStream()) {
                    byte[] paramBytes = Encoding.UTF8.GetBytes(body);
                    requestStream.Write(paramBytes, 0, paramBytes.Length);
                }
                HttpWebResponse httpWebResponse = webRequest.GetResponse() as HttpWebResponse;
                if(httpWebResponse != null) {
                    messageInformation.ExecuteStatusCode((int)httpWebResponse.StatusCode, httpWebResponse.StatusDescription);
                }
                WebResponse webResponse = webRequest.GetResponse();
                // ReSharper disable once AssignNullToNotNullAttribute
                using(StreamReader streamReader = new StreamReader(webResponse.GetResponseStream(), Encoding.UTF8)) {
                    messageInformation.ExecuteSuccess(streamReader.ReadToEnd());
                    messageInformation.ExecuteResponseMessage(streamReader.ReadToEnd());
                }
            } catch(WebException ex) {
                HttpWebResponse httpWebResponse = ex.Response as HttpWebResponse;
                if(httpWebResponse != null) {
                    messageInformation.ExecuteStatusCode((int)httpWebResponse.StatusCode, httpWebResponse.StatusDescription);
                }
                if(ex.Response?.GetResponseStream() != null) {
                    // ReSharper disable once AssignNullToNotNullAttribute
                    using(var streamReader = new StreamReader(ex.Response.GetResponseStream())) {
                        messageInformation.ExecuteResponseMessage(streamReader.ReadToEnd());
                    }
                }
                messageInformation.ExecuteError(ex.Message);
            } catch(Exception ex) {
                messageInformation.ExecuteError(ex.Message);
            }
            return messageInformation;
        }

        /// <summary>
        /// 内部默认UTF-8编码
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="parameters">parameter1=12&amp;parameter2='参数2'</param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns>执行结果</returns>
        public static MessageInformation GetWithCredential(string uri, string parameters, string userName, string password) {
            var messageInformation = new MessageInformation();
            try {
                uri = $"{uri}?{parameters}";
                var webRequest = WebRequest.Create(uri);
                webRequest.Method = "GET";
                CredentialCache mycache = new CredentialCache {
                    {webRequest.RequestUri, "Basic", new NetworkCredential(userName, password)}
                };
                webRequest.Credentials = mycache;
                HttpWebResponse httpWebResponse = webRequest.GetResponse() as HttpWebResponse;
                if(httpWebResponse != null) {
                    messageInformation.ExecuteStatusCode((int)httpWebResponse.StatusCode, httpWebResponse.StatusDescription);
                }
                using(WebResponse response = webRequest.GetResponse()) {
                    // ReSharper disable once AssignNullToNotNullAttribute
                    using(var streamReader = new StreamReader(response.GetResponseStream())) {
                        messageInformation.ExecuteSuccess(streamReader.ReadToEnd());
                        messageInformation.ExecuteResponseMessage(streamReader.ReadToEnd());
                    }
                }
            } catch(WebException ex) {
                HttpWebResponse httpWebResponse = ex.Response as HttpWebResponse;
                if(httpWebResponse != null) {
                    messageInformation.ExecuteStatusCode((int)httpWebResponse.StatusCode, httpWebResponse.StatusDescription);
                }
                if(ex.Response?.GetResponseStream() != null) {
                    // ReSharper disable once AssignNullToNotNullAttribute
                    using(var streamReader = new StreamReader(ex.Response.GetResponseStream())) {
                        messageInformation.ExecuteResponseMessage(streamReader.ReadToEnd());
                    }
                }
                messageInformation.ExecuteError(ex.Message);
            } catch(Exception ex) {
                messageInformation.ExecuteError(ex.Message);
            }
            return messageInformation;
        }

        /// <summary>
        /// 内部默认UTF-8编码
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="parameters">parameter1=12&amp;parameter2='参数2'</param>
        /// <returns>执行结果</returns>
        public static MessageInformation GetWithoutCredential(string uri, string parameters) {
            var messageInformation = new MessageInformation();
            try {
                uri = $"{uri}?{parameters}";
                var webRequest = WebRequest.Create(uri);
                webRequest.Method = "GET";
                HttpWebResponse httpWebResponse = webRequest.GetResponse() as HttpWebResponse;
                if(httpWebResponse != null) {
                    messageInformation.ExecuteStatusCode((int)httpWebResponse.StatusCode, httpWebResponse.StatusDescription);
                }
                using(WebResponse response = webRequest.GetResponse()) {
                    // ReSharper disable once AssignNullToNotNullAttribute
                    using(var streamReader = new StreamReader(response.GetResponseStream())) {
                        messageInformation.ExecuteSuccess(streamReader.ReadToEnd());
                        messageInformation.ExecuteResponseMessage(streamReader.ReadToEnd());
                    }
                }
            } catch(WebException ex) {
                HttpWebResponse httpWebResponse = ex.Response as HttpWebResponse;
                if(httpWebResponse != null) {
                    messageInformation.ExecuteStatusCode((int)httpWebResponse.StatusCode, httpWebResponse.StatusDescription);
                }
                if(ex.Response?.GetResponseStream() != null) {
                    // ReSharper disable once AssignNullToNotNullAttribute
                    using(var streamReader = new StreamReader(ex.Response.GetResponseStream())) {
                        messageInformation.ExecuteResponseMessage(streamReader.ReadToEnd());
                    }
                }
                messageInformation.ExecuteError(ex.Message);
            } catch(Exception ex) {
                messageInformation.ExecuteError(ex.Message);
            }
            return messageInformation;
        }

        /// <summary>
        /// 内部默认UTF-8编码
        /// </summary>
        /// <param name="uri">浏览器地址</param>
        /// <param name="contentType">Content-Type</param>
        /// <param name="bodyParameters">POST请求时：常用的为JSON，XML已经在外部处理好</param>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>执行结果</returns>
        public static MessageInformation PostWithCredential(string uri, string contentType, string bodyParameters, string userName, string password) {
            var messageInformation = new MessageInformation();
            try {
                uri = $"{uri}?{bodyParameters}";
                var webRequest = WebRequest.Create(uri);
                webRequest.ContentType = contentType;
                webRequest.Method = "POST";
                CredentialCache mycache = new CredentialCache {
                {webRequest.RequestUri, "Basic", new NetworkCredential(userName, password)}
            };
                webRequest.Credentials = mycache;
                byte[] bytes = Encoding.UTF8.GetBytes(bodyParameters);
                webRequest.ContentLength = bytes.Length;
                using(Stream reqStream = webRequest.GetRequestStream()) {
                    reqStream.Write(bytes, 0, bytes.Length);
                }
                HttpWebResponse httpWebResponse = webRequest.GetResponse() as HttpWebResponse;
                if(httpWebResponse != null) {
                    messageInformation.ExecuteStatusCode((int)httpWebResponse.StatusCode, httpWebResponse.StatusDescription);
                }
                using(WebResponse response = webRequest.GetResponse()) {
                    // ReSharper disable once AssignNullToNotNullAttribute
                    using(var streamReader = new StreamReader(response.GetResponseStream())) {
                        messageInformation.ExecuteSuccess(streamReader.ReadToEnd());
                        messageInformation.ExecuteResponseMessage(streamReader.ReadToEnd());
                    }
                }
            } catch(WebException ex) {
                HttpWebResponse httpWebResponse = ex.Response as HttpWebResponse;
                if(httpWebResponse != null) {
                    messageInformation.ExecuteStatusCode((int)httpWebResponse.StatusCode, httpWebResponse.StatusDescription);
                }
                if(ex.Response?.GetResponseStream() != null) {
                    // ReSharper disable once AssignNullToNotNullAttribute
                    using(var streamReader = new StreamReader(ex.Response.GetResponseStream())) {
                        messageInformation.ExecuteResponseMessage(streamReader.ReadToEnd());
                    }
                }
                messageInformation.ExecuteError(ex.Message);
            } catch(Exception ex) {
                messageInformation.ExecuteError(ex.Message);
            }
            return messageInformation;
        }

        /// <summary>
        /// 内部默认UTF-8编码
        /// </summary>
        /// <param name="uri">浏览器地址</param>
        /// <param name="contentType">Content-Type</param>
        /// <param name="bodyParameters">POST请求时：常用的为JSON，XML已经在外部处理好</param>
        /// <returns>执行结果</returns>
        public static MessageInformation PostWithoutCredential(string uri, string contentType, string bodyParameters) {
            var messageInformation = new MessageInformation();
            try {
                uri = $"{uri}?{bodyParameters}";
                var webRequest = WebRequest.Create(uri);
                webRequest.ContentType = contentType;
                webRequest.Method = "POST";
                byte[] bytes = Encoding.UTF8.GetBytes(bodyParameters);
                webRequest.ContentLength = bytes.Length;
                using(Stream reqStream = webRequest.GetRequestStream()) {
                    reqStream.Write(bytes, 0, bytes.Length);
                }
                HttpWebResponse httpWebResponse = webRequest.GetResponse() as HttpWebResponse;
                if(httpWebResponse != null) {
                    messageInformation.ExecuteStatusCode((int)httpWebResponse.StatusCode, httpWebResponse.StatusDescription);
                }
                using(WebResponse response = webRequest.GetResponse()) {
                    // ReSharper disable once AssignNullToNotNullAttribute
                    using(var streamReader = new StreamReader(response.GetResponseStream())) {
                        messageInformation.ExecuteResponseMessage(streamReader.ReadToEnd());
                    }
                }
            } catch(WebException ex) {
                HttpWebResponse httpWebResponse = ex.Response as HttpWebResponse;
                if(httpWebResponse != null) {
                    messageInformation.ExecuteStatusCode((int)httpWebResponse.StatusCode, httpWebResponse.StatusDescription);
                }
                if(ex.Response?.GetResponseStream() != null) {
                    // ReSharper disable once AssignNullToNotNullAttribute
                    using(var streamReader = new StreamReader(ex.Response.GetResponseStream())) {
                        messageInformation.ExecuteResponseMessage(streamReader.ReadToEnd());
                    }
                }
                messageInformation.ExecuteError(ex.Message);
            } catch(Exception ex) {
                messageInformation.ExecuteError(ex.Message);
            }
            return messageInformation;
        }
    }
}
