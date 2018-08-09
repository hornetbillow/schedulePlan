# Quartz

#### 项目介绍
本项目目的在于完成公司的一些定时调度任务而开发，前期本打算使用Quartz集群方案实现，后发现项目并没有到一定要到集群方案的窘境，就自动跳过了该方案，考虑到一台服务器的异步方案实现。
*应用场景*
- 定时执行Job
- 定时调度接口
- 定时抽取数据 等场景使用

Quartz.net实现的调度在本人的另一开源地址[Quartz定时执行任务](https://gitee.com/xmsource/quartz.git)

该项目涉及的技术：
1. 调度配置工具

- ORM基于Dapper实现
- 日志采用Nlog实现
- 数据库Provider基于Devart
- 数据层整个基于1.1和1.3结合实现
- 将程序打包为桌面安装程序，采用Microsoft Visual Studio 2010、2015、2017 Installer Projects实现
2. 调度服务实现
- 采用Quartz.NET实现的作业调度
- 采用Topshelf开发服务集成Quartz实现的作业调度
- 志采用Nlog实现
- ORM基于Dapper实现
- 数据库Provider基于Devart
-  数据层整个基于1.1和1.3结合实现

### 调度配置项目目录

- Raise.Monitor
- Raise.Monitor.Extension
- Raise.Monitor.Model
- Raise.Monitor.Utils
- MonitorSetup

*调度配置项目类库介绍*
- Raise.Monitor为调度配置项目的启动项目
- Raise.Monitor.Extension项目的扩展项
- Raise.Monitor.Model和数据库交互所使用的实体对象
- Raise.Monitor.Utils存放项目的工具类
- MonitorSetup为打包安装目录

### Quartz调度项目目录
- Workbench
- Raise.Workbench.Utils
- Raise.Workbench.Service
- Raise.Workbench.Core
- Raise.Workbench.Common

*Quartz调度服务类库介绍*
- Workbench为服务的启动项目
- Raise.Workbench.Utils为项目的工具类存放
- Raise.Workbench.Service根据调度配置项目生成调度服务作业
- Raise.Workbench.Core核心命名空间，暂时存放接口
- Raise.Workbench.Common项目公共库

#### 安装教程
1. 在打包目录下取得Workbench\MonitorSetup\Debug\MonitorSetup.msi进行安装，如 
![安装界面](https://gitee.com/xmsource/workbench/attach_files/download?i=156644&u=http%3A%2F%2Ffiles.git.oschina.net%2Fgroup1%2FM00%2F04%2F7C%2FPaAvDFtmwzmAT3U7AAE0fkBb4Zc068.jpg%3Ftoken%3D5cd8c957aa8dcccaec31c2f7ef0eae70%26ts%3D1533463905%26attname%3D1.jpg)
2. 操作下一步，直到安装结束，桌面会生成Workbench图标，64位操作系统默认安装路径C:\Program Files (x86)\MonitorSetup
至此已经安装结束，下面是配置
3. 图为配置，如图
  [配置界面](https://gitee.com/xmsource/workbench/attach_files/download?i=156645&u=http%3A%2F%2Ffiles.git.oschina.net%2Fgroup1%2FM00%2F04%2F7C%2FPaAvDFtmw0KAf6s3AAI_f3Zq6pc872.jpg%3Ftoken%3D7f19c318296a36e673198a50b9696507%26ts%3D1533462784%26attname%3D2..jpg)
4. 打开该文件找到配置节ConnectionString，IsProduction，ServiceNames
- ConnectionString用以配置数据库连接
- IsProduction指定是否为生成环境，如果为生成环境，则不打印SQL，否则打印SQL到日志logs文件夹下
- ServiceNames本工具所管理的服务，默认只管理调度服务Workbench
5. 该工具有如下功能
- 新增、修改、作废、恢复、启用，停用指定的某项作业，
- 其他日志查看(可以查看该工具以及调度服务的工作异常情况)，
- 查看日志功能为查看作业调度情况下，接口返回的内容等项，
- 立即生效，常用于配置结束后，立即生效作业时使用
- 关闭调度，则会停止所有的作业调度(慎用)
- 
![界面](https://gitee.com/xmsource/workbench/attach_files/download?i=156646&u=http%3A%2F%2Ffiles.git.oschina.net%2Fgroup1%2FM00%2F04%2F7C%2FPaAvDFtmw0uAPzqMAAUJXN2KZCE174.jpg%3Ftoken%3Def94e155b6b19da8560006fbdd120275%26ts%3D1533462784%26attname%3D3.jpg)

### 调度服务安装
> 调度服务安装，在编译得到的最终产物目录Workbench\Workbench\bin\Debug找到Workbench.exe，注意：不能直接点击exe运行，该程序为服务，需要安装Windows 服务保证一直运行中

![图](https://gitee.com/xmsource/workbench/attach_files/download?i=156651&u=http%3A%2F%2Ffiles.git.oschina.net%2Fgroup1%2FM00%2F04%2F7C%2FPaAvDFtmy62ASTnFAAL0zI1VmbI992.jpg%3Ftoken%3De39e1d2c85986d2c21f8b8fd097d9cba%26ts%3D1533463469%26attname%3D4.jpg)


#### 参与贡献

- Sunrise

#### 参考文献
- [TopShelf](http://topshelf-project.com/)
- [Quartz.NET](https://www.quartz-scheduler.net/)
- [Dapper](https://www.nuget.org/packages/Dapper/)
- [Nlog](http://nlog-project.org/)

#### 注意事项
- Devart是收费项目，可以使用Oracle.ManagedDataAccess无缝替代,本项目已经用Oracle.ManagedDataAccess替代，由于Oracle.ManagedDataAccess本身存在的问题，如果商用，建议购买Devart

#### 联系我
- 邮箱：hornet_team@sina.com
- 交流群：492527782 
- 工具源码地址：https://gitee.com/xmsource/schedulePlan.git
- Quartz Windows服务源码地址：https://gitee.com/xmsource/quartz.git

*最近刚创建群，群人数较少，后续会升级为集群方案，如果喜欢，请给个star以及Fork我*