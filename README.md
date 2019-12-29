[![NuGet version](https://badge.fury.io/nu/SlackApi.Log.svg)](https://www.nuget.org/packages/SlackApi.Log/)

# ![SlackApi.Log](./content/logo.png) SlackApi.Log

> Slack Api is a .net standard library that is very simple and fast to use.

<br>

### Dependencies

*  [Newtonsoft.Json](https://www.newtonsoft.com/json)

<br>

## How to use ?

### Install SlackApi.Log

```
Install-Package SlackApi.Log

or

dotnet add package SlackApi.Log
```

<br>

### Import Project

```c#
using SlackApi;
```

<br>

### Slack Url Define

```c#
SlackConfig.ApiUrl = "https://hooks.slack.com/services/Txxxxxxxx/Bxxxxxxxx/Axxxxxxxxxxxxxxxxxxxxxxx";
```

<br>

### Slack Log Send

```c#
SlackLog.Default("Content");
SlackLog.Default("Content", "Title");
SlackLog.Default("Content", "Title", "Project Name");

SlackLog.Info("Content");
SlackLog.Info("Content", "Title");
SlackLog.Info("Content", "Title", "Project Name");

SlackLog.Success("Content");
SlackLog.Success("Content", "Title");
SlackLog.Success("Content", "Title", "Project Name");

SlackLog.Warning("Content");
SlackLog.Warning("Content", "Title");
SlackLog.Warning("Content", "Title", "Project Name");

SlackLog.Danger("Content");
SlackLog.Danger("Content", "Title");
SlackLog.Danger("Content", "Title", "Project Name");
```

<br>

### Sample Results

![SlackApiSample](https://raw.githubusercontent.com/veysel/SlackApi/master/content/sample1.png)