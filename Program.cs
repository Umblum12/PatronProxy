using PatronProxy.Proxy;

APIProxy proxy = new APIProxy();

proxy.UserName = "admin";

string result = proxy.Request("/home");

Console.WriteLine(result);