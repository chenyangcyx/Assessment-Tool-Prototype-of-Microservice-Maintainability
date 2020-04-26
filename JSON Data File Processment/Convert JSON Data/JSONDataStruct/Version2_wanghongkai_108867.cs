using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_JSON_Data.JSONDataStruct.Version2_wanghongkai_108867
{
    public class Rootobject
    {
        public string projectName { get; set; }
        public Repository[] repositories { get; set; }
    }

    public class Repository
    {
        public string gitUrl { get; set; }
        public Arc[] arcs { get; set; }
    }

    public class Arc
    {
        public Version version { get; set; }
        public Module[] modules { get; set; }
        public Microservice[] microservices { get; set; }
        public object[] topics { get; set; }
    }

    public class Version
    {
        public string sha { get; set; }
    }

    public class Module
    {
        public string path { get; set; }
        public string language { get; set; }
        public Package[] packages { get; set; }
    }

    public class Package
    {
        public string name { get; set; }
        public string[] dependency { get; set; }
    }

    public class Microservice
    {
        public string name { get; set; }
        public string path { get; set; }
        public string[] otherPaths { get; set; }
        public Interface[] interfaces { get; set; }
        public Call[] call { get; set; }
        public object[] publish { get; set; }
        public object[] subscribe { get; set; }
    }

    public class Interface
    {
        public string name { get; set; }
        public string[] filePaths { get; set; }
        public Inputparamstruct inputParamStruct { get; set; }
        public Outputparamstruct outputParamStruct { get; set; }
    }

    public class Inputparamstruct
    {
        public Id id { get; set; }
        public Orderno orderNo { get; set; }
        public Userid userId { get; set; }
        public Startcreatetime startCreateTime { get; set; }
        public Endcreatetime endCreateTime { get; set; }
        public Startpaymenttime startPaymentTime { get; set; }
        public Endpaymenttime endPaymentTime { get; set; }
        public Startclosingtime startClosingTime { get; set; }
        public Endclosingtime endClosingTime { get; set; }
        public Status status { get; set; }
        public Deleted deleted { get; set; }
        public Pageno pageNo { get; set; }
        public Pagesize pageSize { get; set; }
        public RequestparamOrderid RequestParamorderId { get; set; }
        public Orderid orderId { get; set; }
        public Logistics logistics { get; set; }
        public Logisticsno logisticsNo { get; set; }
        public Orderitemids orderItemIds { get; set; }
        public RequestparamRemark RequestParamremark { get; set; }
        public RequestparamReasons RequestParamreasons { get; set; }
        public RequestparamOtherreasons RequestParamotherReasons { get; set; }
        public RequestparamOrderitemid RequestParamorderItemId { get; set; }
        public RequestparamPayamount RequestParampayAmount { get; set; }
        public Skuid skuId { get; set; }
        public Quantity quantity { get; set; }
        public Price price { get; set; }
        public Areano areaNo { get; set; }
        public Name name { get; set; }
        public Mobile mobile { get; set; }
        public Address address { get; set; }
        public Orderitemid orderItemId { get; set; }
        public Orderreason orderReason { get; set; }
        public Otherreasons otherReasons { get; set; }
        public Ordertype orderType { get; set; }
        public Orderlogisticsid orderLogisticsId { get; set; }
        public Hasreturnexchange hasReturnExchange { get; set; }
        public Remark remark { get; set; }
        public Orderitems orderItems { get; set; }
        public Payamount payAmount { get; set; }
        public Integer Integer { get; set; }
        public Remake remake { get; set; }
        public RequestparamNickname RequestParamnickname { get; set; }
        public RequestparamPageno RequestParampageNo { get; set; }
        public RequestparamPagesize RequestParampageSize { get; set; }
        public RequestparamUsername RequestParamusername { get; set; }
        public RequestparamPassword RequestParampassword { get; set; }
        public RequestparamId RequestParamid { get; set; }
        public RequestparamStatus RequestParamstatus { get; set; }
        public RequestparamRoleids RequestParamroleIds { get; set; }
        public RequestparamEnumvalue RequestParamenumValue { get; set; }
        public RequestparamValue RequestParamvalue { get; set; }
        public RequestparamDisplayname RequestParamdisplayName { get; set; }
        public RequestparamSort RequestParamsort { get; set; }
        public RequestparamMemo RequestParammemo { get; set; }
        public RequestparamName RequestParamname { get; set; }
        public RequestparamType RequestParamtype { get; set; }
        public RequestparamPid RequestParampid { get; set; }
        public RequestparamHandler RequestParamhandler { get; set; }
        public RequestparamResourceids RequestParamresourceIds { get; set; }
        public Nickname nickname { get; set; }
        public Adminid adminId { get; set; }
        public Username username { get; set; }
        public Password password { get; set; }
        public Updateadminid updateAdminId { get; set; }
        public Roleids roleIds { get; set; }
        public Enumvalue enumValue { get; set; }
        public Value value { get; set; }
        public Displayname displayName { get; set; }
        public Sort sort { get; set; }
        public Memo memo { get; set; }
        public Datadictid dataDictId { get; set; }
        public Accesstoken accessToken { get; set; }
        public Url url { get; set; }
        public Type type { get; set; }
        public Pid pid { get; set; }
        public Handler handler { get; set; }
        public Resourceid resourceId { get; set; }
        public Roleid roleId { get; set; }
        public Resourceids resourceIds { get; set; }
        public Uri uri { get; set; }
        public Querystring queryString { get; set; }
        public Method method { get; set; }
        public Useragent userAgent { get; set; }
        public Starttime startTime { get; set; }
        public Responsetime responseTime { get; set; }
        public Ip ip { get; set; }
        public Title title { get; set; }
        public Picurl picUrl { get; set; }
        public Preferentialtype preferentialType { get; set; }
        public Description description { get; set; }
        public Quota quota { get; set; }
        public Total total { get; set; }
        public Priceavailable priceAvailable { get; set; }
        public Rangetype rangeType { get; set; }
        public Rangevalues rangeValues { get; set; }
        public Datetype dateType { get; set; }
        public Validstarttime validStartTime { get; set; }
        public Validendtime validEndTime { get; set; }
        public Fixedbeginterm fixedBeginTerm { get; set; }
        public Fixedendterm fixedEndTerm { get; set; }
        public Percentoff percentOff { get; set; }
        public Priceoff priceOff { get; set; }
        public Discountpricelimit discountPriceLimit { get; set; }
        public Productspuid productSpuId { get; set; }
        public Bannerpagedto bannerPageDTO { get; set; }
        public Banneradddto bannerAddDTO { get; set; }
        public Bannerupdatedto bannerUpdateDTO { get; set; }
        public Bannerid bannerId { get; set; }
        public Coupontemplatepagedto couponTemplatePageDTO { get; set; }
        public Couponcodetemplateadddto couponCodeTemplateAddDTO { get; set; }
        public Couponcardtemplateadddto couponCardTemplateAddDTO { get; set; }
        public Couponcodetemplateupdatedto couponCodeTemplateUpdateDTO { get; set; }
        public Couponcardtemplateupdatedto couponCardTemplateUpdateDTO { get; set; }
        public Coupontemplateid couponTemplateId { get; set; }
        public Couponcardid couponCardId { get; set; }
        public Usedorderid usedOrderId { get; set; }
        public Usedprice usedPrice { get; set; }
        public Code code { get; set; }
        public Productrecommendpagedto productRecommendPageDTO { get; set; }
        public Productrecommendadddto productRecommendAddDTO { get; set; }
        public Productrecommendupdatedto productRecommendUpdateDTO { get; set; }
        public Productrecommendid productRecommendId { get; set; }
        public RequestparamAvatar RequestParamavatar { get; set; }
        public RequestparamMobile RequestParammobile { get; set; }
        public RequestparamCode RequestParamcode { get; set; }
        public Useraddressaddpo userAddressAddPO { get; set; }
        public Useraddressupdatepo userAddressUpdatePO { get; set; }
        public Useraccesslogadddto userAccessLogAddDTO { get; set; }
        public Useraddressadddto userAddressAddDTO { get; set; }
        public Addressid addressId { get; set; }
        public Userpagedto userPageDTO { get; set; }
        public Userupdatedto userUpdateDTO { get; set; }
        public Appid appId { get; set; }
        public Paychannel payChannel { get; set; }
        public Order_No order_no { get; set; }
        public Time_Paid time_paid { get; set; }
        public Transaction_No transaction_no { get; set; }
        public Attrid attrId { get; set; }
        public Sellpoint sellPoint { get; set; }
        public Cid cid { get; set; }
        public Picurls picUrls { get; set; }
        public Visible visible { get; set; }
        public Skustr skuStr { get; set; }
    }

    public class Id
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderno
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Startcreatetime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Endcreatetime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Startpaymenttime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Endpaymenttime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Startclosingtime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Endclosingtime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Deleted
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pageno
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class RequestparamOrderid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logistics
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logisticsno
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderitemids
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class RequestparamRemark
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class RequestparamReasons
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class RequestparamOtherreasons
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class RequestparamOrderitemid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class RequestparamPayamount
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Skuid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Quantity
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Price
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Areano
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mobile
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Address
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderitemid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderreason
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Otherreasons
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Ordertype
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderlogisticsid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Hasreturnexchange
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Remark
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderitems
    {
        public string type { get; set; }
        public Struct _struct { get; set; }
    }

    public class Struct
    {
        public Skuid1 skuId { get; set; }
        public Quantity1 quantity { get; set; }
    }

    public class Skuid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Quantity1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Payamount
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Integer
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Remake
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class RequestparamNickname
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class RequestparamPageno
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class RequestparamPagesize
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class RequestparamUsername
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class RequestparamPassword
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class RequestparamId
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class RequestparamStatus
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class RequestparamRoleids
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class RequestparamEnumvalue
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class RequestparamValue
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class RequestparamDisplayname
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class RequestparamSort
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class RequestparamMemo
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class RequestparamName
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class RequestparamType
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class RequestparamPid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class RequestparamHandler
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class RequestparamResourceids
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Nickname
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Adminid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Username
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Updateadminid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Roleids
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Enumvalue
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Value
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Displayname
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Memo
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Datadictid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Accesstoken
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Type
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Handler
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Resourceid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Roleid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Resourceids
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uri
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Querystring
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Method
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Useragent
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Starttime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Responsetime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Ip
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Title
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Picurl
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialtype
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Description
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Quota
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Total
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Priceavailable
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rangetype
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rangevalues
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Datetype
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Validstarttime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Validendtime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fixedbeginterm
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fixedendterm
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Percentoff
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Priceoff
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Discountpricelimit
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Productspuid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Bannerpagedto
    {
        public string type { get; set; }
        public Struct1 _struct { get; set; }
    }

    public class Struct1
    {
        public Title1 title { get; set; }
        public Pageno1 pageNo { get; set; }
        public Pagesize1 pageSize { get; set; }
    }

    public class Title1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pageno1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Banneradddto
    {
        public string type { get; set; }
        public Struct2 _struct { get; set; }
    }

    public class Struct2
    {
        public Title2 title { get; set; }
        public Url1 url { get; set; }
        public Picurl1 picUrl { get; set; }
        public Sort1 sort { get; set; }
        public Memo1 memo { get; set; }
    }

    public class Title2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Picurl1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Memo1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Bannerupdatedto
    {
        public string type { get; set; }
        public Struct3 _struct { get; set; }
    }

    public class Struct3
    {
        public Id1 id { get; set; }
        public Title3 title { get; set; }
        public Url2 url { get; set; }
        public Picurl2 picUrl { get; set; }
        public Sort2 sort { get; set; }
        public Memo2 memo { get; set; }
    }

    public class Id1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Title3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Picurl2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Memo2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Bannerid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Coupontemplatepagedto
    {
        public string type { get; set; }
        public Struct4 _struct { get; set; }
    }

    public class Struct4
    {
        public Type1 type { get; set; }
        public Title4 title { get; set; }
        public Status1 status { get; set; }
        public Preferentialtype1 preferentialType { get; set; }
        public Pageno2 pageNo { get; set; }
        public Pagesize2 pageSize { get; set; }
    }

    public class Type1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Title4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialtype1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pageno2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Couponcodetemplateadddto
    {
        public string type { get; set; }
        public Struct5 _struct { get; set; }
    }

    public class Struct5
    {
    }

    public class Couponcardtemplateadddto
    {
        public string type { get; set; }
        public Struct6 _struct { get; set; }
    }

    public class Struct6
    {
        public Title5 title { get; set; }
        public Description1 description { get; set; }
        public Quota1 quota { get; set; }
        public Total1 total { get; set; }
        public Priceavailable1 priceAvailable { get; set; }
        public Rangetype1 rangeType { get; set; }
        public Rangevalues1 rangeValues { get; set; }
        public Datetype1 dateType { get; set; }
        public Validstarttime1 validStartTime { get; set; }
        public Validendtime1 validEndTime { get; set; }
        public Fixedbeginterm1 fixedBeginTerm { get; set; }
        public Fixedendterm1 fixedEndTerm { get; set; }
        public Preferentialtype2 preferentialType { get; set; }
        public Percentoff1 percentOff { get; set; }
        public Priceoff1 priceOff { get; set; }
        public Discountpricelimit1 discountPriceLimit { get; set; }
    }

    public class Title5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Description1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Quota1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Total1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Priceavailable1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rangetype1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rangevalues1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Datetype1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Validstarttime1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Validendtime1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fixedbeginterm1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fixedendterm1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialtype2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Percentoff1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Priceoff1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Discountpricelimit1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Couponcodetemplateupdatedto
    {
        public string type { get; set; }
        public Struct7 _struct { get; set; }
    }

    public class Struct7
    {
    }

    public class Couponcardtemplateupdatedto
    {
        public string type { get; set; }
        public Struct8 _struct { get; set; }
    }

    public class Struct8
    {
        public Id2 id { get; set; }
        public Title6 title { get; set; }
        public Description2 description { get; set; }
        public Quota2 quota { get; set; }
        public Total2 total { get; set; }
        public Rangetype2 rangeType { get; set; }
        public Rangevalues2 rangeValues { get; set; }
    }

    public class Id2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Title6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Description2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Quota2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Total2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rangetype2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rangevalues2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Coupontemplateid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Couponcardid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usedorderid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usedprice
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Code
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Productrecommendpagedto
    {
        public string type { get; set; }
        public Struct9 _struct { get; set; }
    }

    public class Struct9
    {
        public Type2 type { get; set; }
        public Pageno3 pageNo { get; set; }
        public Pagesize3 pageSize { get; set; }
    }

    public class Type2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pageno3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Productrecommendadddto
    {
        public string type { get; set; }
        public Struct10 _struct { get; set; }
    }

    public class Struct10
    {
        public Type3 type { get; set; }
        public Productspuid1 productSpuId { get; set; }
        public Sort3 sort { get; set; }
        public Memo3 memo { get; set; }
    }

    public class Type3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Productspuid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Memo3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Productrecommendupdatedto
    {
        public string type { get; set; }
        public Struct11 _struct { get; set; }
    }

    public class Struct11
    {
        public Id3 id { get; set; }
        public Type4 type { get; set; }
        public Productspuid2 productSpuId { get; set; }
        public Sort4 sort { get; set; }
        public Memo4 memo { get; set; }
    }

    public class Id3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Type4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Productspuid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Memo4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Productrecommendid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class RequestparamAvatar
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class RequestparamMobile
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class RequestparamCode
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Useraddressaddpo
    {
        public string type { get; set; }
        public Struct12 _struct { get; set; }
    }

    public class Struct12
    {
        public Areano1 areaNo { get; set; }
        public Name1 name { get; set; }
        public Mobile1 mobile { get; set; }
        public Address1 address { get; set; }
    }

    public class Areano1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mobile1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Address1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Useraddressupdatepo
    {
        public string type { get; set; }
        public Struct13 _struct { get; set; }
    }

    public class Struct13
    {
        public Id4 id { get; set; }
        public Areano2 areaNo { get; set; }
        public Name2 name { get; set; }
        public Mobile2 mobile { get; set; }
        public Address2 address { get; set; }
    }

    public class Id4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Areano2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mobile2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Address2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Useraccesslogadddto
    {
        public string type { get; set; }
        public Struct14 _struct { get; set; }
    }

    public class Struct14
    {
        public Userid1 userId { get; set; }
        public Uri1 uri { get; set; }
        public Querystring1 queryString { get; set; }
        public Method1 method { get; set; }
        public Useragent1 userAgent { get; set; }
        public Ip1 ip { get; set; }
        public Starttime1 startTime { get; set; }
        public Responsetime1 responseTime { get; set; }
    }

    public class Userid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Uri1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Querystring1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Method1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Useragent1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Ip1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Starttime1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Responsetime1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Useraddressadddto
    {
        public string type { get; set; }
        public Struct15 _struct { get; set; }
    }

    public class Struct15
    {
        public Userid2 userId { get; set; }
        public Areano3 areaNo { get; set; }
        public Name3 name { get; set; }
        public Mobile3 mobile { get; set; }
        public Address3 address { get; set; }
        public Id5 id { get; set; }
    }

    public class Userid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Areano3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mobile3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Address3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Id5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Addressid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userpagedto
    {
        public string type { get; set; }
        public Struct16 _struct { get; set; }
    }

    public class Struct16
    {
        public Nickname1 nickname { get; set; }
        public Pageno4 pageNo { get; set; }
        public Pagesize4 pageSize { get; set; }
    }

    public class Nickname1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pageno4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userupdatedto
    {
        public string type { get; set; }
        public Struct17 _struct { get; set; }
    }

    public class Struct17
    {
        public Id6 id { get; set; }
        public Nickname2 nickname { get; set; }
        public Avatar avatar { get; set; }
    }

    public class Id6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Nickname2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Avatar
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Appid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Paychannel
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Order_No
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Time_Paid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Transaction_No
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Attrid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sellpoint
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Cid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Picurls
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Visible
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Skustr
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Outputparamstruct
    {
        public Code1 code { get; set; }
        public Message message { get; set; }
        public Data data { get; set; }
        public string type { get; set; }
        public Struct34 _struct { get; set; }
        public Accesstoken2 accessToken { get; set; }
        public Refreshtoken1 refreshToken { get; set; }
        public Expiresin1 expiresIn { get; set; }
        public Result result { get; set; }
        public Boolean Boolean { get; set; }
    }

    public class Code1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Message
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Data
    {
        public object type { get; set; }
        public Struct18 _struct { get; set; }
        public string name { get; set; }
        public Total5 total { get; set; }
        public List1 list { get; set; }
        public Id21 id { get; set; }
        public Title10 title { get; set; }
        public Url6 url { get; set; }
        public Picurl7 picUrl { get; set; }
        public Sort8 sort { get; set; }
        public Status10 status { get; set; }
        public Memo8 memo { get; set; }
        public Createtime8 createTime { get; set; }
        public Description7 description { get; set; }
        public Codetype3 codeType { get; set; }
        public Quota6 quota { get; set; }
        public Priceavailable5 priceAvailable { get; set; }
        public Rangetype6 rangeType { get; set; }
        public Rangevalues6 rangeValues { get; set; }
        public Datetype5 dateType { get; set; }
        public Validstarttime5 validStartTime { get; set; }
        public Validendtime5 validEndTime { get; set; }
        public Fixedstartterm3 fixedStartTerm { get; set; }
        public Fixedendterm5 fixedEndTerm { get; set; }
        public Preferentialtype6 preferentialType { get; set; }
        public Percentoff5 percentOff { get; set; }
        public Priceoff5 priceOff { get; set; }
        public Discountpricelimit5 discountPriceLimit { get; set; }
        public Statfetchnum3 statFetchNum { get; set; }
        public Productspuid6 productSpuId { get; set; }
        public Users1 users { get; set; }
        public Count2 count { get; set; }
    }

    public class Struct18
    {
        public Total3 total { get; set; }
        public Orders orders { get; set; }
        public Id10 id { get; set; }
        public Orderid3 orderId { get; set; }
        public Orderno3 orderNo { get; set; }
        public Skuid3 skuId { get; set; }
        public Skuname1 skuName { get; set; }
        public Skuimage1 skuImage { get; set; }
        public Quantity3 quantity { get; set; }
        public Payamount2 payAmount { get; set; }
        public Paymenttime2 paymentTime { get; set; }
        public Deliverytime2 deliveryTime { get; set; }
        public Receivertime2 receiverTime { get; set; }
        public Closingtime2 closingTime { get; set; }
        public Hasreturnexchange3 hasReturnExchange { get; set; }
        public Deliverytype1 deliveryType { get; set; }
        public Status4 status { get; set; }
        public Createtime1 createTime { get; set; }
        public Updatetime1 updateTime { get; set; }
        public Deleted2 deleted { get; set; }
        public Areano5 areaNo { get; set; }
        public Name5 name { get; set; }
        public Mobile5 mobile { get; set; }
        public Type6 type { get; set; }
        public Address5 address { get; set; }
        public Originprice1 originPrice { get; set; }
        public Buyprice2 buyPrice { get; set; }
        public Presentprice2 presentPrice { get; set; }
        public Buytotal1 buyTotal { get; set; }
        public Discounttotal1 discountTotal { get; set; }
        public Presenttotal1 presentTotal { get; set; }
        public Handler1 handler { get; set; }
        public Pid1 pid { get; set; }
        public Sort5 sort { get; set; }
        public Displayname1 displayName { get; set; }
        public Children children { get; set; }
        public List list { get; set; }
        public Username2 username { get; set; }
        public Nickname4 nickname { get; set; }
        public Assigned assigned { get; set; }
        public Enumvalue1 enumValue { get; set; }
        public Value1 value { get; set; }
        public Memo6 memo { get; set; }
        public Values values { get; set; }
        public Accesstoken1 accessToken { get; set; }
        public Refreshtoken refreshToken { get; set; }
        public Expiresin expiresIn { get; set; }
        public Count count { get; set; }
        public Roles roles { get; set; }
        public Adminid1 adminId { get; set; }
        public Roleids1 roleIds { get; set; }
        public Title8 title { get; set; }
        public Url4 url { get; set; }
        public Picurl4 picUrl { get; set; }
        public Description4 description { get; set; }
        public Codetype1 codeType { get; set; }
        public Quota4 quota { get; set; }
        public Priceavailable3 priceAvailable { get; set; }
        public Rangetype4 rangeType { get; set; }
        public Rangevalues4 rangeValues { get; set; }
        public Datetype3 dateType { get; set; }
        public Validstarttime3 validStartTime { get; set; }
        public Validendtime3 validEndTime { get; set; }
        public Fixedstartterm1 fixedStartTerm { get; set; }
        public Fixedendterm3 fixedEndTerm { get; set; }
        public Preferentialtype4 preferentialType { get; set; }
        public Percentoff3 percentOff { get; set; }
        public Priceoff3 priceOff { get; set; }
        public Discountpricelimit3 discountPriceLimit { get; set; }
        public Statfetchnum1 statFetchNum { get; set; }
        public Productspuid4 productSpuId { get; set; }
        public Key key { get; set; }
        public Users users { get; set; }
        public Userid4 userId { get; set; }
        public Avatar2 avatar { get; set; }
        public Invokeresponse invokeResponse { get; set; }
        public Attrs attrs { get; set; }
        public Attrid1 attrId { get; set; }
        public Sellpoint3 sellPoint { get; set; }
        public Cid2 cid { get; set; }
        public Picurls3 picUrls { get; set; }
        public Visible2 visible { get; set; }
        public Skus skus { get; set; }
        public Spus spus { get; set; }
    }

    public class Total3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orders
    {
        public string type { get; set; }
        public Struct19 _struct { get; set; }
    }

    public class Struct19
    {
        public Id7 id { get; set; }
        public Userid3 userId { get; set; }
        public Orderno1 orderNo { get; set; }
        public Buyprice buyPrice { get; set; }
        public Discountprice discountPrice { get; set; }
        public Logisticsprice logisticsPrice { get; set; }
        public Presentprice presentPrice { get; set; }
        public Payamount1 payAmount { get; set; }
        public Paymenttime paymentTime { get; set; }
        public Deliverytime deliveryTime { get; set; }
        public Receivertime receiverTime { get; set; }
        public Closingtime closingTime { get; set; }
        public Hasreturnexchange1 hasReturnExchange { get; set; }
        public Status2 status { get; set; }
        public Remark1 remark { get; set; }
        public Orderitems1 orderItems { get; set; }
        public Orderrecipient orderRecipient { get; set; }
    }

    public class Id7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userid3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderno1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Buyprice
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Discountprice
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logisticsprice
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Presentprice
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Payamount1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Paymenttime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Deliverytime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Receivertime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Closingtime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Hasreturnexchange1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Remark1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderitems1
    {
        public string type { get; set; }
        public Struct20 _struct { get; set; }
    }

    public class Struct20
    {
        public Id8 id { get; set; }
        public Orderid1 orderId { get; set; }
        public Orderno2 orderNo { get; set; }
        public Skuid2 skuId { get; set; }
        public Skuname skuName { get; set; }
        public Skuimage skuImage { get; set; }
        public Quantity2 quantity { get; set; }
        public Originprice originPrice { get; set; }
        public Buyprice1 buyPrice { get; set; }
        public Presentprice1 presentPrice { get; set; }
        public Buytotal buyTotal { get; set; }
        public Discounttotal discountTotal { get; set; }
        public Presenttotal presentTotal { get; set; }
        public Paymenttime1 paymentTime { get; set; }
        public Deliverytime1 deliveryTime { get; set; }
        public Receivertime1 receiverTime { get; set; }
        public Closingtime1 closingTime { get; set; }
        public Hasreturnexchange2 hasReturnExchange { get; set; }
        public Deliverytype deliveryType { get; set; }
        public Status3 status { get; set; }
        public Createtime createTime { get; set; }
        public Updatetime updateTime { get; set; }
        public Deleted1 deleted { get; set; }
    }

    public class Id8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderno2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Skuid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Skuname
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Skuimage
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Quantity2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Originprice
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Buyprice1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Presentprice1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Buytotal
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Discounttotal
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Presenttotal
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Paymenttime1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Deliverytime1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Receivertime1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Closingtime1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Hasreturnexchange2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Deliverytype
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Createtime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Updatetime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Deleted1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderrecipient
    {
        public string type { get; set; }
        public Struct21 _struct { get; set; }
    }

    public class Struct21
    {
        public Id9 id { get; set; }
        public Orderid2 orderId { get; set; }
        public Areano4 areaNo { get; set; }
        public Name4 name { get; set; }
        public Mobile4 mobile { get; set; }
        public Type5 type { get; set; }
        public Address4 address { get; set; }
    }

    public class Id9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Areano4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mobile4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Type5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Address4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Id10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderid3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderno3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Skuid3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Skuname1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Skuimage1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Quantity3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Payamount2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Paymenttime2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Deliverytime2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Receivertime2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Closingtime2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Hasreturnexchange3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Deliverytype1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Createtime1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Updatetime1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Deleted2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Areano5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mobile5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Type6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Address5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Originprice1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Buyprice2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Presentprice2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Buytotal1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Discounttotal1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Presenttotal1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Handler1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Displayname1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Children
    {
        public string type { get; set; }
        public object _struct { get; set; }
    }

    public class List
    {
        public string type { get; set; }
        public Struct22 _struct { get; set; }
    }

    public class Struct22
    {
        public Id11 id { get; set; }
        public Username1 username { get; set; }
        public Nickname3 nickname { get; set; }
        public Status5 status { get; set; }
        public Createtime2 createTime { get; set; }
        public Title7 title { get; set; }
        public Url3 url { get; set; }
        public Picurl3 picUrl { get; set; }
        public Sort6 sort { get; set; }
        public Memo5 memo { get; set; }
        public Description3 description { get; set; }
        public Type7 type { get; set; }
        public Codetype codeType { get; set; }
        public Quota3 quota { get; set; }
        public Total4 total { get; set; }
        public Priceavailable2 priceAvailable { get; set; }
        public Rangetype3 rangeType { get; set; }
        public Rangevalues3 rangeValues { get; set; }
        public Datetype2 dateType { get; set; }
        public Validstarttime2 validStartTime { get; set; }
        public Validendtime2 validEndTime { get; set; }
        public Fixedstartterm fixedStartTerm { get; set; }
        public Fixedendterm2 fixedEndTerm { get; set; }
        public Preferentialtype3 preferentialType { get; set; }
        public Percentoff2 percentOff { get; set; }
        public Priceoff2 priceOff { get; set; }
        public Discountpricelimit2 discountPriceLimit { get; set; }
        public Statfetchnum statFetchNum { get; set; }
        public Productspuid3 productSpuId { get; set; }
        public Name6 name { get; set; }
        public Sellpoint1 sellPoint { get; set; }
        public Cid1 cid { get; set; }
        public Picurls1 picUrls { get; set; }
        public Visible1 visible { get; set; }
    }

    public class Id11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Username1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Nickname3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Createtime2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Title7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Picurl3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Memo5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Description3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Type7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Codetype
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Quota3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Total4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Priceavailable2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rangetype3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rangevalues3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Datetype2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Validstarttime2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Validendtime2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fixedstartterm
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fixedendterm2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialtype3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Percentoff2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Priceoff2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Discountpricelimit2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Statfetchnum
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Productspuid3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sellpoint1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Cid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Picurls1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Visible1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Username2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Nickname4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Assigned
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Enumvalue1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Value1
    {
        public string type { get; set; }
        public string name { get; set; }
        public Struct23 _struct { get; set; }
    }

    public class Struct23
    {
        public Id12 id { get; set; }
        public Name7 name { get; set; }
        public Sellpoint2 sellPoint { get; set; }
        public Picurls2 picUrls { get; set; }
        public Price1 price { get; set; }
    }

    public class Id12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sellpoint2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Picurls2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Price1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Memo6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Values
    {
        public string type { get; set; }
        public Struct24 _struct { get; set; }
    }

    public class Struct24
    {
        public Value2 value { get; set; }
        public Displayname2 displayName { get; set; }
        public Id13 id { get; set; }
        public Name8 name { get; set; }
    }

    public class Value2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Displayname2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Id13
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Accesstoken1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Refreshtoken
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Expiresin
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Count
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Roles
    {
        public string type { get; set; }
        public Struct25 _struct { get; set; }
    }

    public class Struct25
    {
        public Id14 id { get; set; }
        public Name9 name { get; set; }
        public Createtime3 createTime { get; set; }
        public Count1 count { get; set; }
    }

    public class Id14
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Createtime3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Count1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Adminid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Roleids1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Title8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Picurl4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Description4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Codetype1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Quota4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Priceavailable3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rangetype4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rangevalues4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Datetype3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Validstarttime3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Validendtime3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fixedstartterm1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fixedendterm3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialtype4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Percentoff3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Priceoff3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Discountpricelimit3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Statfetchnum1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Productspuid4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Key
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Users
    {
        public string type { get; set; }
        public Struct26 _struct { get; set; }
    }

    public class Struct26
    {
        public Id15 id { get; set; }
        public Mobile6 mobile { get; set; }
        public Nickname5 nickname { get; set; }
        public Avatar1 avatar { get; set; }
        public Status6 status { get; set; }
        public Createtime4 createTime { get; set; }
    }

    public class Id15
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mobile6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Nickname5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Avatar1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Createtime4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userid4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Avatar2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Invokeresponse
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Attrs
    {
        public string type { get; set; }
        public Struct27 _struct { get; set; }
    }

    public class Struct27
    {
        public Id16 id { get; set; }
        public Name10 name { get; set; }
        public Status7 status { get; set; }
        public Createtime5 createTime { get; set; }
        public Values1 values { get; set; }
    }

    public class Id16
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Createtime5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Values1
    {
        public string type { get; set; }
        public Struct28 _struct { get; set; }
    }

    public class Struct28
    {
        public Id17 id { get; set; }
        public Name11 name { get; set; }
        public Status8 status { get; set; }
        public Createtime6 createTime { get; set; }
    }

    public class Id17
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Createtime6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Attrid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sellpoint3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Cid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Picurls3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Visible2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Skus
    {
        public string type { get; set; }
        public Struct29 _struct { get; set; }
    }

    public class Struct29
    {
        public Id18 id { get; set; }
        public Spuid spuId { get; set; }
        public Picurl5 picURL { get; set; }
        public Attrs1 attrs { get; set; }
        public Price2 price { get; set; }
        public Quantity4 quantity { get; set; }
    }

    public class Id18
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Spuid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Picurl5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Attrs1
    {
        public string type { get; set; }
        public Struct30 _struct { get; set; }
    }

    public class Struct30
    {
        public Attrid2 attrId { get; set; }
        public Attrname attrName { get; set; }
        public Attrvalueid attrValueId { get; set; }
        public Attrvaluename attrValueName { get; set; }
    }

    public class Attrid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Attrname
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Attrvalueid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Attrvaluename
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Price2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Quantity4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Spus
    {
        public string type { get; set; }
        public Struct31 _struct { get; set; }
    }

    public class Struct31
    {
        public Id19 id { get; set; }
        public Name12 name { get; set; }
        public Sellpoint4 sellPoint { get; set; }
        public Description5 description { get; set; }
        public Cid3 cid { get; set; }
        public Picurls4 picUrls { get; set; }
        public Price3 price { get; set; }
        public Quantity5 quantity { get; set; }
    }

    public class Id19
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sellpoint4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Description5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Cid3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Picurls4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Price3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Quantity5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Total5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class List1
    {
        public string type { get; set; }
        public Struct32 _struct { get; set; }
    }

    public class Struct32
    {
        public Id20 id { get; set; }
        public Title9 title { get; set; }
        public Url5 url { get; set; }
        public Picurl6 picUrl { get; set; }
        public Sort7 sort { get; set; }
        public Status9 status { get; set; }
        public Memo7 memo { get; set; }
        public Createtime7 createTime { get; set; }
        public Description6 description { get; set; }
        public Type8 type { get; set; }
        public Codetype2 codeType { get; set; }
        public Quota5 quota { get; set; }
        public Total6 total { get; set; }
        public Priceavailable4 priceAvailable { get; set; }
        public Rangetype5 rangeType { get; set; }
        public Rangevalues5 rangeValues { get; set; }
        public Datetype4 dateType { get; set; }
        public Validstarttime4 validStartTime { get; set; }
        public Validendtime4 validEndTime { get; set; }
        public Fixedstartterm2 fixedStartTerm { get; set; }
        public Fixedendterm4 fixedEndTerm { get; set; }
        public Preferentialtype5 preferentialType { get; set; }
        public Percentoff4 percentOff { get; set; }
        public Priceoff4 priceOff { get; set; }
        public Discountpricelimit4 discountPriceLimit { get; set; }
        public Statfetchnum2 statFetchNum { get; set; }
        public Productspuid5 productSpuId { get; set; }
    }

    public class Id20
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Title9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Picurl6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Memo7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Createtime7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Description6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Type8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Codetype2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Quota5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Total6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Priceavailable4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rangetype5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rangevalues5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Datetype4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Validstarttime4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Validendtime4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fixedstartterm2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fixedendterm4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialtype5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Percentoff4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Priceoff4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Discountpricelimit4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Statfetchnum2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Productspuid5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Id21
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Title10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Picurl7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Memo8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Createtime8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Description7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Codetype3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Quota6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Priceavailable5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rangetype6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rangevalues6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Datetype5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Validstarttime5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Validendtime5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fixedstartterm3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fixedendterm5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialtype6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Percentoff5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Priceoff5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Discountpricelimit5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Statfetchnum3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Productspuid6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Users1
    {
        public string type { get; set; }
        public Struct33 _struct { get; set; }
    }

    public class Struct33
    {
        public Id22 id { get; set; }
        public Mobile7 mobile { get; set; }
        public Nickname6 nickname { get; set; }
        public Avatar3 avatar { get; set; }
        public Status11 status { get; set; }
        public Createtime9 createTime { get; set; }
    }

    public class Id22
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mobile7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Nickname6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Avatar3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Createtime9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Count2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Struct34
    {
        public Id23 id { get; set; }
        public Name13 name { get; set; }
        public Type9 type { get; set; }
        public Sort9 sort { get; set; }
        public Displayname3 displayName { get; set; }
        public Createtime10 createTime { get; set; }
        public Pid2 pid { get; set; }
        public Handler2 handler { get; set; }
    }

    public class Id23
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name13
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Type9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Displayname3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Createtime10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Handler2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Accesstoken2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Refreshtoken1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Expiresin1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Result
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Boolean
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Call
    {
        public string targetMicroservices { get; set; }
        public string interfaceName { get; set; }
        public string[] positions { get; set; }
    }

}
