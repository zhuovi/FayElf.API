# XiaoFeng.Mvc

![FAYELF.API](https://user-images.githubusercontent.com/16105174/197918392-29d40971-a8a2-4be4-ac17-323f1d0bed82.png)

![Nuget Downloads](https://img.shields.io/nuget/dt/FayElf.API?logo=nuget)
![Nuget](https://img.shields.io/nuget/v/FayElf.API?logo=nuget)
![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/FayElf.API?label=dev%20nuget&logo=nuget)

Nuget：FayElf.API

QQ群号：748408911 

QQ群二维码： 

![QQ 群](https://user-images.githubusercontent.com/16105174/198058269-0ea5928c-a2fc-4049-86da-cca2249229ae.png)

源码： https://github.com/zhuovi/xiaofeng

教程：https://www.yuque.com/fayelf/xiaofeng.mvc

.net core 基础类，快速开发CMS框架，真正的低代码平台，自带角色权限，WebAPI平台，后台管理，可托管到服务运行命令为:应用.exe install 服务名 服务说明,命令还有 delete 删除 start 启动  stop 停止。

## XiaoFeng库

XiaoFeng generator with [XiaoFeng](https://github.com/zhuovi/XiaoFeng).

## Install

.NET CLI

```
$ dotnet add package XiaoFeng.Mvc
```

Package Manager

```
PM> Install-Package XiaoFeng.Mvc
```

PackageReference

```
<PackageReference Include="XiaoFeng.Mvc" Version="3.0.2" />
```
# 使用方法

# 一、初始化
Program.cs 文件改成下面代码

```csharp
await XiaoFeng.Mvc.ApplicationManager.Load().RunAsync(() => XiaoFeng.Mvc.WebHost.Create(args, services =>
{
/*可配置services*/
}, app =>
{
/*
可配置app
引用中间件
配置路由
*/
}, endpoint =>
{
/*
配置路由
*/
}, true));
```
最后一个参数 init:false|true 这个参数是是否初始化数据库及配置，如果是true每次启动都会初始化数据库，如果数据库存在则更新，不存在则生成，如果是false是不会初如化数据库
接下来引用 System.Data.Sqlite 因为当前项目默认数据库用的是sqlite所以要引用，引用sqlite包后，启动项目即可。

启动成功后，直接在地址栏输入 http://localhost:8001/Admin 即可进行后台登录界面
帐号 为 admin 密码为 admin123456

项目启动后会在根目录自动生成Config,Log文件夹 
Log文件夹是项目日志文件存储目录
Config是当前项目的配置文件
这些配置文件在后台都可以管理

# 作者介绍



* 网址 : http://www.fayelf.com
* QQ : 7092734
* EMail : jacky@fayelf.com

