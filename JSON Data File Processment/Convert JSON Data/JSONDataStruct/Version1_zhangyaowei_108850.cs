using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_JSON_Data.JSONDataStruct.Version1_zhangyaowei_108850
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
        public Newitem newItem { get; set; }
        public object prodId { get; set; }
        public Id1 id { get; set; }
        public Quantity1 quantity { get; set; }
        public Ids ids { get; set; }
        public Catid catId { get; set; }
        public Orderform orderForm { get; set; }
        public object orderId { get; set; }
        public string status { get; set; }
        public Orderitemlist orderItemList { get; set; }
        public string name { get; set; }
        public string oid { get; set; }
        public string PaymentMockApi { get; set; }
        public string userId { get; set; }
        public string type { get; set; }
        public Struct6 _struct { get; set; }
        public string promotion { get; set; }
        public Pgid pgId { get; set; }
        public Orderitemid orderItemId { get; set; }
        public Productid productId { get; set; }
        public Rate rate { get; set; }
        public Content content { get; set; }
        public Isanonymous isAnonymous { get; set; }
        public Keyword keyword { get; set; }
        public Cp cp { get; set; }
        public Brandid brandId { get; set; }
        public Filters filters { get; set; }
        public Pricerange priceRange { get; set; }
        public Orderby orderBy { get; set; }
        public Addressid1 addressId { get; set; }
        public Usertoken userToken { get; set; }
        public User user { get; set; }
        public Mobile mobile { get; set; }
        public Userexample userExample { get; set; }
        public Form form { get; set; }
    }

    public class Newitem
    {
        public string type { get; set; }
        public Struct _struct { get; set; }
    }

    public class Struct
    {
        public Id id { get; set; }
        public Createdate createDate { get; set; }
        public Updatedate updateDate { get; set; }
        public Deleted deleted { get; set; }
        public Prodid prodId { get; set; }
        public Quantity quantity { get; set; }
        public Userid userId { get; set; }
        public Isselected isSelected { get; set; }
        public Prodname prodName { get; set; }
        public Originalprice originalPrice { get; set; }
        public Price price { get; set; }
        public Prodimgpath prodImgPath { get; set; }
        public Productonsale productOnSale { get; set; }
        public Subtotal subTotal { get; set; }
        public Originalsubtotal originalSubTotal { get; set; }
        public Subtotaldiscounted subTotalDiscounted { get; set; }
        public Pricediscounted priceDiscounted { get; set; }
        public Promotionlist promotionList { get; set; }
        public Couponlist couponList { get; set; }
        public Speclist specList { get; set; }
        public Dlyfee dlyFee { get; set; }
    }

    public class Id
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

    public class Prodid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Quantity
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Isselected
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodname
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Originalprice
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Price
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodimgpath
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Productonsale
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Subtotal
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Originalsubtotal
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Subtotaldiscounted
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pricediscounted
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Promotionlist
    {
        public string type { get; set; }
        public Struct1 _struct { get; set; }
    }

    public class Struct1
    {
        public Name name { get; set; }
        public Selectable selectable { get; set; }
        public Selected selected { get; set; }
    }

    public class Name
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Selectable
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Selected
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Couponlist
    {
        public string type { get; set; }
        public Struct2 _struct { get; set; }
    }

    public class Struct2
    {
        public Name1 name { get; set; }
        public Selectable1 selectable { get; set; }
        public Selected1 selected { get; set; }
    }

    public class Name1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Selectable1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Selected1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Speclist
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Dlyfee
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Id1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Quantity1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Ids
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Catid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderform
    {
        public string type { get; set; }
        public Struct3 _struct { get; set; }
    }

    public class Struct3
    {
        public Paymethodcode payMethodCode { get; set; }
        public Addressid addressId { get; set; }
        public Prodtotalprice prodTotalPrice { get; set; }
        public Totalprice totalPrice { get; set; }
        public Usedpoints usedPoints { get; set; }
        public Usedcouponid usedCouponId { get; set; }
        public Usedbalance usedBalance { get; set; }
        public Invoicetype invoiceType { get; set; }
        public Invoicetitle invoiceTitle { get; set; }
        public Invoicetitletype invoiceTitleType { get; set; }
        public Invoicecontenttype invoiceContentType { get; set; }
        public Invoicephone invoicePhone { get; set; }
        public Invoiceemail invoiceEmail { get; set; }
        public Items items { get; set; }
    }

    public class Paymethodcode
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Addressid
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

    public class Usedpoints
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usedcouponid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usedbalance
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Invoicetype
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Invoicetitle
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Invoicetitletype
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Invoicecontenttype
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Invoicephone
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Invoiceemail
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Items
    {
        public string type { get; set; }
        public Struct4 _struct { get; set; }
    }

    public class Struct4
    {
        public Prodid1 prodId { get; set; }
        public Quantity2 quantity { get; set; }
        public Price1 price { get; set; }
        public Subtotal1 subtotal { get; set; }
    }

    public class Prodid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Quantity2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Price1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Subtotal1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderitemlist
    {
        public string type { get; set; }
        public Struct5 _struct { get; set; }
    }

    public class Struct5
    {
        public string id { get; set; }
        public string orderId { get; set; }
        public string userId { get; set; }
    }

    public class Struct6
    {
        public string prodId { get; set; }
        public string quantity { get; set; }
        public string usedPoints { get; set; }
        public string usedCouponId { get; set; }
        public string prodIds { get; set; }
        public string type { get; set; }
        public Struct7 _struct { get; set; }
        public string accepted { get; set; }
        public string message { get; set; }
        public string scope { get; set; }
    }

    public class Struct7
    {
        public string productIdList { get; set; }
    }

    public class Pgid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderitemid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Productid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rate
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Content
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Isanonymous
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keyword
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Cp
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brandid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Filters
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pricerange
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderby
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Addressid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usertoken
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

    public class Form
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Outputparamstruct
    {
        public object status { get; set; }
        public object data { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string message { get; set; }
        public string redirectUrl { get; set; }
        public string imageServer { get; set; }
        public A a { get; set; }
    }

    public class A
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
