using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_JSON_Data.JSONDataStruct.Version1_wanghongkai_108867
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
        public Topic[] topics { get; set; }
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
        public Publish[] publish { get; set; }
        public Subscribe[] subscribe { get; set; }
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
        public Orderid orderId { get; set; }
        public Orderno orderNo { get; set; }
        public Servicenumber serviceNumber { get; set; }
        public Startcreatetime startCreateTime { get; set; }
        public Endcreatetime endCreateTime { get; set; }
        public Status status { get; set; }
        public Index index { get; set; }
        public Pagesize pageSize { get; set; }
        public RequestparamId RequestParamid { get; set; }
        public HttprequestheaderXForwardedFor HTTPRequestHeaderXForwardedFor { get; set; }
        public Id id { get; set; }
        public Userid userId { get; set; }
        public Startpaymenttime startPaymentTime { get; set; }
        public Endpaymenttime endPaymentTime { get; set; }
        public Startclosingtime startClosingTime { get; set; }
        public Endclosingtime endClosingTime { get; set; }
        public Deleted deleted { get; set; }
        public Pageno pageNo { get; set; }
        public RequestparamOrderid RequestParamorderId { get; set; }
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
        public Orderlogisticsid orderLogisticsId { get; set; }
        public Hasreturnexchange hasReturnExchange { get; set; }
        public Useraddressid userAddressId { get; set; }
        public Couponcardid couponCardId { get; set; }
        public Remark remark { get; set; }
        public Orderitems orderItems { get; set; }
        public RequestparamUseraddressid RequestParamuserAddressId { get; set; }
        public RequestparamCouponcardid RequestParamcouponCardId { get; set; }
        public RequestparamSkuid RequestParamskuId { get; set; }
        public RequestparamQuantity RequestParamquantity { get; set; }
        public RequestparamLogisticsid RequestParamlogisticsId { get; set; }
        public Returntype returnType { get; set; }
        public Reason reason { get; set; }
        public Describe describe { get; set; }
        public Skuids skuIds { get; set; }
        public Selected selected { get; set; }
        public Items items { get; set; }
        public Refundprice refundPrice { get; set; }
        public Ip ip { get; set; }
        public Orderitemid orderItemId { get; set; }
        public Payamount payAmount { get; set; }
        public Integer Integer { get; set; }
        public Otherreasons otherReasons { get; set; }
        public Remake remake { get; set; }
        public RequestparamNickname RequestParamnickname { get; set; }
        public RequestparamPageno RequestParampageNo { get; set; }
        public RequestparamPagesize RequestParampageSize { get; set; }
        public RequestparamUsername RequestParamusername { get; set; }
        public RequestparamPassword RequestParampassword { get; set; }
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
        public Dictkey dictKey { get; set; }
        public Dictvalue dictValue { get; set; }
        public Dictvaluelist dictValueList { get; set; }
        public Accesstoken accessToken { get; set; }
        public Url url { get; set; }
        public Type type { get; set; }
        public Pid pid { get; set; }
        public Handler handler { get; set; }
        public Resourceid resourceId { get; set; }
        public Roleid roleId { get; set; }
        public Resourceids resourceIds { get; set; }
        public Traceid traceId { get; set; }
        public Usertype userType { get; set; }
        public Applicationname applicationName { get; set; }
        public Uri uri { get; set; }
        public Querystring queryString { get; set; }
        public Method method { get; set; }
        public Starttime startTime { get; set; }
        public Responsetime responseTime { get; set; }
        public Errorcode errorCode { get; set; }
        public Errormessage errorMessage { get; set; }
        public Useragent userAgent { get; set; }
        public Exceptiontime exceptionTime { get; set; }
        public Exceptionname exceptionName { get; set; }
        public Exceptionclassname exceptionClassName { get; set; }
        public Exceptionfilename exceptionFileName { get; set; }
        public Exceptionmethodname exceptionMethodName { get; set; }
        public Exceptionlinenumber exceptionLineNumber { get; set; }
        public Exceptionstacktrace exceptionStackTrace { get; set; }
        public Exceptionrootcausemessage exceptionRootCauseMessage { get; set; }
        public Exceptionmessage exceptionMessage { get; set; }
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
        public Activitytype activityType { get; set; }
        public Templateid templateId { get; set; }
        public Bannerpagedto bannerPageDTO { get; set; }
        public Banneradddto bannerAddDTO { get; set; }
        public Bannerupdatedto bannerUpdateDTO { get; set; }
        public Bannerid bannerId { get; set; }
        public Coupontemplateid couponTemplateId { get; set; }
        public Coupontemplatepagedto couponTemplatePageDTO { get; set; }
        public Couponcodetemplateadddto couponCodeTemplateAddDTO { get; set; }
        public Couponcardtemplateadddto couponCardTemplateAddDTO { get; set; }
        public Couponcodetemplateupdatedto couponCodeTemplateUpdateDTO { get; set; }
        public Couponcardtemplateupdatedto couponCardTemplateUpdateDTO { get; set; }
        public Couponcardpagedto couponCardPageDTO { get; set; }
        public Spus spus { get; set; }
        public Code code { get; set; }
        public Productrecommendpagedto productRecommendPageDTO { get; set; }
        public Productrecommendadddto productRecommendAddDTO { get; set; }
        public Productrecommendupdatedto productRecommendUpdateDTO { get; set; }
        public Productrecommendid productRecommendId { get; set; }
        public Spuid1 spuId { get; set; }
        public Activitystatuses activityStatuses { get; set; }
        public Spuids spuIds { get; set; }
        public Promotionactivitypagedto promotionActivityPageDTO { get; set; }
        public Cid cid { get; set; }
        public Keyword keyword { get; set; }
        public Sortfield sortField { get; set; }
        public Sortorder sortOrder { get; set; }
        public Searchpagedto searchPageDTO { get; set; }
        public Conditiondto conditionDTO { get; set; }
        public Avatar avatar { get; set; }
        public Refreshtoken refreshToken { get; set; }
        public Useraddressaddpo userAddressAddPO { get; set; }
        public Useraddressupdatepo userAddressUpdatePO { get; set; }
        public Useraccesslogadddto userAccessLogAddDTO { get; set; }
        public Useraddressadddto userAddressAddDTO { get; set; }
        public Addressid addressId { get; set; }
        public Userpagedto userPageDTO { get; set; }
        public Userupdatedto userUpdateDTO { get; set; }
        public Createbegintime createBeginTime { get; set; }
        public Createendtime createEndTime { get; set; }
        public Finishbegintime finishBeginTime { get; set; }
        public Finishendtime finishEndTime { get; set; }
        public Child _ { get; set; }
        public Paychannel payChannel { get; set; }
        public Paymentbegintime paymentBeginTime { get; set; }
        public Paymentendtime paymentEndTime { get; set; }
        public Hasrefund hasRefund { get; set; }
        public Ordersubject orderSubject { get; set; }
        public Refundcode refundCode { get; set; }
        public Time_Succeed time_succeed { get; set; }
        public Transaction_No transaction_no { get; set; }
        public Failure_Code failure_code { get; set; }
        public Failure_Msg failure_msg { get; set; }
        public Appid appId { get; set; }
        public Order_No order_no { get; set; }
        public Time_Paid time_paid { get; set; }
        public Attrid attrId { get; set; }
        public Sellpoint sellPoint { get; set; }
        public Picurls picUrls { get; set; }
        public Visible visible { get; set; }
        public Skustr skuStr { get; set; }
        public Ids ids { get; set; }
    }

    public class Orderid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderno
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Servicenumber
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

    public class Status
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Index
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class RequestparamId
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class HttprequestheaderXForwardedFor
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Id
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userid
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

    public class RequestparamOrderid
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

    public class Useraddressid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Couponcardid
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

    public class RequestparamUseraddressid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class RequestparamCouponcardid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class RequestparamSkuid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class RequestparamQuantity
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class RequestparamLogisticsid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Returntype
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Reason
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Describe
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Skuids
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Selected
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Items
    {
        public Skuid2 skuId { get; set; }
        public Quantity2 quantity { get; set; }
        public Selected1 selected { get; set; }
    }

    public class Skuid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Quantity2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Selected1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Refundprice
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Ip
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderitemid
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

    public class Otherreasons
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

    public class Dictkey
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Dictvalue
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Dictvaluelist
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

    public class Traceid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usertype
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Applicationname
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

    public class Errorcode
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Errormessage
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Useragent
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Exceptiontime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Exceptionname
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Exceptionclassname
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Exceptionfilename
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Exceptionmethodname
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Exceptionlinenumber
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Exceptionstacktrace
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Exceptionrootcausemessage
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Exceptionmessage
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

    public class Activitytype
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Templateid
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

    public class Coupontemplateid
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

    public class Couponcardpagedto
    {
        public string type { get; set; }
        public Struct9 _struct { get; set; }
    }

    public class Struct9
    {
        public Userid1 userId { get; set; }
        public Status2 status { get; set; }
        public Pageno3 pageNo { get; set; }
        public Pagesize3 pageSize { get; set; }
    }

    public class Userid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status2
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

    public class Spus
    {
        public string type { get; set; }
        public Struct10 _struct { get; set; }
    }

    public class Struct10
    {
        public Spuid spuId { get; set; }
        public Skuid3 skuId { get; set; }
        public Categoryid categoryId { get; set; }
        public Price1 price { get; set; }
        public Quantity3 quantity { get; set; }
    }

    public class Spuid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Skuid3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Categoryid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Price1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Quantity3
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
        public Struct11 _struct { get; set; }
    }

    public class Struct11
    {
        public Type2 type { get; set; }
        public Pageno4 pageNo { get; set; }
        public Pagesize4 pageSize { get; set; }
    }

    public class Type2
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

    public class Productrecommendadddto
    {
        public string type { get; set; }
        public Struct12 _struct { get; set; }
    }

    public class Struct12
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
        public Struct13 _struct { get; set; }
    }

    public class Struct13
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

    public class Spuid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Activitystatuses
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Spuids
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Promotionactivitypagedto
    {
        public string type { get; set; }
        public Struct14 _struct { get; set; }
    }

    public class Struct14
    {
        public Title7 title { get; set; }
        public Activitytype1 activityType { get; set; }
        public Statuses statuses { get; set; }
        public Pageno5 pageNo { get; set; }
        public Pagesize5 pageSize { get; set; }
    }

    public class Title7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Activitytype1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Statuses
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pageno5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Cid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sortfield
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sortorder
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Searchpagedto
    {
        public string type { get; set; }
        public Struct15 _struct { get; set; }
    }

    public class Struct15
    {
        public Cid1 cid { get; set; }
        public Keyword1 keyword { get; set; }
        public Pageno6 pageNo { get; set; }
        public Pagesize6 pageSize { get; set; }
        public Sorts sorts { get; set; }
    }

    public class Cid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pageno6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sorts
    {
        public string type { get; set; }
        public Struct16 _struct { get; set; }
    }

    public class Struct16
    {
        public Field field { get; set; }
        public Order order { get; set; }
    }

    public class Field
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Order
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Conditiondto
    {
        public string type { get; set; }
        public Struct17 _struct { get; set; }
    }

    public class Struct17
    {
        public Keyword2 keyword { get; set; }
        public Fields fields { get; set; }
    }

    public class Keyword2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fields
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Avatar
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Refreshtoken
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Useraddressaddpo
    {
        public string type { get; set; }
        public Struct18 _struct { get; set; }
    }

    public class Struct18
    {
        public Areano1 areaNo { get; set; }
        public Name1 name { get; set; }
        public Mobile1 mobile { get; set; }
        public Address1 address { get; set; }
        public Hasdefault hasDefault { get; set; }
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

    public class Hasdefault
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Useraddressupdatepo
    {
        public string type { get; set; }
        public Struct19 _struct { get; set; }
    }

    public class Struct19
    {
        public Id4 id { get; set; }
        public Areano2 areaNo { get; set; }
        public Name2 name { get; set; }
        public Mobile2 mobile { get; set; }
        public Address2 address { get; set; }
        public Hasdefault1 hasDefault { get; set; }
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

    public class Hasdefault1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Useraccesslogadddto
    {
        public string type { get; set; }
        public Struct20 _struct { get; set; }
    }

    public class Struct20
    {
        public Url3 url { get; set; }
        public Querystring1 queryString { get; set; }
        public Method1 method { get; set; }
        public Useragent1 userAgent { get; set; }
        public Ip1 ip { get; set; }
        public Starttime1 startTime { get; set; }
        public Responsetime1 responseTime { get; set; }
    }

    public class Url3
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
        public Struct21 _struct { get; set; }
    }

    public class Struct21
    {
        public Userid2 userId { get; set; }
        public Areano3 areaNo { get; set; }
        public Name3 name { get; set; }
        public Mobile3 mobile { get; set; }
        public Address3 address { get; set; }
        public Hasdefault2 hasDefault { get; set; }
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

    public class Hasdefault2
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
        public Struct22 _struct { get; set; }
    }

    public class Struct22
    {
        public Nickname1 nickname { get; set; }
        public Status3 status { get; set; }
        public Pageno7 pageNo { get; set; }
        public Pagesize7 pageSize { get; set; }
    }

    public class Nickname1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pageno7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userupdatedto
    {
        public string type { get; set; }
        public Struct23 _struct { get; set; }
    }

    public class Struct23
    {
        public Id6 id { get; set; }
        public Nickname2 nickname { get; set; }
        public Avatar1 avatar { get; set; }
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

    public class Avatar1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Createbegintime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Createendtime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Finishbegintime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Finishendtime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Child
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Paychannel
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Paymentbegintime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Paymentendtime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Hasrefund
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Ordersubject
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Refundcode
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Time_Succeed
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Transaction_No
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Failure_Code
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Failure_Msg
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Appid
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

    public class Ids
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Outputparamstruct
    {
        public Code1 code { get; set; }
        public Message message { get; set; }
        public Data data { get; set; }
        public object type { get; set; }
        public string name { get; set; }
        public Struct80 _struct { get; set; }
        public Total6 total { get; set; }
        public List2 list { get; set; }
        public Id48 id { get; set; }
        public Title21 title { get; set; }
        public Url8 url { get; set; }
        public Picurl10 picUrl { get; set; }
        public Sort11 sort { get; set; }
        public Status24 status { get; set; }
        public Memo9 memo { get; set; }
        public Createtime11 createTime { get; set; }
        public Description9 description { get; set; }
        public Codetype3 codeType { get; set; }
        public Quota17 quota { get; set; }
        public Priceavailable6 priceAvailable { get; set; }
        public Rangetype17 rangeType { get; set; }
        public Rangevalues17 rangeValues { get; set; }
        public Datetype5 dateType { get; set; }
        public Validstarttime6 validStartTime { get; set; }
        public Validendtime6 validEndTime { get; set; }
        public Fixedstartterm3 fixedStartTerm { get; set; }
        public Fixedendterm5 fixedEndTerm { get; set; }
        public Preferentialtype29 preferentialType { get; set; }
        public Percentoff6 percentOff { get; set; }
        public Priceoff6 priceOff { get; set; }
        public Discountpricelimit6 discountPriceLimit { get; set; }
        public Statfetchnum3 statFetchNum { get; set; }
        public Templateid5 templateId { get; set; }
        public Userid8 userId { get; set; }
        public Taketype2 takeType { get; set; }
        public Usedtime2 usedTime { get; set; }
        public Used used { get; set; }
        public Usedorderid usedOrderId { get; set; }
        public Usedprice usedPrice { get; set; }
        public Productspuid7 productSpuId { get; set; }
        public Accesstoken2 accessToken { get; set; }
        public Refreshtoken2 refreshToken { get; set; }
        public Expiresin1 expiresIn { get; set; }
        public Mobile11 mobile { get; set; }
        public Nickname6 nickname { get; set; }
        public Avatar5 avatar { get; set; }
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
        public string type { get; set; }
        public Struct24 _struct { get; set; }
        public string name { get; set; }
    }

    public class Struct24
    {
        public Index1 index { get; set; }
        public Pagesize8 pageSize { get; set; }
        public Totalcount totalCount { get; set; }
        public Data1 data { get; set; }
        public Total3 total { get; set; }
        public Orders orders { get; set; }
        public Id11 id { get; set; }
        public Orderid4 orderId { get; set; }
        public Orderno4 orderNo { get; set; }
        public Skuid5 skuId { get; set; }
        public Skuname1 skuName { get; set; }
        public Skuimage1 skuImage { get; set; }
        public Quantity5 quantity { get; set; }
        public Originprice1 originPrice { get; set; }
        public Buyprice2 buyPrice { get; set; }
        public Presentprice2 presentPrice { get; set; }
        public Buytotal1 buyTotal { get; set; }
        public Discounttotal1 discountTotal { get; set; }
        public Presenttotal1 presentTotal { get; set; }
        public Paymenttime2 paymentTime { get; set; }
        public Deliverytime2 deliveryTime { get; set; }
        public Receivertime3 receiverTime { get; set; }
        public Closingtime3 closingTime { get; set; }
        public Hasreturnexchange3 hasReturnExchange { get; set; }
        public Deliverytype1 deliveryType { get; set; }
        public Status7 status { get; set; }
        public Createtime2 createTime { get; set; }
        public Updatetime2 updateTime { get; set; }
        public Deleted2 deleted { get; set; }
        public Areano5 areaNo { get; set; }
        public Name5 name { get; set; }
        public Mobile5 mobile { get; set; }
        public Type6 type { get; set; }
        public Address5 address { get; set; }
        public Payamount2 payAmount { get; set; }
        public Couponcarddiscounttotal couponCardDiscountTotal { get; set; }
        public Itemgroups itemGroups { get; set; }
        public Fee fee { get; set; }
        public Couponcards couponCards { get; set; }
        public Discountprice1 discountPrice { get; set; }
        public Logisticsprice1 logisticsPrice { get; set; }
        public Statustext statusText { get; set; }
        public Remark2 remark { get; set; }
        public Hasorderreturn hasOrderReturn { get; set; }
        public Recipient recipient { get; set; }
        public Latestlogisticsdetail latestLogisticsDetail { get; set; }
        public Orderitems2 orderItems { get; set; }
        public Message1 message { get; set; }
        public Logistics1 logistics { get; set; }
        public Logisticstext1 logisticsText { get; set; }
        public Logisticsno2 logisticsNo { get; set; }
        public Details1 details { get; set; }
        public Enumvalue1 enumValue { get; set; }
        public Value1 value { get; set; }
        public Displayname1 displayName { get; set; }
        public Sort5 sort { get; set; }
        public Memo5 memo { get; set; }
        public Returninfo returnInfo { get; set; }
        public Lastlogisticsinfo lastLogisticsInfo { get; set; }
        public Fullprivilege2 fullPrivilege { get; set; }
        public Timelimiteddiscount3 timeLimitedDiscount { get; set; }
        public Originalprice originalPrice { get; set; }
        public Lastlogisticsdetail1 lastLogisticsDetail { get; set; }
        public Handler1 handler { get; set; }
        public Pid1 pid { get; set; }
        public Children children { get; set; }
        public List list { get; set; }
        public Username2 username { get; set; }
        public Nickname4 nickname { get; set; }
        public Assigned assigned { get; set; }
        public Values values { get; set; }
        public Accesstoken1 accessToken { get; set; }
        public Refreshtoken1 refreshToken { get; set; }
        public Expiresin expiresIn { get; set; }
        public Count count { get; set; }
        public Roles roles { get; set; }
        public Adminid1 adminId { get; set; }
        public Roleids1 roleIds { get; set; }
        public Title14 title { get; set; }
        public Url5 url { get; set; }
        public Picurl5 picUrl { get; set; }
        public Description4 description { get; set; }
        public Codetype1 codeType { get; set; }
        public Quota9 quota { get; set; }
        public Priceavailable4 priceAvailable { get; set; }
        public Rangetype9 rangeType { get; set; }
        public Rangevalues9 rangeValues { get; set; }
        public Datetype3 dateType { get; set; }
        public Validstarttime4 validStartTime { get; set; }
        public Validendtime4 validEndTime { get; set; }
        public Fixedstartterm1 fixedStartTerm { get; set; }
        public Fixedendterm3 fixedEndTerm { get; set; }
        public Preferentialtype15 preferentialType { get; set; }
        public Percentoff4 percentOff { get; set; }
        public Priceoff4 priceOff { get; set; }
        public Discountpricelimit4 discountPriceLimit { get; set; }
        public Statfetchnum1 statFetchNum { get; set; }
        public Productspuid4 productSpuId { get; set; }
        public Productspuname1 productSpuName { get; set; }
        public Templateid3 templateId { get; set; }
        public Key key { get; set; }
        public Categories categories { get; set; }
        public Userid5 userId { get; set; }
        public Hasdefault3 hasDefault { get; set; }
        public Avatar3 avatar { get; set; }
        public Appid3 appId { get; set; }
        public Createip2 createIp { get; set; }
        public Ordersubject3 orderSubject { get; set; }
        public Orderdescription2 orderDescription { get; set; }
        public Ordermemo2 orderMemo { get; set; }
        public Price6 price { get; set; }
        public Expiretime2 expireTime { get; set; }
        public Finishtime2 finishTime { get; set; }
        public Extensionid2 extensionId { get; set; }
        public Paychannel3 payChannel { get; set; }
        public Notifytime2 notifyTime { get; set; }
        public Tradeno1 tradeNo { get; set; }
        public Refundtotal2 refundTotal { get; set; }
        public Invokeresponse invokeResponse { get; set; }
        public Attrs1 attrs { get; set; }
        public Attrid2 attrId { get; set; }
        public Sellpoint3 sellPoint { get; set; }
        public Cid4 cid { get; set; }
        public Picurls4 picUrls { get; set; }
        public Visible2 visible { get; set; }
        public Skus skus { get; set; }
        public Spus1 spus { get; set; }
    }

    public class Index1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Totalcount
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Data1
    {
        public string type { get; set; }
        public Struct25 _struct { get; set; }
    }

    public class Struct25
    {
        public Id7 id { get; set; }
        public Orderid1 orderId { get; set; }
        public Orderno1 orderNo { get; set; }
        public Servicenumber1 serviceNumber { get; set; }
        public Orderlogisticsid1 orderLogisticsId { get; set; }
        public Refundprice1 refundPrice { get; set; }
        public Reason1 reason { get; set; }
        public Describe1 describe { get; set; }
        public Approvaltime approvalTime { get; set; }
        public Logisticstime logisticsTime { get; set; }
        public Receivertime receiverTime { get; set; }
        public Closingtime closingTime { get; set; }
        public Servicetype serviceType { get; set; }
        public Status4 status { get; set; }
        public Createtime createTime { get; set; }
        public Updatetime updateTime { get; set; }
    }

    public class Id7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderno1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Servicenumber1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderlogisticsid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Refundprice1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Reason1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Describe1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Approvaltime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logisticstime
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

    public class Servicetype
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status4
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

    public class Total3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orders
    {
        public string type { get; set; }
        public Struct26 _struct { get; set; }
    }

    public class Struct26
    {
        public Id8 id { get; set; }
        public Userid3 userId { get; set; }
        public Orderno2 orderNo { get; set; }
        public Buyprice buyPrice { get; set; }
        public Discountprice discountPrice { get; set; }
        public Logisticsprice logisticsPrice { get; set; }
        public Presentprice presentPrice { get; set; }
        public Payamount1 payAmount { get; set; }
        public Paymenttime paymentTime { get; set; }
        public Deliverytime deliveryTime { get; set; }
        public Receivertime1 receiverTime { get; set; }
        public Closingtime1 closingTime { get; set; }
        public Hasreturnexchange1 hasReturnExchange { get; set; }
        public Status5 status { get; set; }
        public Remark1 remark { get; set; }
        public Orderitems1 orderItems { get; set; }
        public Orderrecipient orderRecipient { get; set; }
    }

    public class Id8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userid3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderno2
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

    public class Hasreturnexchange1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status5
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
        public Struct27 _struct { get; set; }
    }

    public class Struct27
    {
        public Id9 id { get; set; }
        public Orderid2 orderId { get; set; }
        public Orderno3 orderNo { get; set; }
        public Skuid4 skuId { get; set; }
        public Skuname skuName { get; set; }
        public Skuimage skuImage { get; set; }
        public Quantity4 quantity { get; set; }
        public Originprice originPrice { get; set; }
        public Buyprice1 buyPrice { get; set; }
        public Presentprice1 presentPrice { get; set; }
        public Buytotal buyTotal { get; set; }
        public Discounttotal discountTotal { get; set; }
        public Presenttotal presentTotal { get; set; }
        public Paymenttime1 paymentTime { get; set; }
        public Deliverytime1 deliveryTime { get; set; }
        public Receivertime2 receiverTime { get; set; }
        public Closingtime2 closingTime { get; set; }
        public Hasreturnexchange2 hasReturnExchange { get; set; }
        public Deliverytype deliveryType { get; set; }
        public Status6 status { get; set; }
        public Createtime1 createTime { get; set; }
        public Updatetime1 updateTime { get; set; }
        public Deleted1 deleted { get; set; }
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

    public class Orderno3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Skuid4
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

    public class Quantity4
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

    public class Status6
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

    public class Deleted1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderrecipient
    {
        public string type { get; set; }
        public Struct28 _struct { get; set; }
    }

    public class Struct28
    {
        public Id10 id { get; set; }
        public Orderid3 orderId { get; set; }
        public Areano4 areaNo { get; set; }
        public Name4 name { get; set; }
        public Mobile4 mobile { get; set; }
        public Type5 type { get; set; }
        public Address4 address { get; set; }
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

    public class Id11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderid4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderno4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Skuid5
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

    public class Quantity5
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

    public class Receivertime3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Closingtime3
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

    public class Status7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Createtime2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Updatetime2
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

    public class Payamount2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Couponcarddiscounttotal
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Itemgroups
    {
        public string type { get; set; }
        public Struct29 _struct { get; set; }
    }

    public class Struct29
    {
        public Activity activity { get; set; }
        public Items2 items { get; set; }
        public Activitydiscounttotal activityDiscountTotal { get; set; }
    }

    public class Activity
    {
        public string type { get; set; }
        public Struct30 _struct { get; set; }
    }

    public class Struct30
    {
        public Id12 id { get; set; }
        public Title8 title { get; set; }
        public Activitytype2 activityType { get; set; }
        public Status8 status { get; set; }
        public Starttime2 startTime { get; set; }
        public Endtime endTime { get; set; }
        public Timelimiteddiscount timeLimitedDiscount { get; set; }
        public Fullprivilege fullPrivilege { get; set; }
    }

    public class Id12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Title8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Activitytype2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Starttime2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Endtime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Timelimiteddiscount
    {
        public string type { get; set; }
        public Struct31 _struct { get; set; }
    }

    public class Struct31
    {
        public Quota3 quota { get; set; }
        public Items1 items { get; set; }
    }

    public class Quota3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Items1
    {
        public string type { get; set; }
        public Struct32 _struct { get; set; }
    }

    public class Struct32
    {
        public Spuid2 spuId { get; set; }
        public Preferentialtype3 preferentialType { get; set; }
        public Preferentialvalue preferentialValue { get; set; }
    }

    public class Spuid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialtype3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialvalue
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fullprivilege
    {
        public string type { get; set; }
        public Struct33 _struct { get; set; }
    }

    public class Struct33
    {
        public Rangetype3 rangeType { get; set; }
        public Rangevalues3 rangeValues { get; set; }
        public Cycled cycled { get; set; }
        public Privileges privileges { get; set; }
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

    public class Cycled
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Privileges
    {
        public string type { get; set; }
        public Struct34 _struct { get; set; }
    }

    public class Struct34
    {
        public Meettype meetType { get; set; }
        public Meetvalue meetValue { get; set; }
        public Preferentialtype4 preferentialType { get; set; }
        public Preferentialvalue1 preferentialValue { get; set; }
    }

    public class Meettype
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Meetvalue
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialtype4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialvalue1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Items2
    {
        public string type { get; set; }
        public Struct35 _struct { get; set; }
    }

    public class Struct35
    {
        public Id13 id { get; set; }
        public Picurl3 picURL { get; set; }
        public Price2 price { get; set; }
        public Quantity6 quantity { get; set; }
        public Buyquantity buyQuantity { get; set; }
        public Originprice2 originPrice { get; set; }
        public Buyprice3 buyPrice { get; set; }
        public Presentprice3 presentPrice { get; set; }
        public Buytotal2 buyTotal { get; set; }
        public Discounttotal2 discountTotal { get; set; }
        public Presenttotal2 presentTotal { get; set; }
        public Attrs attrs { get; set; }
        public Spu spu { get; set; }
        public Selected2 selected { get; set; }
        public Activity1 activity { get; set; }
    }

    public class Id13
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Picurl3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Price2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Quantity6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Buyquantity
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Originprice2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Buyprice3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Presentprice3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Buytotal2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Discounttotal2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Presenttotal2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Attrs
    {
        public string type { get; set; }
        public Struct36 _struct { get; set; }
    }

    public class Struct36
    {
        public Attrid1 attrId { get; set; }
        public Attrname attrName { get; set; }
        public Attrvalueid attrValueId { get; set; }
        public Attrvaluename attrValueName { get; set; }
    }

    public class Attrid1
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

    public class Spu
    {
        public string type { get; set; }
        public Struct37 _struct { get; set; }
    }

    public class Struct37
    {
        public Id14 id { get; set; }
        public Name6 name { get; set; }
        public Cid2 cid { get; set; }
        public Picurls1 picUrls { get; set; }
    }

    public class Id14
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Cid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Picurls1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Selected2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Activity1
    {
        public string type { get; set; }
        public Struct38 _struct { get; set; }
    }

    public class Struct38
    {
        public Id15 id { get; set; }
        public Title9 title { get; set; }
        public Activitytype3 activityType { get; set; }
        public Status9 status { get; set; }
        public Starttime3 startTime { get; set; }
        public Endtime1 endTime { get; set; }
        public Timelimiteddiscount1 timeLimitedDiscount { get; set; }
        public Fullprivilege1 fullPrivilege { get; set; }
    }

    public class Id15
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Title9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Activitytype3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Starttime3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Endtime1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Timelimiteddiscount1
    {
        public string type { get; set; }
        public Struct39 _struct { get; set; }
    }

    public class Struct39
    {
        public Quota4 quota { get; set; }
        public Items3 items { get; set; }
    }

    public class Quota4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Items3
    {
        public string type { get; set; }
        public Struct40 _struct { get; set; }
    }

    public class Struct40
    {
        public Spuid3 spuId { get; set; }
        public Preferentialtype5 preferentialType { get; set; }
        public Preferentialvalue2 preferentialValue { get; set; }
    }

    public class Spuid3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialtype5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialvalue2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fullprivilege1
    {
        public string type { get; set; }
        public Struct41 _struct { get; set; }
    }

    public class Struct41
    {
        public Rangetype4 rangeType { get; set; }
        public Rangevalues4 rangeValues { get; set; }
        public Cycled1 cycled { get; set; }
        public Privileges1 privileges { get; set; }
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

    public class Cycled1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Privileges1
    {
        public string type { get; set; }
        public Struct42 _struct { get; set; }
    }

    public class Struct42
    {
        public Meettype1 meetType { get; set; }
        public Meetvalue1 meetValue { get; set; }
        public Preferentialtype6 preferentialType { get; set; }
        public Preferentialvalue3 preferentialValue { get; set; }
    }

    public class Meettype1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Meetvalue1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialtype6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialvalue3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Activitydiscounttotal
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fee
    {
        public string type { get; set; }
        public Struct43 _struct { get; set; }
    }

    public class Struct43
    {
        public Buytotal3 buyTotal { get; set; }
        public Discounttotal3 discountTotal { get; set; }
        public Postagetotal postageTotal { get; set; }
        public Presenttotal3 presentTotal { get; set; }
    }

    public class Buytotal3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Discounttotal3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Postagetotal
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Presenttotal3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Couponcards
    {
        public string type { get; set; }
        public Struct44 _struct { get; set; }
    }

    public class Struct44
    {
        public Id16 id { get; set; }
        public Templateid1 templateId { get; set; }
        public Title10 title { get; set; }
        public Status10 status { get; set; }
        public Userid4 userId { get; set; }
        public Taketype takeType { get; set; }
        public Priceavailable2 priceAvailable { get; set; }
        public Validstarttime2 validStartTime { get; set; }
        public Validendtime2 validEndTime { get; set; }
        public Preferentialtype7 preferentialType { get; set; }
        public Percentoff2 percentOff { get; set; }
        public Priceoff2 priceOff { get; set; }
        public Discountpricelimit2 discountPriceLimit { get; set; }
        public Usedtime usedTime { get; set; }
        public Createtime3 createTime { get; set; }
        public Available available { get; set; }
        public Unavailablereason unavailableReason { get; set; }
    }

    public class Id16
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Templateid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Title10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userid4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Taketype
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Priceavailable2
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

    public class Preferentialtype7
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

    public class Usedtime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Createtime3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Available
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Unavailablereason
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Discountprice1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logisticsprice1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Statustext
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Remark2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Hasorderreturn
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Recipient
    {
        public string type { get; set; }
        public Struct45 _struct { get; set; }
    }

    public class Struct45
    {
        public Id17 id { get; set; }
        public Orderid5 orderId { get; set; }
        public Areano6 areaNo { get; set; }
        public Name7 name { get; set; }
        public Mobile6 mobile { get; set; }
        public Type7 type { get; set; }
        public Address6 address { get; set; }
    }

    public class Id17
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderid5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Areano6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mobile6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Type7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Address6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Latestlogisticsdetail
    {
        public string type { get; set; }
        public Struct46 _struct { get; set; }
    }

    public class Struct46
    {
        public Id18 id { get; set; }
        public Orderlogisticsid2 orderLogisticsId { get; set; }
        public Logisticstime1 logisticsTime { get; set; }
        public Logisticsinformation logisticsInformation { get; set; }
    }

    public class Id18
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderlogisticsid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logisticstime1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logisticsinformation
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderitems2
    {
        public string type { get; set; }
        public Struct47 _struct { get; set; }
    }

    public class Struct47
    {
        public Skuid6 skuId { get; set; }
        public Skuname2 skuName { get; set; }
        public Skuimage2 skuImage { get; set; }
        public Quantity7 quantity { get; set; }
        public Originprice3 originPrice { get; set; }
        public Buyprice4 buyPrice { get; set; }
        public Presentprice4 presentPrice { get; set; }
        public Buytotal4 buyTotal { get; set; }
        public Discounttotal4 discountTotal { get; set; }
        public Presenttotal4 presentTotal { get; set; }
    }

    public class Skuid6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Skuname2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Skuimage2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Quantity7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Originprice3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Buyprice4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Presentprice4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Buytotal4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Discounttotal4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Presenttotal4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Message1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logistics1
    {
        public string type { get; set; }
        public string name { get; set; }
        public Struct48 _struct { get; set; }
    }

    public class Struct48
    {
        public Id19 id { get; set; }
        public Areano7 areaNo { get; set; }
        public Name8 name { get; set; }
        public Mobile7 mobile { get; set; }
        public Address7 address { get; set; }
        public Message2 message { get; set; }
        public Logistics2 logistics { get; set; }
        public Logisticstext logisticsText { get; set; }
        public Logisticsno1 logisticsNo { get; set; }
        public Details details { get; set; }
    }

    public class Id19
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Areano7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mobile7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Address7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Message2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logistics2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logisticstext
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logisticsno1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Details
    {
        public string type { get; set; }
        public Struct49 _struct { get; set; }
    }

    public class Struct49
    {
        public Id20 id { get; set; }
        public Orderlogisticsid3 orderLogisticsId { get; set; }
        public Logisticstime2 logisticsTime { get; set; }
        public Logisticstimetext logisticsTimeText { get; set; }
        public Logisticsinformation1 logisticsInformation { get; set; }
    }

    public class Id20
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderlogisticsid3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logisticstime2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logisticstimetext
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logisticsinformation1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logisticstext1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logisticsno2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Details1
    {
        public string type { get; set; }
        public Struct50 _struct { get; set; }
    }

    public class Struct50
    {
        public Id21 id { get; set; }
        public Orderlogisticsid4 orderLogisticsId { get; set; }
        public Logisticstime3 logisticsTime { get; set; }
        public Logisticstimetext1 logisticsTimeText { get; set; }
        public Logisticsinformation2 logisticsInformation { get; set; }
    }

    public class Id21
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderlogisticsid4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logisticstime3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logisticstimetext1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logisticsinformation2
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
        public Struct51 _struct { get; set; }
    }

    public class Struct51
    {
        public Id22 id { get; set; }
        public Name9 name { get; set; }
        public Sellpoint1 sellPoint { get; set; }
        public Picurls2 picUrls { get; set; }
        public Price3 price { get; set; }
    }

    public class Id22
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sellpoint1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Picurls2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Price3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Displayname1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Memo5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Returninfo
    {
        public string type { get; set; }
        public Struct52 _struct { get; set; }
    }

    public class Struct52
    {
        public Id23 id { get; set; }
        public Servicenumber2 serviceNumber { get; set; }
        public Orderid6 orderId { get; set; }
        public Orderno5 orderNo { get; set; }
        public Orderlogisticsid5 orderLogisticsId { get; set; }
        public Refundprice2 refundPrice { get; set; }
        public Reason2 reason { get; set; }
        public Describe2 describe { get; set; }
        public Approvaltime1 approvalTime { get; set; }
        public Logisticstime4 logisticsTime { get; set; }
        public Receivertime4 receiverTime { get; set; }
        public Closingtime4 closingTime { get; set; }
        public Servicetype1 serviceType { get; set; }
        public Servicetypetext serviceTypeText { get; set; }
        public Status11 status { get; set; }
    }

    public class Id23
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Servicenumber2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderid6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderno5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderlogisticsid5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Refundprice2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Reason2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Describe2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Approvaltime1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logisticstime4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Receivertime4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Closingtime4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Servicetype1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Servicetypetext
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Lastlogisticsinfo
    {
        public string type { get; set; }
        public Struct53 _struct { get; set; }
    }

    public class Struct53
    {
        public Id24 id { get; set; }
        public Areano8 areaNo { get; set; }
        public Name10 name { get; set; }
        public Mobile8 mobile { get; set; }
        public Address8 address { get; set; }
        public Message3 message { get; set; }
        public Logistics3 logistics { get; set; }
        public Logisticstext2 logisticsText { get; set; }
        public Logisticsno3 logisticsNo { get; set; }
        public Lastlogisticsdetail lastLogisticsDetail { get; set; }
    }

    public class Id24
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Areano8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mobile8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Address8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Message3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logistics3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logisticstext2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logisticsno3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Lastlogisticsdetail
    {
        public string type { get; set; }
        public Struct54 _struct { get; set; }
    }

    public class Struct54
    {
        public Id25 id { get; set; }
        public Orderlogisticsid6 orderLogisticsId { get; set; }
        public Logisticstime5 logisticsTime { get; set; }
        public Logisticstimetext2 logisticsTimeText { get; set; }
        public Logisticsinformation3 logisticsInformation { get; set; }
    }

    public class Id25
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderlogisticsid6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logisticstime5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logisticstimetext2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logisticsinformation3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fullprivilege2
    {
        public string type { get; set; }
        public Struct55 _struct { get; set; }
    }

    public class Struct55
    {
        public Id26 id { get; set; }
        public Title11 title { get; set; }
        public Activitytype4 activityType { get; set; }
        public Status12 status { get; set; }
        public Starttime4 startTime { get; set; }
        public Endtime2 endTime { get; set; }
        public Timelimiteddiscount2 timeLimitedDiscount { get; set; }
        public Fullprivilege3 fullPrivilege { get; set; }
    }

    public class Id26
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Title11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Activitytype4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Starttime4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Endtime2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Timelimiteddiscount2
    {
        public string type { get; set; }
        public Struct56 _struct { get; set; }
    }

    public class Struct56
    {
        public Quota5 quota { get; set; }
        public Items4 items { get; set; }
    }

    public class Quota5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Items4
    {
        public string type { get; set; }
        public Struct57 _struct { get; set; }
    }

    public class Struct57
    {
        public Spuid4 spuId { get; set; }
        public Preferentialtype8 preferentialType { get; set; }
        public Preferentialvalue4 preferentialValue { get; set; }
    }

    public class Spuid4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialtype8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialvalue4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fullprivilege3
    {
        public string type { get; set; }
        public Struct58 _struct { get; set; }
    }

    public class Struct58
    {
        public Rangetype5 rangeType { get; set; }
        public Rangevalues5 rangeValues { get; set; }
        public Cycled2 cycled { get; set; }
        public Privileges2 privileges { get; set; }
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

    public class Cycled2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Privileges2
    {
        public string type { get; set; }
        public Struct59 _struct { get; set; }
    }

    public class Struct59
    {
        public Meettype2 meetType { get; set; }
        public Meetvalue2 meetValue { get; set; }
        public Preferentialtype9 preferentialType { get; set; }
        public Preferentialvalue5 preferentialValue { get; set; }
    }

    public class Meettype2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Meetvalue2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialtype9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialvalue5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Timelimiteddiscount3
    {
        public string type { get; set; }
        public Struct60 _struct { get; set; }
    }

    public class Struct60
    {
        public Id27 id { get; set; }
        public Title12 title { get; set; }
        public Activitytype5 activityType { get; set; }
        public Status13 status { get; set; }
        public Starttime5 startTime { get; set; }
        public Endtime3 endTime { get; set; }
        public Timelimiteddiscount4 timeLimitedDiscount { get; set; }
        public Fullprivilege4 fullPrivilege { get; set; }
    }

    public class Id27
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Title12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Activitytype5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status13
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Starttime5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Endtime3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Timelimiteddiscount4
    {
        public string type { get; set; }
        public Struct61 _struct { get; set; }
    }

    public class Struct61
    {
        public Quota6 quota { get; set; }
        public Items5 items { get; set; }
    }

    public class Quota6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Items5
    {
        public string type { get; set; }
        public Struct62 _struct { get; set; }
    }

    public class Struct62
    {
        public Spuid5 spuId { get; set; }
        public Preferentialtype10 preferentialType { get; set; }
        public Preferentialvalue6 preferentialValue { get; set; }
    }

    public class Spuid5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialtype10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialvalue6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fullprivilege4
    {
        public string type { get; set; }
        public Struct63 _struct { get; set; }
    }

    public class Struct63
    {
        public Rangetype6 rangeType { get; set; }
        public Rangevalues6 rangeValues { get; set; }
        public Cycled3 cycled { get; set; }
        public Privileges3 privileges { get; set; }
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

    public class Cycled3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Privileges3
    {
        public string type { get; set; }
        public Struct64 _struct { get; set; }
    }

    public class Struct64
    {
        public Meettype3 meetType { get; set; }
        public Meetvalue3 meetValue { get; set; }
        public Preferentialtype11 preferentialType { get; set; }
        public Preferentialvalue7 preferentialValue { get; set; }
    }

    public class Meettype3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Meetvalue3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialtype11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialvalue7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Originalprice
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Lastlogisticsdetail1
    {
        public string type { get; set; }
        public Struct65 _struct { get; set; }
    }

    public class Struct65
    {
        public Id28 id { get; set; }
        public Orderlogisticsid7 orderLogisticsId { get; set; }
        public Logisticstime6 logisticsTime { get; set; }
        public Logisticstimetext3 logisticsTimeText { get; set; }
        public Logisticsinformation4 logisticsInformation { get; set; }
    }

    public class Id28
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderlogisticsid7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logisticstime6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logisticstimetext3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logisticsinformation4
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

    public class Children
    {
        public string type { get; set; }
        public object _struct { get; set; }
    }

    public class List
    {
        public string type { get; set; }
        public Struct66 _struct { get; set; }
    }

    public class Struct66
    {
        public Id29 id { get; set; }
        public Username1 username { get; set; }
        public Nickname3 nickname { get; set; }
        public Status14 status { get; set; }
        public Createtime4 createTime { get; set; }
        public Title13 title { get; set; }
        public Url4 url { get; set; }
        public Picurl4 picUrl { get; set; }
        public Sort6 sort { get; set; }
        public Memo6 memo { get; set; }
        public Description3 description { get; set; }
        public Type8 type { get; set; }
        public Codetype codeType { get; set; }
        public Quota7 quota { get; set; }
        public Total4 total { get; set; }
        public Priceavailable3 priceAvailable { get; set; }
        public Rangetype7 rangeType { get; set; }
        public Rangevalues7 rangeValues { get; set; }
        public Datetype2 dateType { get; set; }
        public Validstarttime3 validStartTime { get; set; }
        public Validendtime3 validEndTime { get; set; }
        public Fixedstartterm fixedStartTerm { get; set; }
        public Fixedendterm2 fixedEndTerm { get; set; }
        public Preferentialtype12 preferentialType { get; set; }
        public Percentoff3 percentOff { get; set; }
        public Priceoff3 priceOff { get; set; }
        public Discountpricelimit3 discountPriceLimit { get; set; }
        public Statfetchnum statFetchNum { get; set; }
        public Productspuid3 productSpuId { get; set; }
        public Productspuname productSpuName { get; set; }
        public Activitytype6 activityType { get; set; }
        public Starttime6 startTime { get; set; }
        public Endtime4 endTime { get; set; }
        public Timelimiteddiscount5 timeLimitedDiscount { get; set; }
        public Fullprivilege5 fullPrivilege { get; set; }
        public Templateid2 templateId { get; set; }
        public Name11 name { get; set; }
        public Sellpoint2 sellPoint { get; set; }
        public Cid3 cid { get; set; }
        public Categoryname categoryName { get; set; }
        public Picurls3 picUrls { get; set; }
        public Visible1 visible { get; set; }
        public Originalprice1 originalPrice { get; set; }
        public Buyprice5 buyPrice { get; set; }
        public Quantity8 quantity { get; set; }
        public Promotionactivityid promotionActivityId { get; set; }
        public Promotionactivitytitle promotionActivityTitle { get; set; }
        public Promotionactivitytype promotionActivityType { get; set; }
        public Mobile9 mobile { get; set; }
        public Avatar2 avatar { get; set; }
        public Transaction transaction { get; set; }
        public Appid2 appId { get; set; }
        public Createip1 createIp { get; set; }
        public Orderid8 orderId { get; set; }
        public Ordersubject2 orderSubject { get; set; }
        public Orderdescription1 orderDescription { get; set; }
        public Ordermemo1 orderMemo { get; set; }
        public Price5 price { get; set; }
        public Expiretime1 expireTime { get; set; }
        public Finishtime1 finishTime { get; set; }
        public Extensionid1 extensionId { get; set; }
        public Paychannel2 payChannel { get; set; }
        public Paymenttime4 paymentTime { get; set; }
        public Notifytime1 notifyTime { get; set; }
        public Tradeno tradeNo { get; set; }
        public Refundtotal1 refundTotal { get; set; }
    }

    public class Id29
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

    public class Status14
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Createtime4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Title13
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

    public class Sort6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Memo6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Description3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Type8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Codetype
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Quota7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Total4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Priceavailable3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rangetype7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rangevalues7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Datetype2
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

    public class Preferentialtype12
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

    public class Productspuname
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Activitytype6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Starttime6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Endtime4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Timelimiteddiscount5
    {
        public string type { get; set; }
        public Struct67 _struct { get; set; }
    }

    public class Struct67
    {
        public Quota8 quota { get; set; }
        public Items6 items { get; set; }
    }

    public class Quota8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Items6
    {
        public string type { get; set; }
        public Struct68 _struct { get; set; }
    }

    public class Struct68
    {
        public Spuid6 spuId { get; set; }
        public Preferentialtype13 preferentialType { get; set; }
        public Preferentialvalue8 preferentialValue { get; set; }
    }

    public class Spuid6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialtype13
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialvalue8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fullprivilege5
    {
        public string type { get; set; }
        public Struct69 _struct { get; set; }
    }

    public class Struct69
    {
        public Rangetype8 rangeType { get; set; }
        public Rangevalues8 rangeValues { get; set; }
        public Cycled4 cycled { get; set; }
        public Privileges4 privileges { get; set; }
    }

    public class Rangetype8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rangevalues8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Cycled4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Privileges4
    {
        public string type { get; set; }
        public Struct70 _struct { get; set; }
    }

    public class Struct70
    {
        public Meettype4 meetType { get; set; }
        public Meetvalue4 meetValue { get; set; }
        public Preferentialtype14 preferentialType { get; set; }
        public Preferentialvalue9 preferentialValue { get; set; }
    }

    public class Meettype4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Meetvalue4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialtype14
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialvalue9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Templateid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sellpoint2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Cid3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Categoryname
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Picurls3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Visible1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Originalprice1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Buyprice5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Quantity8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Promotionactivityid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Promotionactivitytitle
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Promotionactivitytype
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mobile9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Avatar2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Transaction
    {
        public string type { get; set; }
        public Struct71 _struct { get; set; }
    }

    public class Struct71
    {
        public Id30 id { get; set; }
        public Appid1 appId { get; set; }
        public Createip createIp { get; set; }
        public Orderid7 orderId { get; set; }
        public Ordersubject1 orderSubject { get; set; }
        public Orderdescription orderDescription { get; set; }
        public Ordermemo orderMemo { get; set; }
        public Price4 price { get; set; }
        public Status15 status { get; set; }
        public Expiretime expireTime { get; set; }
        public Finishtime finishTime { get; set; }
        public Extensionid extensionId { get; set; }
        public Paychannel1 payChannel { get; set; }
        public Paymenttime3 paymentTime { get; set; }
        public Notifytime notifyTime { get; set; }
        public Createtime5 createTime { get; set; }
        public Refundtotal refundTotal { get; set; }
    }

    public class Id30
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Appid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Createip
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderid7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Ordersubject1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderdescription
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Ordermemo
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Price4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status15
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Expiretime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Finishtime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Extensionid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Paychannel1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Paymenttime3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Notifytime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Createtime5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Refundtotal
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Appid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Createip1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderid8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Ordersubject2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderdescription1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Ordermemo1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Price5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Expiretime1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Finishtime1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Extensionid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Paychannel2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Paymenttime4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Notifytime1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Tradeno
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Refundtotal1
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

    public class Values
    {
        public string type { get; set; }
        public Struct72 _struct { get; set; }
    }

    public class Struct72
    {
        public Value2 value { get; set; }
        public Displayname2 displayName { get; set; }
        public Id31 id { get; set; }
        public Name12 name { get; set; }
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

    public class Id31
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Accesstoken1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Refreshtoken1
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
        public Struct73 _struct { get; set; }
    }

    public class Struct73
    {
        public Id32 id { get; set; }
        public Name13 name { get; set; }
        public Createtime6 createTime { get; set; }
        public Count1 count { get; set; }
    }

    public class Id32
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name13
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Createtime6
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

    public class Title14
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Picurl5
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

    public class Quota9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Priceavailable4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rangetype9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rangevalues9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Datetype3
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

    public class Preferentialtype15
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

    public class Productspuname1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Templateid3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Key
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Categories
    {
        public string type { get; set; }
        public Struct74 _struct { get; set; }
    }

    public class Struct74
    {
        public Id33 id { get; set; }
        public Name14 name { get; set; }
    }

    public class Id33
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name14
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userid5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Hasdefault3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Avatar3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Appid3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Createip2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Ordersubject3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderdescription2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Ordermemo2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Price6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Expiretime2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Finishtime2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Extensionid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Paychannel3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Notifytime2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Tradeno1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Refundtotal2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Invokeresponse
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Attrs1
    {
        public string type { get; set; }
        public Struct75 _struct { get; set; }
    }

    public class Struct75
    {
        public Id34 id { get; set; }
        public Name15 name { get; set; }
        public Status16 status { get; set; }
        public Createtime7 createTime { get; set; }
        public Values1 values { get; set; }
    }

    public class Id34
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name15
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status16
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Createtime7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Values1
    {
        public string type { get; set; }
        public Struct76 _struct { get; set; }
    }

    public class Struct76
    {
        public Id35 id { get; set; }
        public Name16 name { get; set; }
        public Status17 status { get; set; }
        public Createtime8 createTime { get; set; }
    }

    public class Id35
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name16
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status17
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Createtime8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Attrid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sellpoint3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Cid4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Picurls4
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
        public Struct77 _struct { get; set; }
    }

    public class Struct77
    {
        public Id36 id { get; set; }
        public Spuid7 spuId { get; set; }
        public Picurl6 picURL { get; set; }
        public Attrs2 attrs { get; set; }
        public Price7 price { get; set; }
        public Quantity9 quantity { get; set; }
    }

    public class Id36
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Spuid7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Picurl6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Attrs2
    {
        public string type { get; set; }
        public Struct78 _struct { get; set; }
    }

    public class Struct78
    {
        public Attrid3 attrId { get; set; }
        public Attrname1 attrName { get; set; }
        public Attrvalueid1 attrValueId { get; set; }
        public Attrvaluename1 attrValueName { get; set; }
    }

    public class Attrid3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Attrname1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Attrvalueid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Attrvaluename1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Price7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Quantity9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Spus1
    {
        public string type { get; set; }
        public Struct79 _struct { get; set; }
    }

    public class Struct79
    {
        public Id37 id { get; set; }
        public Name17 name { get; set; }
        public Sellpoint4 sellPoint { get; set; }
        public Description5 description { get; set; }
        public Cid5 cid { get; set; }
        public Picurls5 picUrls { get; set; }
        public Price8 price { get; set; }
        public Quantity10 quantity { get; set; }
    }

    public class Id37
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name17
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

    public class Cid5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Picurls5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Price8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Quantity10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Struct80
    {
        public Id38 id { get; set; }
        public Status18 status { get; set; }
        public Userid6 userId { get; set; }
        public Spuid8 spuId { get; set; }
        public Skuid7 skuId { get; set; }
        public Quantity11 quantity { get; set; }
        public Orderid9 orderId { get; set; }
        public Ordercreatetime orderCreateTime { get; set; }
        public Createtime9 createTime { get; set; }
        public Selected3 selected { get; set; }
        public Itemgroups1 itemGroups { get; set; }
        public Couponcardid1 couponCardId { get; set; }
        public Couponcarddiscounttotal1 couponCardDiscountTotal { get; set; }
        public Postage postage { get; set; }
        public Fee1 fee { get; set; }
        public Originalprice2 originalPrice { get; set; }
        public Buyprice7 buyPrice { get; set; }
        public Fullprivilege8 fullPrivilege { get; set; }
        public Timelimiteddiscount9 timeLimitedDiscount { get; set; }
        public Name19 name { get; set; }
        public Type9 type { get; set; }
        public Sort8 sort { get; set; }
        public Displayname3 displayName { get; set; }
        public Pid2 pid { get; set; }
        public Handler2 handler { get; set; }
        public Title19 title { get; set; }
        public Url6 url { get; set; }
        public Picurl8 picUrl { get; set; }
        public Memo7 memo { get; set; }
        public Available1 available { get; set; }
        public Unavailablereason1 unavailableReason { get; set; }
        public Productspuid5 productSpuId { get; set; }
        public Activitytype11 activityType { get; set; }
        public Starttime11 startTime { get; set; }
        public Endtime9 endTime { get; set; }
        public Total5 total { get; set; }
        public List1 list { get; set; }
        public Categories1 categories { get; set; }
    }

    public class Id38
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status18
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userid6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Spuid8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Skuid7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Quantity11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderid9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Ordercreatetime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Createtime9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Selected3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Itemgroups1
    {
        public string type { get; set; }
        public Struct81 _struct { get; set; }
    }

    public class Struct81
    {
        public Activity2 activity { get; set; }
        public Activitydiscounttotal1 activityDiscountTotal { get; set; }
        public Items8 items { get; set; }
    }

    public class Activity2
    {
        public string type { get; set; }
        public Struct82 _struct { get; set; }
    }

    public class Struct82
    {
        public Id39 id { get; set; }
        public Title15 title { get; set; }
        public Activitytype7 activityType { get; set; }
        public Status19 status { get; set; }
        public Starttime7 startTime { get; set; }
        public Endtime5 endTime { get; set; }
        public Timelimiteddiscount6 timeLimitedDiscount { get; set; }
        public Fullprivilege6 fullPrivilege { get; set; }
    }

    public class Id39
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Title15
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Activitytype7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status19
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Starttime7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Endtime5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Timelimiteddiscount6
    {
        public string type { get; set; }
        public Struct83 _struct { get; set; }
    }

    public class Struct83
    {
        public Quota10 quota { get; set; }
        public Items7 items { get; set; }
    }

    public class Quota10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Items7
    {
        public string type { get; set; }
        public Struct84 _struct { get; set; }
    }

    public class Struct84
    {
        public Spuid9 spuId { get; set; }
        public Preferentialtype16 preferentialType { get; set; }
        public Preferentialvalue10 preferentialValue { get; set; }
    }

    public class Spuid9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialtype16
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialvalue10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fullprivilege6
    {
        public string type { get; set; }
        public Struct85 _struct { get; set; }
    }

    public class Struct85
    {
        public Rangetype10 rangeType { get; set; }
        public Rangevalues10 rangeValues { get; set; }
        public Cycled5 cycled { get; set; }
        public Privileges5 privileges { get; set; }
    }

    public class Rangetype10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rangevalues10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Cycled5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Privileges5
    {
        public string type { get; set; }
        public Struct86 _struct { get; set; }
    }

    public class Struct86
    {
        public Meettype5 meetType { get; set; }
        public Meetvalue5 meetValue { get; set; }
        public Preferentialtype17 preferentialType { get; set; }
        public Preferentialvalue11 preferentialValue { get; set; }
    }

    public class Meettype5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Meetvalue5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialtype17
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialvalue11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Activitydiscounttotal1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Items8
    {
        public string type { get; set; }
        public Struct87 _struct { get; set; }
    }

    public class Struct87
    {
        public Id40 id { get; set; }
        public Picurl7 picURL { get; set; }
        public Price9 price { get; set; }
        public Quantity12 quantity { get; set; }
        public Buyquantity1 buyQuantity { get; set; }
        public Originprice4 originPrice { get; set; }
        public Buyprice6 buyPrice { get; set; }
        public Presentprice5 presentPrice { get; set; }
        public Buytotal5 buyTotal { get; set; }
        public Discounttotal5 discountTotal { get; set; }
        public Presenttotal5 presentTotal { get; set; }
        public Selected4 selected { get; set; }
        public Activity3 activity { get; set; }
        public Attrs3 attrs { get; set; }
        public Spu1 spu { get; set; }
    }

    public class Id40
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Picurl7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Price9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Quantity12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Buyquantity1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Originprice4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Buyprice6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Presentprice5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Buytotal5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Discounttotal5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Presenttotal5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Selected4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Activity3
    {
        public string type { get; set; }
        public Struct88 _struct { get; set; }
    }

    public class Struct88
    {
        public Id41 id { get; set; }
        public Title16 title { get; set; }
        public Activitytype8 activityType { get; set; }
        public Status20 status { get; set; }
        public Starttime8 startTime { get; set; }
        public Endtime6 endTime { get; set; }
        public Timelimiteddiscount7 timeLimitedDiscount { get; set; }
        public Fullprivilege7 fullPrivilege { get; set; }
    }

    public class Id41
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Title16
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Activitytype8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status20
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Starttime8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Endtime6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Timelimiteddiscount7
    {
        public string type { get; set; }
        public Struct89 _struct { get; set; }
    }

    public class Struct89
    {
        public Quota11 quota { get; set; }
        public Items9 items { get; set; }
    }

    public class Quota11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Items9
    {
        public string type { get; set; }
        public Struct90 _struct { get; set; }
    }

    public class Struct90
    {
        public Spuid10 spuId { get; set; }
        public Preferentialtype18 preferentialType { get; set; }
        public Preferentialvalue12 preferentialValue { get; set; }
    }

    public class Spuid10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialtype18
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialvalue12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fullprivilege7
    {
        public string type { get; set; }
        public Struct91 _struct { get; set; }
    }

    public class Struct91
    {
        public Rangetype11 rangeType { get; set; }
        public Rangevalues11 rangeValues { get; set; }
        public Cycled6 cycled { get; set; }
        public Privileges6 privileges { get; set; }
    }

    public class Rangetype11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rangevalues11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Cycled6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Privileges6
    {
        public string type { get; set; }
        public Struct92 _struct { get; set; }
    }

    public class Struct92
    {
        public Meettype6 meetType { get; set; }
        public Meetvalue6 meetValue { get; set; }
        public Preferentialtype19 preferentialType { get; set; }
        public Preferentialvalue13 preferentialValue { get; set; }
    }

    public class Meettype6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Meetvalue6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialtype19
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialvalue13
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Attrs3
    {
        public string type { get; set; }
        public Struct93 _struct { get; set; }
    }

    public class Struct93
    {
        public Attrid4 attrId { get; set; }
        public Attrname2 attrName { get; set; }
        public Attrvalueid2 attrValueId { get; set; }
        public Attrvaluename2 attrValueName { get; set; }
    }

    public class Attrid4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Attrname2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Attrvalueid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Attrvaluename2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Spu1
    {
        public string type { get; set; }
        public Struct94 _struct { get; set; }
    }

    public class Struct94
    {
        public Id42 id { get; set; }
        public Name18 name { get; set; }
        public Cid6 cid { get; set; }
        public Picurls6 picUrls { get; set; }
        public Description6 description { get; set; }
        public Sellpoint5 sellPoint { get; set; }
        public Sort7 sort { get; set; }
        public Visible3 visible { get; set; }
    }

    public class Id42
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name18
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Cid6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Picurls6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Description6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sellpoint5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Visible3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Couponcardid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Couponcarddiscounttotal1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Postage
    {
        public string type { get; set; }
        public Struct95 _struct { get; set; }
    }

    public class Struct95
    {
        public Threshold threshold { get; set; }
    }

    public class Threshold
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fee1
    {
        public string type { get; set; }
        public Struct96 _struct { get; set; }
    }

    public class Struct96
    {
        public Buytotal6 buyTotal { get; set; }
        public Discounttotal6 discountTotal { get; set; }
        public Postagetotal1 postageTotal { get; set; }
        public Presenttotal6 presentTotal { get; set; }
    }

    public class Buytotal6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Discounttotal6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Postagetotal1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Presenttotal6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Originalprice2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Buyprice7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fullprivilege8
    {
        public string type { get; set; }
        public Struct97 _struct { get; set; }
    }

    public class Struct97
    {
        public Id43 id { get; set; }
        public Title17 title { get; set; }
        public Activitytype9 activityType { get; set; }
        public Status21 status { get; set; }
        public Starttime9 startTime { get; set; }
        public Endtime7 endTime { get; set; }
        public Timelimiteddiscount8 timeLimitedDiscount { get; set; }
        public Fullprivilege9 fullPrivilege { get; set; }
        public Rangetype13 rangeType { get; set; }
        public Rangevalues13 rangeValues { get; set; }
        public Cycled8 cycled { get; set; }
        public Privileges8 privileges { get; set; }
    }

    public class Id43
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Title17
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Activitytype9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status21
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Starttime9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Endtime7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Timelimiteddiscount8
    {
        public string type { get; set; }
        public Struct98 _struct { get; set; }
    }

    public class Struct98
    {
        public Quota12 quota { get; set; }
        public Items10 items { get; set; }
    }

    public class Quota12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Items10
    {
        public string type { get; set; }
        public Struct99 _struct { get; set; }
    }

    public class Struct99
    {
        public Spuid11 spuId { get; set; }
        public Preferentialtype20 preferentialType { get; set; }
        public Preferentialvalue14 preferentialValue { get; set; }
    }

    public class Spuid11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialtype20
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialvalue14
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fullprivilege9
    {
        public string type { get; set; }
        public Struct100 _struct { get; set; }
    }

    public class Struct100
    {
        public Rangetype12 rangeType { get; set; }
        public Rangevalues12 rangeValues { get; set; }
        public Cycled7 cycled { get; set; }
        public Privileges7 privileges { get; set; }
    }

    public class Rangetype12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rangevalues12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Cycled7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Privileges7
    {
        public string type { get; set; }
        public Struct101 _struct { get; set; }
    }

    public class Struct101
    {
        public Meettype7 meetType { get; set; }
        public Meetvalue7 meetValue { get; set; }
        public Preferentialtype21 preferentialType { get; set; }
        public Preferentialvalue15 preferentialValue { get; set; }
    }

    public class Meettype7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Meetvalue7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialtype21
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialvalue15
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rangetype13
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rangevalues13
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Cycled8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Privileges8
    {
        public string type { get; set; }
        public Struct102 _struct { get; set; }
    }

    public class Struct102
    {
        public Meettype8 meetType { get; set; }
        public Meetvalue8 meetValue { get; set; }
        public Preferentialtype22 preferentialType { get; set; }
        public Preferentialvalue16 preferentialValue { get; set; }
    }

    public class Meettype8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Meetvalue8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialtype22
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialvalue16
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Timelimiteddiscount9
    {
        public string type { get; set; }
        public Struct103 _struct { get; set; }
    }

    public class Struct103
    {
        public Id44 id { get; set; }
        public Title18 title { get; set; }
        public Activitytype10 activityType { get; set; }
        public Status22 status { get; set; }
        public Starttime10 startTime { get; set; }
        public Endtime8 endTime { get; set; }
        public Timelimiteddiscount10 timeLimitedDiscount { get; set; }
        public Fullprivilege10 fullPrivilege { get; set; }
        public Quota14 quota { get; set; }
        public Items12 items { get; set; }
    }

    public class Id44
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Title18
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Activitytype10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status22
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Starttime10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Endtime8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Timelimiteddiscount10
    {
        public string type { get; set; }
        public Struct104 _struct { get; set; }
    }

    public class Struct104
    {
        public Quota13 quota { get; set; }
        public Items11 items { get; set; }
    }

    public class Quota13
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Items11
    {
        public string type { get; set; }
        public Struct105 _struct { get; set; }
    }

    public class Struct105
    {
        public Spuid12 spuId { get; set; }
        public Preferentialtype23 preferentialType { get; set; }
        public Preferentialvalue17 preferentialValue { get; set; }
    }

    public class Spuid12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialtype23
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialvalue17
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fullprivilege10
    {
        public string type { get; set; }
        public Struct106 _struct { get; set; }
    }

    public class Struct106
    {
        public Rangetype14 rangeType { get; set; }
        public Rangevalues14 rangeValues { get; set; }
        public Cycled9 cycled { get; set; }
        public Privileges9 privileges { get; set; }
    }

    public class Rangetype14
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rangevalues14
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Cycled9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Privileges9
    {
        public string type { get; set; }
        public Struct107 _struct { get; set; }
    }

    public class Struct107
    {
        public Meettype9 meetType { get; set; }
        public Meetvalue9 meetValue { get; set; }
        public Preferentialtype24 preferentialType { get; set; }
        public Preferentialvalue18 preferentialValue { get; set; }
    }

    public class Meettype9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Meetvalue9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialtype24
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialvalue18
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Quota14
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Items12
    {
        public string type { get; set; }
        public Struct108 _struct { get; set; }
    }

    public class Struct108
    {
        public Spuid13 spuId { get; set; }
        public Preferentialtype25 preferentialType { get; set; }
        public Preferentialvalue19 preferentialValue { get; set; }
    }

    public class Spuid13
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialtype25
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialvalue19
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name19
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Type9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Displayname3
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

    public class Title19
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Picurl8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Memo7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Available1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Unavailablereason1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Productspuid5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Activitytype11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Starttime11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Endtime9
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
        public Struct109 _struct { get; set; }
    }

    public class Struct109
    {
        public Id45 id { get; set; }
        public Name20 name { get; set; }
        public Sellpoint6 sellPoint { get; set; }
        public Description7 description { get; set; }
        public Cid7 cid { get; set; }
        public Categoryname1 categoryName { get; set; }
        public Picurls7 picUrls { get; set; }
        public Visible4 visible { get; set; }
        public Sort9 sort { get; set; }
        public Originalprice3 originalPrice { get; set; }
        public Buyprice8 buyPrice { get; set; }
        public Quantity13 quantity { get; set; }
        public Promotionactivityid1 promotionActivityId { get; set; }
        public Promotionactivitytitle1 promotionActivityTitle { get; set; }
        public Promotionactivitytype1 promotionActivityType { get; set; }
    }

    public class Id45
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name20
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sellpoint6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Description7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Cid7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Categoryname1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Picurls7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Visible4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Originalprice3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Buyprice8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Quantity13
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Promotionactivityid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Promotionactivitytitle1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Promotionactivitytype1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Categories1
    {
        public string type { get; set; }
        public Struct110 _struct { get; set; }
    }

    public class Struct110
    {
        public Id46 id { get; set; }
        public Name21 name { get; set; }
    }

    public class Id46
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name21
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Total6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class List2
    {
        public string type { get; set; }
        public Struct111 _struct { get; set; }
    }

    public class Struct111
    {
        public Id47 id { get; set; }
        public Title20 title { get; set; }
        public Url7 url { get; set; }
        public Picurl9 picUrl { get; set; }
        public Sort10 sort { get; set; }
        public Status23 status { get; set; }
        public Memo8 memo { get; set; }
        public Createtime10 createTime { get; set; }
        public Description8 description { get; set; }
        public Type10 type { get; set; }
        public Codetype2 codeType { get; set; }
        public Quota15 quota { get; set; }
        public Total7 total { get; set; }
        public Priceavailable5 priceAvailable { get; set; }
        public Rangetype15 rangeType { get; set; }
        public Rangevalues15 rangeValues { get; set; }
        public Datetype4 dateType { get; set; }
        public Validstarttime5 validStartTime { get; set; }
        public Validendtime5 validEndTime { get; set; }
        public Fixedstartterm2 fixedStartTerm { get; set; }
        public Fixedendterm4 fixedEndTerm { get; set; }
        public Preferentialtype26 preferentialType { get; set; }
        public Percentoff5 percentOff { get; set; }
        public Priceoff5 priceOff { get; set; }
        public Discountpricelimit5 discountPriceLimit { get; set; }
        public Statfetchnum2 statFetchNum { get; set; }
        public Templateid4 templateId { get; set; }
        public Userid7 userId { get; set; }
        public Taketype1 takeType { get; set; }
        public Usedtime1 usedTime { get; set; }
        public Productspuid6 productSpuId { get; set; }
        public Activitytype12 activityType { get; set; }
        public Starttime12 startTime { get; set; }
        public Endtime10 endTime { get; set; }
        public Timelimiteddiscount11 timeLimitedDiscount { get; set; }
        public Fullprivilege11 fullPrivilege { get; set; }
        public Mobile10 mobile { get; set; }
        public Nickname5 nickname { get; set; }
        public Avatar4 avatar { get; set; }
    }

    public class Id47
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Title20
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Picurl9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status23
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Memo8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Createtime10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Description8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Type10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Codetype2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Quota15
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Total7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Priceavailable5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rangetype15
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rangevalues15
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Datetype4
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

    public class Preferentialtype26
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

    public class Statfetchnum2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Templateid4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userid7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Taketype1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usedtime1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Productspuid6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Activitytype12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Starttime12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Endtime10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Timelimiteddiscount11
    {
        public string type { get; set; }
        public Struct112 _struct { get; set; }
    }

    public class Struct112
    {
        public Quota16 quota { get; set; }
        public Items13 items { get; set; }
    }

    public class Quota16
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Items13
    {
        public string type { get; set; }
        public Struct113 _struct { get; set; }
    }

    public class Struct113
    {
        public Spuid14 spuId { get; set; }
        public Preferentialtype27 preferentialType { get; set; }
        public Preferentialvalue20 preferentialValue { get; set; }
    }

    public class Spuid14
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialtype27
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialvalue20
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Fullprivilege11
    {
        public string type { get; set; }
        public Struct114 _struct { get; set; }
    }

    public class Struct114
    {
        public Rangetype16 rangeType { get; set; }
        public Rangevalues16 rangeValues { get; set; }
        public Cycled10 cycled { get; set; }
        public Privileges10 privileges { get; set; }
    }

    public class Rangetype16
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rangevalues16
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Cycled10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Privileges10
    {
        public string type { get; set; }
        public Struct115 _struct { get; set; }
    }

    public class Struct115
    {
        public Meettype10 meetType { get; set; }
        public Meetvalue10 meetValue { get; set; }
        public Preferentialtype28 preferentialType { get; set; }
        public Preferentialvalue21 preferentialValue { get; set; }
    }

    public class Meettype10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Meetvalue10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialtype28
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Preferentialvalue21
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mobile10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Nickname5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Avatar4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Id48
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Title21
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Picurl10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status24
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Memo9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Createtime11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Description9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Codetype3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Quota17
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Priceavailable6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rangetype17
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rangevalues17
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Datetype5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Validstarttime6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Validendtime6
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

    public class Preferentialtype29
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Percentoff6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Priceoff6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Discountpricelimit6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Statfetchnum3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Templateid5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userid8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Taketype2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usedtime2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Used
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

    public class Productspuid7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Accesstoken2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Refreshtoken2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Expiresin1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mobile11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Nickname6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Avatar5
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

    public class Publish
    {
        public string name { get; set; }
        public string[] filePaths { get; set; }
    }

    public class Subscribe
    {
        public string name { get; set; }
        public string[] filePaths { get; set; }
    }

    public class Topic
    {
        public string name { get; set; }
        public string[] filePaths { get; set; }
        public Inputparamstruct1 inputParamStruct { get; set; }
    }

    public class Inputparamstruct1
    {
        public Message4 message { get; set; }
    }

    public class Message4
    {
        public string id { get; set; }
    }

}
