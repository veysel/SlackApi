# Slack Api

> Slack Api is a .net standard library that is very simple and fast to use.

## How to use ?

### Add Reference

> Add Reference SlackApi.dll

### Import Project

```c#
using SlackApi;
```

### Slack Url Define

```c#
SlackConfig.ApiUrl = "https://hooks.slack.com/services/Txxxxxxxx/Bxxxxxxxx/Axxxxxxxxxxxxxxxxxxxxxxx";
```

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