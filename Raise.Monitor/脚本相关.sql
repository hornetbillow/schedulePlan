--序列
create sequence S_CRONEXPRESSION;
create sequence S_MONITORLOGRECORD;
create sequence S_RULECONFIG;
create sequence S_SYSLOG;
create sequence S_KEYVALUEITEM;
--表脚本
create table CRONEXPRESSION
(
  id              NUMBER(9),
  cron            VARCHAR2(50),
  crondescription VARCHAR2(200),
  constraint PK_CRONEXPRESSION_ID primary key (Id)
);

create table KEYVALUEITEM
(
  id      NUMBER(9) not null,
  name    VARCHAR2(50) not null,
  caption VARCHAR2(100) not null,
  key     NUMBER(9) not null,
  value   VARCHAR2(200) not null,
  status  NUMBER(9) not null,
  constraint PK_KEYVALUEITEM_ID primary key (Id)
);

create table MONITORLOGRECORD
(
  id                    NUMBER(9) not null,
  ruleconfigid          NUMBER(9) not null,
  operationtype         NUMBER(9),
  message               CLOB,
  createtime            DATE,
  executetime           NUMBER(19,4),
  statuscode            NUMBER(9),
  statuscodedescription VARCHAR2(200),
  responseMessage       CLOB,
  constraint PK_MONITORLOGRECORD_ID primary key (Id)
);

create table RULECONFIG
(
  id               NUMBER(9),
  cron             VARCHAR2(50),
  description      VARCHAR2(200),
  triggername      VARCHAR2(50),
  jobname          VARCHAR2(50),
  method           VARCHAR2(100),
  postbody         VARCHAR2(2000),
  servicename      VARCHAR2(60),
  author           VARCHAR2(30),
  contenttype      VARCHAR2(100),
  isauthentication NUMBER(1),
  username         VARCHAR2(30),
  password         VARCHAR2(30),
  groupname        VARCHAR2(100),
  address          VARCHAR2(200),
  status           NUMBER(9),
  iswebservice     NUMBER(1),
  uniquecode       VARCHAR2(32),
  RunStatus        NUMBER(1),
  constraint PK_RULECONFIG_ID primary key (Id)
);

create table SYSLOG
(
  id NUMBER(9) not null,
  createtime DATE,
  loglevel   VARCHAR2(20),
  stacktrace CLOB,
  callsite   VARCHAR2(200),
  message    CLOB,
  constraint PK_SYSLOG_ID primary key (Id)
);

--数据初始化
insert into KEYVALUEITEM (ID, NAME, CAPTION, KEY, VALUE, STATUS)values (s_keyvalueitem.nextval, 'Basic_Status', '基础数据状态', 99, '作废', 2);
insert into KEYVALUEITEM (ID, NAME, CAPTION, KEY, VALUE, STATUS)values (s_keyvalueitem.nextval, 'Basic_Status', '基础数据状态', 1, '有效', 2);
insert into KEYVALUEITEM (ID, NAME, CAPTION, KEY, VALUE, STATUS)values (s_keyvalueitem.nextval, 'Error_Type', '错误类型', 1, '业务错误', 2);
insert into KEYVALUEITEM (ID, NAME, CAPTION, KEY, VALUE, STATUS)values (s_keyvalueitem.nextval, 'Error_Type', '错误类型', 2, '系统错误', 2);
insert into KEYVALUEITEM (ID, NAME, CAPTION, KEY, VALUE, STATUS)values (s_keyvalueitem.nextval, 'MessageStatus', '消息状态', 1, '发生异常', 2);
insert into KEYVALUEITEM (ID, NAME, CAPTION, KEY, VALUE, STATUS)values (s_keyvalueitem.nextval, 'MessageStatus', '消息状态', 2, '调用成功', 2);
insert into KEYVALUEITEM (ID, NAME, CAPTION, KEY, VALUE, STATUS)values (s_keyvalueitem.nextval, 'YesOrNo', '是否', 1, '是', 2);
insert into KEYVALUEITEM (ID, NAME, CAPTION, KEY, VALUE, STATUS)values (s_keyvalueitem.nextval, 'YesOrNo', '是否', 1, '否', 2);
insert into KEYVALUEITEM (ID, NAME, CAPTION, KEY, VALUE, STATUS)values (s_keyvalueitem.nextval, 'OperationType', '数据操作类型', 0, '接收成功', 2);
insert into KEYVALUEITEM (ID, NAME, CAPTION, KEY, VALUE, STATUS)values (s_keyvalueitem.nextval, 'OperationType', '数据操作类型', 1, '处理成功', 2);
insert into KEYVALUEITEM (ID, NAME, CAPTION, KEY, VALUE, STATUS)values (s_keyvalueitem.nextval, 'OperationType', '数据操作类型', 99, '处理失败', 2);
insert into KEYVALUEITEM (ID, NAME, CAPTION, KEY, VALUE, STATUS)values (s_keyvalueitem.nextval, 'OperationType', '数据操作类型', 100, '未知数据', 2);
insert into KEYVALUEITEM (ID, NAME, CAPTION, KEY, VALUE, STATUS)values (s_keyvalueitem.nextval, 'Error_Type', '错误类型', 3, '其他错误', 2);
insert into KEYVALUEITEM (ID, NAME, CAPTION, KEY, VALUE, STATUS)values (s_keyvalueitem.nextval, 'Method_Type', '请求类型', 2, 'POST', 2);
insert into KEYVALUEITEM (ID, NAME, CAPTION, KEY, VALUE, STATUS)values (s_keyvalueitem.nextval, 'Method_Type', '请求类型', 1, 'GET', 2);

insert into KEYVALUEITEM (ID, NAME, CAPTION, KEY, VALUE, STATUS)values (s_keyvalueitem.nextval, 'Run_Status', '运行状态', 1, '停用', 2);
insert into KEYVALUEITEM (ID, NAME, CAPTION, KEY, VALUE, STATUS)values (s_keyvalueitem.nextval, 'Run_Status', '运行状态', 2, '启用', 2);

insert into CRONEXPRESSION (ID, CRON, CRONDESCRIPTION)values (s_cronexpression.nextval, '0 0 5 * * ?', '每天早晨5点触发');
insert into CRONEXPRESSION (ID, CRON, CRONDESCRIPTION)values (s_cronexpression.nextval, '0 15 10 ? * *', '每天上午10:15触发');
insert into CRONEXPRESSION (ID, CRON, CRONDESCRIPTION)values (s_cronexpression.nextval, '0 15 10 * * ?', '每天上午10:15触发 ');
insert into CRONEXPRESSION (ID, CRON, CRONDESCRIPTION)values (s_cronexpression.nextval, '0 15 10 * * ?', '每天上午10:15触发 ');
insert into CRONEXPRESSION (ID, CRON, CRONDESCRIPTION)values (s_cronexpression.nextval, '0 15 10 * * ? 2005', '2005年的每天上午10:15触发');
insert into CRONEXPRESSION (ID, CRON, CRONDESCRIPTION)values (s_cronexpression.nextval, '0 * 14 * * ?', '在每天下午2点到下午2:59期间的每1分钟触发');

insert into RULECONFIG (ID, CRON, DESCRIPTION, TRIGGERNAME, JOBNAME, METHOD, POSTBODY, SERVICENAME, AUTHOR, CONTENTTYPE, ISAUTHENTICATION, USERNAME, PASSWORD, GROUPNAME, ADDRESS, STATUS, ISWEBSERVICE, UNIQUECODE)
values (s_RULECONFIG.nextval, '0 0 5 * * ?', '保内代理库库存分析', 'InventoryAnalysisForPmsTrg', 'InventoryAnalysisForPmsJob', 'POST', '<?xml version="1.0" encoding="utf-8"?>
<soap:Envelope xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:soap="http://schemas.xmlsoap.org/soap/envelope/">
  <soap:Body>
    <InventoryAnalysisForPms xmlns="http://tempuri.org/">
      <EnterCode></EnterCode>
      <SyncNo></SyncNo>
      <SyncAmount>0</SyncAmount>
      <Data>
        <xsd:schema></xsd:schema></Data>
    </InventoryAnalysisForPms>
  </soap:Body>
</soap:Envelope>', 'InventoryAnalysisForPms', null, 'text/xml; charset=utf-8', 0, null, null, 'InventoryAnalysisForPmsGroup', 'http://172.24.7.24:8090/WebServiceCallHANA.asmx', 1, 1, '274F17FDA5EA4EF280BA9940D38538AF');

insert into RULECONFIG (ID, CRON, DESCRIPTION, TRIGGERNAME, JOBNAME, METHOD, POSTBODY, SERVICENAME, AUTHOR, CONTENTTYPE, ISAUTHENTICATION, USERNAME, PASSWORD, GROUPNAME, ADDRESS, STATUS, ISWEBSERVICE, UNIQUECODE)
values (s_RULECONFIG.nextval, '0 0 5 * * ?', '保内代理库库存当量', 'InventoryEquivalentStatForPmsTrg', 'InventoryEquivalentStatForPmsJob', 'POST', '<?xml version="1.0" encoding="utf-8"?>
<soap:Envelope xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:soap="http://schemas.xmlsoap.org/soap/envelope/">
  <soap:Body>
    <InventoryEquivalentStatForPms xmlns="http://tempuri.org/">
      <EnterCode></EnterCode>
      <SyncNo></SyncNo>
      <SyncAmount>0</SyncAmount>
      <Data>
        <xsd:schema></xsd:schema></Data>
    </InventoryEquivalentStatForPms>
  </soap:Body>
</soap:Envelope>', 'InventoryEquivalentStatForPms', null, 'text/xml; charset=utf-8', 0, null, null, 'InventoryEquivalentStatForPmsGroup', 'http://172.24.7.24:8090/WebServiceCallHANA.asmx', 1, 1, '7CA29FF5D98C4A2F8DB38F5ED36E1D9E');

insert into RULECONFIG (ID, CRON, DESCRIPTION, TRIGGERNAME, JOBNAME, METHOD, POSTBODY, SERVICENAME, AUTHOR, CONTENTTYPE, ISAUTHENTICATION, USERNAME, PASSWORD, GROUPNAME, ADDRESS, STATUS, ISWEBSERVICE, UNIQUECODE)
values (s_RULECONFIG.nextval, '0 0 5 * * ?', '保内代理库库存预警', 'InventoryWarningStatForPmsTrg', 'InventoryWarningStatForPmsJob', 'POST', '<?xml version="1.0" encoding="utf-8"?>
<soap:Envelope xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:soap="http://schemas.xmlsoap.org/soap/envelope/">
  <soap:Body>
    <InventoryWarningStatForPms xmlns="http://tempuri.org/">
      <EnterCode></EnterCode>
      <SyncNo></SyncNo>
      <SyncAmount>0</SyncAmount>
      <Data>
        <xsd:schema></xsd:schema></Data>
    </InventoryWarningStatForPms>
  </soap:Body>
</soap:Envelope>', 'InventoryWarningStatForPms', null, 'text/xml; charset=utf-8', 0, null, null, 'InventoryWarningStatForPmsGroup', 'http://172.24.7.24:8090/WebServiceCallHANA.asmx', 1, 1, 'EBD9C07FEA2B43DA81B668404AB422DF');

insert into RULECONFIG (ID, CRON, DESCRIPTION, TRIGGERNAME, JOBNAME, METHOD, POSTBODY, SERVICENAME, AUTHOR, CONTENTTYPE, ISAUTHENTICATION, USERNAME, PASSWORD, GROUPNAME, ADDRESS, STATUS, ISWEBSERVICE, UNIQUECODE)
values (s_RULECONFIG.nextval, '0 0 5 * * ?', '保内代理库采购计划', 'PartsPurchasePlanStatForPmsTrg', 'PartsPurchasePlanStatForPmsJob', 'POST', '<?xml version="1.0" encoding="utf-8"?>
<soap:Envelope xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:soap="http://schemas.xmlsoap.org/soap/envelope/">
  <soap:Body>
    <PartsPurchasePlanStatForPms xmlns="http://tempuri.org/">
      <EnterCode></EnterCode>
      <SyncNo></SyncNo>
      <SyncAmount>0</SyncAmount>
      <Data>
        <xsd:schema></xsd:schema></Data>
    </PartsPurchasePlanStatForPms>
  </soap:Body>
</soap:Envelope>', 'PartsPurchasePlanStatForPms', null, 'text/xml; charset=utf-8', 0, null, null, 'PartsPurchasePlanStatForPmsGroup', 'http://172.24.7.24:8090/WebServiceCallHANA.asmx', 1, 1, '917511F3601544D882D0A0E99005E36D');


              