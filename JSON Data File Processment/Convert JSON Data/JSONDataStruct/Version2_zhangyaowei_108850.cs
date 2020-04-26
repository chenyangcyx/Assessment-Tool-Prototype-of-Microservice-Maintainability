using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_JSON_Data.JSONDataStruct.Version2_zhangyaowei_108850
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
        public string tag { get; set; }
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
        public object[] otherPaths { get; set; }
        public Interface[] interfaces { get; set; }
        public Call[] call { get; set; }
        public Subscribe[] subscribe { get; set; }
        public Publish[] publish { get; set; }
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
        public string type { get; set; }
        public string name { get; set; }
        public Pid pid { get; set; }
        public Amount amount { get; set; }
        public Id id { get; set; }
        public Optionid optionId { get; set; }
        public object prodId { get; set; }
        public Option option { get; set; }
        public Brand brand { get; set; }
        public Logofile logoFile { get; set; }
        public Params _params { get; set; }
        public Catid catId { get; set; }
        public Category category { get; set; }
        public Start start { get; set; }
        public Pagesize pagesize { get; set; }
        public Request request { get; set; }
        public File1 file { get; set; }
        public Specoption specOption { get; set; }
        public Usertoken userToken { get; set; }
        public Order order { get; set; }
        public object orderId { get; set; }
        public Token token { get; set; }
        public string status { get; set; }
        public Orderitemlist1 orderItemList { get; set; }
        public string oid { get; set; }
        public string PaymentMockApi { get; set; }
        public string userId { get; set; }
        public Struct4 _struct { get; set; }
        public string promotion { get; set; }
        public Keyword keyword { get; set; }
        public Address address { get; set; }
        public User_Key user_key { get; set; }
        public User user { get; set; }
        public Mobile mobile { get; set; }
        public Userexample userExample { get; set; }
    }

    public class Pid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Amount
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Id
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Optionid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Option
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brand
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logofile
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Params
    {
        public string type { get; set; }
        public Struct _struct { get; set; }
    }

    public class Struct
    {
        public Logokey logoKey { get; set; }
        public File file { get; set; }
    }

    public class Logokey
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class File
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Catid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Category
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Start
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pagesize
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Request
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class File1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Specoption
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usertoken
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Order
    {
        public Id1 id { get; set; }
        public Createdate createDate { get; set; }
        public Updatedate updateDate { get; set; }
        public Deleted deleted { get; set; }
        public Sn sn { get; set; }
        public Status status { get; set; }
        public Cancelreason cancelReason { get; set; }
        public Userid userId { get; set; }
        public Paymentid paymentId { get; set; }
        public Paymethodid payMethodId { get; set; }
        public Paymethodname payMethodName { get; set; }
        public Deliveryid deliveryId { get; set; }
        public Deliveryaddressid deliveryAddressId { get; set; }
        public Deliveryconsignee deliveryConsignee { get; set; }
        public Deliveryaddress deliveryAddress { get; set; }
        public Deliverymobile deliveryMobile { get; set; }
        public Deliveryemail deliveryEmail { get; set; }
        public Deliverymethod deliveryMethod { get; set; }
        public Note note { get; set; }
        public Freight freight { get; set; }
        public Prodtotalprice prodTotalPrice { get; set; }
        public Totalprice totalPrice { get; set; }
        public Ispointused isPointUsed { get; set; }
        public Gainedpoint gainedPoint { get; set; }
        public Usedpoint usedPoint { get; set; }
        public Iscouponused isCouponUsed { get; set; }
        public Usedcouponid usedCouponId { get; set; }
        public Usedcouponmsg usedCouponMsg { get; set; }
        public Isbalanceused isBalanceUsed { get; set; }
        public Usedbalance usedBalance { get; set; }
        public Hasexpired hasExpired { get; set; }
        public Lefttime leftTime { get; set; }
        public Coupondeductionamount couponDeductionAmount { get; set; }
        public Pointsdeductionamount pointsDeductionAmount { get; set; }
        public Balancedeductionamount balanceDeductionAmount { get; set; }
        public Invoice invoice { get; set; }
        public Orderitemlist orderItemList { get; set; }
    }

    public class Id1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Createdate
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Updatedate
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Deleted
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sn
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Status
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Cancelreason
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Paymentid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Paymethodid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Paymethodname
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Deliveryid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Deliveryaddressid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Deliveryconsignee
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Deliveryaddress
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Deliverymobile
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Deliveryemail
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Deliverymethod
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Note
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Freight
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodtotalprice
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Totalprice
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Ispointused
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Gainedpoint
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usedpoint
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Iscouponused
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usedcouponid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usedcouponmsg
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Isbalanceused
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usedbalance
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Hasexpired
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Lefttime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Coupondeductionamount
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pointsdeductionamount
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Balancedeductionamount
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Invoice
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderitemlist
    {
        public string type { get; set; }
        public Struct1 _struct { get; set; }
    }

    public class Struct1
    {
        public Id2 id { get; set; }
        public Createdate1 createDate { get; set; }
        public Updatedate1 updateDate { get; set; }
        public Deleted1 deleted { get; set; }
        public Orderid orderId { get; set; }
        public Userid1 userId { get; set; }
        public Prodid prodId { get; set; }
        public Dealprice dealPrice { get; set; }
        public Dealsubtotal dealSubTotal { get; set; }
        public Quantity quantity { get; set; }
        public Gainedpoint1 gainedPoint { get; set; }
        public Commentstatus commentStatus { get; set; }
        public Promotion promotion { get; set; }
        public Prodname prodName { get; set; }
        public Prodimg prodImg { get; set; }
        public Specs specs { get; set; }
        public Promotions promotions { get; set; }
        public Originalprice originalPrice { get; set; }
        public Originalsubtotal originalSubTotal { get; set; }
    }

    public class Id2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Createdate1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Updatedate1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Deleted1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Dealprice
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Dealsubtotal
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Quantity
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Gainedpoint1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Commentstatus
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Promotion
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodname
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodimg
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Specs
    {
        public string type { get; set; }
        public Struct2 _struct { get; set; }
    }

    public class Struct2
    {
        public Name name { get; set; }
        public Value value { get; set; }
    }

    public class Name
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Value
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Promotions
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Originalprice
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Originalsubtotal
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Token
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderitemlist1
    {
        public string type { get; set; }
        public Struct3 _struct { get; set; }
    }

    public class Struct3
    {
        public string id { get; set; }
        public string orderId { get; set; }
        public string userId { get; set; }
    }

    public class Struct4
    {
        public string prodId { get; set; }
        public string quantity { get; set; }
        public string usedPoints { get; set; }
        public string usedCouponId { get; set; }
        public string prodIds { get; set; }
        public string type { get; set; }
        public Struct5 _struct { get; set; }
        public string accepted { get; set; }
        public string message { get; set; }
        public string scope { get; set; }
    }

    public class Struct5
    {
        public string productIdList { get; set; }
    }

    public class Keyword
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Address
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class User_Key
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class User
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mobile
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userexample
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Outputparamstruct
    {
        public string type { get; set; }
        public string name { get; set; }
        public object status { get; set; }
        public object data { get; set; }
        public object message { get; set; }
        public Date date { get; set; }
        public string redirectUrl { get; set; }
        public string imageServer { get; set; }
    }

    public class Date
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

    public class Subscribe
    {
        public string name { get; set; }
        public object filePaths { get; set; }
    }

    public class Publish
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
        public Id3 id { get; set; }
        public Mobile1 mobile { get; set; }
        public Code code { get; set; }
        public Name1 name { get; set; }
        public Logo logo { get; set; }
        public Categoryid categoryId { get; set; }
        public Recommended recommended { get; set; }
        public Description description { get; set; }
        public Ordernum orderNum { get; set; }
        public Pgid pgId { get; set; }
        public Createdate2 createDate { get; set; }
        public Updatedate2 updateDate { get; set; }
        public Deleted2 deleted { get; set; }
        public Price price { get; set; }
        public Imagepath imagePath { get; set; }
        public Brandid brandId { get; set; }
        public Origin origin { get; set; }
        public Relatedcount relatedCount { get; set; }
        public Orderid1 orderId { get; set; }
        public Orderitemid orderItemId { get; set; }
        public Commentid commentId { get; set; }
        public Methodid methodId { get; set; }
    }

    public class Id3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mobile1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Code
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Logo
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Categoryid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Recommended
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Description
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Ordernum
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pgid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Createdate2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Updatedate2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Deleted2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Price
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Imagepath
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brandid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Origin
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Relatedcount
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderitemid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Commentid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Methodid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

}
