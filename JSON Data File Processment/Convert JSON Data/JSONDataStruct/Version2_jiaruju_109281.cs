using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_JSON_Data.JSONDataStruct.Version2_jiaruju_109281
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
        public Loginreq LoginReq { get; set; }
        public Httprsp httpRsp { get; set; }
        public Registerreq RegisterReq { get; set; }
        public Userqueryreq UserQueryReq { get; set; }
        public Batchreq BatchReq { get; set; }
        public Admincreatereq AdminCreateReq { get; set; }
        public Roleid2 roleId { get; set; }
        public Rolemenureq RoleMenuReq { get; set; }
        public Rolepermissionreq RolePermissionReq { get; set; }
        public Prodinsertreq ProdInsertReq { get; set; }
        public Prodqueryreq ProdQueryReq { get; set; }
        public Categoryentity CategoryEntity { get; set; }
        public Categoryid categoryId { get; set; }
        public Categoryqueryreq CategoryQueryReq { get; set; }
        public Brandinsertreq BrandInsertReq { get; set; }
        public Brandqueryreq BrandQueryReq { get; set; }
        public Orderqueryreq OrderQueryReq { get; set; }
        public Buyerid1 buyerId { get; set; }
        public Sellerid1 sellerId { get; set; }
        public Orderinsertreq OrderInsertReq { get; set; }
        public Orderid orderId { get; set; }
        public Userid2 userId { get; set; }
        public Expressno1 expressNo { get; set; }
        public Keys keys { get; set; }
        public Pattern pattern { get; set; }
        public Key key { get; set; }
        public Value value { get; set; }
        public Expiretime expireTime { get; set; }
        public Map map { get; set; }
        public Prodinsertreq1 prodInsertReq { get; set; }
        public Produpdatereq prodUpdateReq { get; set; }
        public Prodqueryreq1 prodQueryReq { get; set; }
        public Categoryentity1 categoryEntity { get; set; }
        public Brandinsertreq1 brandInsertReq { get; set; }
        public Categoryqueryreq1 categoryQueryReq { get; set; }
        public Brandqueryreq1 brandQueryReq { get; set; }
        public Userqueryreq1 userQueryReq { get; set; }
        public Registerreq1 registerReq { get; set; }
        public Userstatereqs userStateReqs { get; set; }
        public Admincreatereq1 adminCreateReq { get; set; }
        public Rolemenureq1 roleMenuReq { get; set; }
        public Rolepermissionreq1 rolePermissionReq { get; set; }
    }

    public class Loginreq
    {
        public string type { get; set; }
        public Struct _struct { get; set; }
    }

    public class Struct
    {
        public Username username { get; set; }
        public Password password { get; set; }
        public Phone phone { get; set; }
        public Mail mail { get; set; }
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

    public class Phone
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mail
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Httprsp
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Registerreq
    {
        public string type { get; set; }
        public Struct1 _struct { get; set; }
    }

    public class Struct1
    {
        public Username1 username { get; set; }
        public Password1 password { get; set; }
        public Phone1 phone { get; set; }
        public Mail1 mail { get; set; }
        public Licencepic licencePic { get; set; }
        public Usertype userType { get; set; }
    }

    public class Username1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Phone1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mail1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Licencepic
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usertype
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userqueryreq
    {
        public string type { get; set; }
        public Struct2 _struct { get; set; }
    }

    public class Struct2
    {
        public Id id { get; set; }
        public Username2 username { get; set; }
        public Password2 password { get; set; }
        public Phone2 phone { get; set; }
        public Mail2 mail { get; set; }
        public Usertype1 userType { get; set; }
        public Registertimestart registerTimeStart { get; set; }
        public Registertimeend registerTimeEnd { get; set; }
        public Userstate userState { get; set; }
        public Roleid roleId { get; set; }
    }

    public class Id
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Username2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Phone2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mail2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usertype1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Registertimestart
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Registertimeend
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userstate
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Roleid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Batchreq
    {
        public string type { get; set; }
        public Struct3 _struct { get; set; }
    }

    public class Struct3
    {
        public Reqlist reqList { get; set; }
    }

    public class Reqlist
    {
        public string type { get; set; }
        public Struct4 _struct { get; set; }
    }

    public class Struct4
    {
        public Userstatereq userStateReq { get; set; }
    }

    public class Userstatereq
    {
        public string type { get; set; }
        public Struct5 _struct { get; set; }
    }

    public class Struct5
    {
        public Userid userId { get; set; }
        public Userstate1 userState { get; set; }
    }

    public class Userid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userstate1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Admincreatereq
    {
        public string type { get; set; }
        public Struct6 _struct { get; set; }
    }

    public class Struct6
    {
        public Username3 username { get; set; }
        public Password3 password { get; set; }
        public Phone3 phone { get; set; }
        public Roleid1 roleId { get; set; }
    }

    public class Username3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Phone3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Roleid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Roleid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rolemenureq
    {
        public string type { get; set; }
        public Struct7 _struct { get; set; }
    }

    public class Struct7
    {
        public Roleid3 roleId { get; set; }
        public Menulist menuList { get; set; }
    }

    public class Roleid3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menulist
    {
        public string type { get; set; }
        public Struct8 _struct { get; set; }
    }

    public class Struct8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rolepermissionreq
    {
        public string type { get; set; }
        public Struct9 _struct { get; set; }
    }

    public class Struct9
    {
        public Roleid4 roleId { get; set; }
        public Permissionidlist permissionIdList { get; set; }
    }

    public class Roleid4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permissionidlist
    {
        public string type { get; set; }
        public Struct10 _struct { get; set; }
    }

    public class Struct10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodinsertreq
    {
        public string type { get; set; }
        public Struct11 _struct { get; set; }
    }

    public class Struct11
    {
        public Id1 id { get; set; }
        public Prodname prodName { get; set; }
        public Marketprice marketPrice { get; set; }
        public Shopprice shopPrice { get; set; }
        public Stock stock { get; set; }
        public Sales sales { get; set; }
        public Weight weight { get; set; }
        public Topcateentityid topCateEntityID { get; set; }
        public Subcategentityid subCategEntityID { get; set; }
        public Brandentityid brandEntityID { get; set; }
        public Prodstate prodState { get; set; }
        public Content content { get; set; }
        public Companyentityid companyEntityID { get; set; }
    }

    public class Id1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodname
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Marketprice
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Shopprice
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Stock
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sales
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Weight
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Topcateentityid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Subcategentityid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brandentityid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodstate
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Content
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Companyentityid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodqueryreq
    {
        public string type { get; set; }
        public Struct12 _struct { get; set; }
    }

    public class Struct12
    {
        public Id2 id { get; set; }
        public Prodname1 prodName { get; set; }
        public Shoppricestart shopPriceStart { get; set; }
        public Shoppriceend shopPriceEnd { get; set; }
        public Topcategoryid topCategoryId { get; set; }
        public Subcategoryid subCategoryId { get; set; }
        public Brandid brandId { get; set; }
        public Prodstatecode prodStateCode { get; set; }
        public Companyid companyId { get; set; }
        public Orderbyprice orderByPrice { get; set; }
        public Orderbysales orderBySales { get; set; }
    }

    public class Id2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodname1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Shoppricestart
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Shoppriceend
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Topcategoryid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Subcategoryid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brandid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodstatecode
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Companyid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderbyprice
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderbysales
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Categoryentity
    {
        public string type { get; set; }
        public Struct13 _struct { get; set; }
    }

    public class Struct13
    {
        public Id3 id { get; set; }
        public Category category { get; set; }
        public Parentid parentId { get; set; }
        public Sort sort { get; set; }
    }

    public class Id3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Category
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Categoryid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Categoryqueryreq
    {
        public string type { get; set; }
        public Struct14 _struct { get; set; }
    }

    public class Struct14
    {
        public Id4 id { get; set; }
        public Categoryname categoryName { get; set; }
        public Parentid1 parentId { get; set; }
    }

    public class Id4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Categoryname
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brandinsertreq
    {
        public string type { get; set; }
        public Struct15 _struct { get; set; }
    }

    public class Struct15
    {
        public Id5 id { get; set; }
        public Brand brand { get; set; }
        public Brandlogourl brandLogoUrl { get; set; }
        public Companyentityid1 companyEntityId { get; set; }
        public Sort1 sort { get; set; }
    }

    public class Id5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brand
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brandlogourl
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Companyentityid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brandqueryreq
    {
        public string type { get; set; }
        public Struct16 _struct { get; set; }
    }

    public class Struct16
    {
        public Id6 id { get; set; }
        public Brand1 brand { get; set; }
        public Companyentityid2 companyEntityId { get; set; }
    }

    public class Id6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brand1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Companyentityid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderqueryreq
    {
        public string type { get; set; }
        public Struct17 _struct { get; set; }
    }

    public class Struct17
    {
        public Id7 id { get; set; }
        public Buyerid buyerId { get; set; }
        public Buyername buyerName { get; set; }
        public Buyerphone buyerPhone { get; set; }
        public Buyermail buyerMail { get; set; }
        public Sellerid sellerId { get; set; }
        public Sellercompanyname sellerCompanyName { get; set; }
        public Sellerphone sellerPhone { get; set; }
        public Sellermail sellerMail { get; set; }
        public Orderstatecode orderStateCode { get; set; }
        public Placeorderstarttime placeOrderStartTime { get; set; }
        public Placeorderendtime placeOrderEndTime { get; set; }
        public Recipientname recipientName { get; set; }
        public Recipientphone recipientPhone { get; set; }
        public Recipientlocation recipientLocation { get; set; }
        public Paymodecode payModeCode { get; set; }
        public Expressno expressNo { get; set; }
    }

    public class Id7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Buyerid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Buyername
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Buyerphone
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Buyermail
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sellerid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sellercompanyname
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sellerphone
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sellermail
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderstatecode
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Placeorderstarttime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Placeorderendtime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Recipientname
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Recipientphone
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Recipientlocation
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Paymodecode
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Expressno
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Buyerid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sellerid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderinsertreq
    {
        public string type { get; set; }
        public Struct18 _struct { get; set; }
    }

    public class Struct18
    {
        public Userid1 userId { get; set; }
        public Prodidcountmap prodIdCountMap { get; set; }
        public Prodentitycountmap prodEntityCountMap { get; set; }
        public Paymodecode1 payModeCode { get; set; }
        public Receiptid receiptId { get; set; }
        public Locationid locationId { get; set; }
        public Remark remark { get; set; }
    }

    public class Userid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodidcountmap
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodentitycountmap
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Paymodecode1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Receiptid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Locationid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Remark
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Expressno1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Keys
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Pattern
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Key
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Value
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Expiretime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Map
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodinsertreq1
    {
        public string type { get; set; }
        public Struct19 _struct { get; set; }
    }

    public class Struct19
    {
        public Id8 id { get; set; }
        public Prodname2 prodName { get; set; }
        public Marketprice1 marketPrice { get; set; }
        public Stock1 stock { get; set; }
        public Sales1 sales { get; set; }
        public Weight1 weight { get; set; }
        public Topcateentityid1 topCateEntityID { get; set; }
        public Subcategentityid1 subCategEntityID { get; set; }
        public Brandentityid1 brandEntityID { get; set; }
        public Prodstate1 prodState { get; set; }
        public Content1 content { get; set; }
        public Companyentityid3 companyEntityID { get; set; }
    }

    public class Id8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodname2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Marketprice1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Stock1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sales1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Weight1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Topcateentityid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Subcategentityid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brandentityid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodstate1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Content1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Companyentityid3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Produpdatereq
    {
        public string type { get; set; }
        public Struct20 _struct { get; set; }
    }

    public class Struct20
    {
        public Id9 id { get; set; }
        public Prodname3 prodName { get; set; }
        public Marketprice2 marketPrice { get; set; }
        public Stock2 stock { get; set; }
        public Sales2 sales { get; set; }
        public Weight2 weight { get; set; }
        public Topcateentityid2 topCateEntityID { get; set; }
        public Subcategentityid2 subCategEntityID { get; set; }
        public Brandentityid2 brandEntityID { get; set; }
        public Prodstate2 prodState { get; set; }
        public Content2 content { get; set; }
        public Companyentityid4 companyEntityID { get; set; }
    }

    public class Id9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodname3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Marketprice2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Stock2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sales2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Weight2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Topcateentityid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Subcategentityid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brandentityid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodstate2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Content2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Companyentityid4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodqueryreq1
    {
        public string type { get; set; }
        public Struct21 _struct { get; set; }
    }

    public class Struct21
    {
        public Id10 id { get; set; }
        public Prodname4 prodName { get; set; }
        public Shoppricestart1 shopPriceStart { get; set; }
        public Shoppriceend1 shopPriceEnd { get; set; }
        public Topcategoryid1 topCategoryId { get; set; }
        public Subcategoryid1 subCategoryId { get; set; }
        public Brandid1 brandId { get; set; }
        public Prodstatecode1 prodStateCode { get; set; }
        public Companyid1 companyId { get; set; }
        public Orderbyprice1 orderByPrice { get; set; }
        public Orderbysales1 orderBySales { get; set; }
        public Page page { get; set; }
        public Numperpage numPerPage { get; set; }
        public Currentpage currentPage { get; set; }
    }

    public class Id10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodname4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Shoppricestart1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Shoppriceend1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Topcategoryid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Subcategoryid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brandid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodstatecode1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Companyid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderbyprice1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderbysales1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Page
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Numperpage
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Currentpage
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Categoryentity1
    {
        public string type { get; set; }
        public Struct22 _struct { get; set; }
    }

    public class Struct22
    {
        public Id11 id { get; set; }
        public Category1 category { get; set; }
        public Parentid2 parentId { get; set; }
        public Sort2 sort { get; set; }
    }

    public class Id11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Category1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brandinsertreq1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Categoryqueryreq1
    {
        public string type { get; set; }
        public Struct23 _struct { get; set; }
    }

    public class Struct23
    {
        public Id12 id { get; set; }
        public Categoryname1 categoryName { get; set; }
        public Parentid3 parentId { get; set; }
    }

    public class Id12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Categoryname1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brandqueryreq1
    {
        public string type { get; set; }
        public Struct24 _struct { get; set; }
    }

    public class Struct24
    {
        public Id13 id { get; set; }
        public Brand2 brand { get; set; }
        public Companyentityid5 companyEntityID { get; set; }
    }

    public class Id13
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brand2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Companyentityid5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userqueryreq1
    {
        public string type { get; set; }
        public Struct25 _struct { get; set; }
    }

    public class Struct25
    {
        public Id14 id { get; set; }
        public Username4 username { get; set; }
        public Password4 password { get; set; }
        public Phone4 phone { get; set; }
        public Mail3 mail { get; set; }
        public Registertimestart1 registerTimeStart { get; set; }
        public Registertimeend1 registerTimeEnd { get; set; }
        public Usertype2 userType { get; set; }
        public Userstate2 userState { get; set; }
        public Roleid5 roleId { get; set; }
        public Orderbyregistertime orderByRegisterTime { get; set; }
    }

    public class Id14
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Username4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Phone4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mail3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Registertimestart1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Registertimeend1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usertype2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userstate2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Roleid5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderbyregistertime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Registerreq1
    {
        public string type { get; set; }
        public Struct26 _struct { get; set; }
    }

    public class Struct26
    {
        public Username5 username { get; set; }
        public Password5 password { get; set; }
        public Phone5 phone { get; set; }
        public Mail4 mail { get; set; }
        public Licencepic1 licencePic { get; set; }
        public Usertype3 userType { get; set; }
    }

    public class Username5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Phone5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mail4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Licencepic1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usertype3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userstatereqs
    {
        public string type { get; set; }
        public Struct27 _struct { get; set; }
    }

    public class Struct27
    {
        public Userid3 userId { get; set; }
        public Userstate3 userState { get; set; }
    }

    public class Userid3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userstate3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Admincreatereq1
    {
        public string type { get; set; }
        public Struct28 _struct { get; set; }
    }

    public class Struct28
    {
        public Username6 username { get; set; }
        public Password6 password { get; set; }
        public Phone6 phone { get; set; }
        public Roleid6 roleId { get; set; }
    }

    public class Username6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Phone6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Roleid6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rolemenureq1
    {
        public string type { get; set; }
        public Struct29 _struct { get; set; }
    }

    public class Struct29
    {
        public Roleid7 roleId { get; set; }
        public Menuidlist menuIdList { get; set; }
    }

    public class Roleid7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menuidlist
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Rolepermissionreq1
    {
        public string type { get; set; }
        public Struct30 _struct { get; set; }
    }

    public class Struct30
    {
        public Roleid8 roleId { get; set; }
        public Permissionidlist1 permissionIdList { get; set; }
    }

    public class Roleid8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permissionidlist1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Outputparamstruct
    {
        public Result Result { get; set; }
        public Issuccess1 isSuccess { get; set; }
        public Errorcode1 errorCode { get; set; }
        public Message1 message { get; set; }
        public Data1 data { get; set; }
        public string type { get; set; }
        public Struct75 _struct { get; set; }
        public string name { get; set; }
        public Userentity UserEntity { get; set; }
    }

    public class Result
    {
        public string type { get; set; }
        public Struct31 _struct { get; set; }
    }

    public class Struct31
    {
        public Issuccess isSuccess { get; set; }
        public Errorcode errorCode { get; set; }
        public Message message { get; set; }
        public Data data { get; set; }
    }

    public class Issuccess
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Errorcode
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
        public string name { get; set; }
        public Struct32 _struct { get; set; }
    }

    public class Struct32
    {
        public Id15 id { get; set; }
        public Username7 username { get; set; }
        public Password7 password { get; set; }
        public Phone7 phone { get; set; }
        public Mail5 mail { get; set; }
        public Licencepic2 licencePic { get; set; }
        public Registertime registerTime { get; set; }
        public Usertypeenum userTypeEnum { get; set; }
        public Userstateenum userStateEnum { get; set; }
        public Roleentity roleEntity { get; set; }
        public Permissionentity1 PermissionEntity { get; set; }
        public Menuentity1 MenuEntity { get; set; }
        public Imageurl imageURL { get; set; }
        public Productid productId { get; set; }
        public Prodname5 prodName { get; set; }
        public Marketprice3 marketPrice { get; set; }
        public Shopprice1 shopPrice { get; set; }
        public Stock3 stock { get; set; }
        public Sales3 sales { get; set; }
        public Weight3 weight { get; set; }
        public Topcateentity topCateEntity { get; set; }
        public Subcategentity subCategEntity { get; set; }
        public Brandentity brandEntity { get; set; }
        public Prodstateenum prodStateEnum { get; set; }
        public Prodimageentitylist prodImageEntityList { get; set; }
        public Content3 content { get; set; }
        public Companyentity1 companyEntity { get; set; }
    }

    public class Id15
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Username7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Phone7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mail5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Licencepic2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Registertime
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usertypeenum
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userstateenum
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Roleentity
    {
        public string type { get; set; }
        public Struct33 _struct { get; set; }
    }

    public class Struct33
    {
        public Id16 id { get; set; }
        public Name name { get; set; }
        public Desc desc { get; set; }
        public Menulist1 menuList { get; set; }
        public Permissionlist permissionList { get; set; }
    }

    public class Id16
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menulist1
    {
        public string type { get; set; }
        public Struct34 _struct { get; set; }
    }

    public class Struct34
    {
        public Id17 id { get; set; }
        public Menuname menuName { get; set; }
        public Url url { get; set; }
        public Parentid4 parentId { get; set; }
        public Menuentity MenuEntity { get; set; }
    }

    public class Id17
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menuname
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menuentity
    {
        public string type { get; set; }
        public Struct35 _struct { get; set; }
    }

    public class Struct35
    {
        public Id18 id { get; set; }
        public Menuname1 menuName { get; set; }
        public Url1 url { get; set; }
        public Parentid5 parentId { get; set; }
    }

    public class Id18
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menuname1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permissionlist
    {
        public string type { get; set; }
        public Struct36 _struct { get; set; }
    }

    public class Struct36
    {
        public Id19 id { get; set; }
        public Permission permission { get; set; }
        public Desc1 desc { get; set; }
        public Permissionentity PermissionEntity { get; set; }
    }

    public class Id19
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permission
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permissionentity
    {
        public string type { get; set; }
        public Struct37 _struct { get; set; }
    }

    public class Struct37
    {
        public Id20 id { get; set; }
        public Permission1 permission { get; set; }
        public Desc2 desc { get; set; }
    }

    public class Id20
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permission1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permissionentity1
    {
        public string type { get; set; }
        public Struct38 _struct { get; set; }
    }

    public class Struct38
    {
        public Id21 id { get; set; }
        public Permission2 permission { get; set; }
        public Desc3 desc { get; set; }
    }

    public class Id21
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permission2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menuentity1
    {
        public string type { get; set; }
        public Struct39 _struct { get; set; }
    }

    public class Struct39
    {
        public Id22 id { get; set; }
        public Menuname2 menuName { get; set; }
        public Url2 url { get; set; }
        public Parentid6 parentId { get; set; }
    }

    public class Id22
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menuname2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Imageurl
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Productid
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodname5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Marketprice3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Shopprice1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Stock3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sales3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Weight3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Topcateentity
    {
        public string type { get; set; }
        public Struct40 _struct { get; set; }
    }

    public class Struct40
    {
        public Id23 id { get; set; }
        public Category2 category { get; set; }
        public Parentid7 parentId { get; set; }
        public Sort3 sort { get; set; }
    }

    public class Id23
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Category2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Subcategentity
    {
        public string type { get; set; }
        public Struct41 _struct { get; set; }
    }

    public class Struct41
    {
        public Id24 id { get; set; }
        public Category3 category { get; set; }
        public Parentid8 parentId { get; set; }
        public Sort4 sort { get; set; }
    }

    public class Id24
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Category3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brandentity
    {
        public string type { get; set; }
        public Struct42 _struct { get; set; }
    }

    public class Struct42
    {
        public Id25 id { get; set; }
        public Brand3 brand { get; set; }
        public Brandlogourl1 brandLogoUrl { get; set; }
        public Companyentity companyEntity { get; set; }
        public Sort5 sort { get; set; }
    }

    public class Id25
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brand3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brandlogourl1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Companyentity
    {
        public string type { get; set; }
        public Struct43 _struct { get; set; }
    }

    public class Struct43
    {
        public Id26 id { get; set; }
        public Username8 username { get; set; }
        public Password8 password { get; set; }
        public Phone8 phone { get; set; }
        public Mail6 mail { get; set; }
        public Licencepic3 licencePic { get; set; }
        public Registertime1 registerTime { get; set; }
        public Usertypeenum1 userTypeEnum { get; set; }
        public Userstateenum1 userStateEnum { get; set; }
        public Roleentity1 roleEntity { get; set; }
    }

    public class Id26
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Username8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Phone8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mail6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Licencepic3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Registertime1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usertypeenum1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userstateenum1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Roleentity1
    {
        public string tpye { get; set; }
        public Struct44 _struct { get; set; }
    }

    public class Struct44
    {
        public Id27 id { get; set; }
        public Name1 name { get; set; }
        public Desc4 desc { get; set; }
        public Menulist2 menuList { get; set; }
        public Permissionlist1 permissionList { get; set; }
    }

    public class Id27
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menulist2
    {
        public string type { get; set; }
        public Struct45 _struct { get; set; }
    }

    public class Struct45
    {
        public Id28 id { get; set; }
        public Menuname3 menuName { get; set; }
        public Url3 url { get; set; }
        public Parentid9 parentId { get; set; }
    }

    public class Id28
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menuname3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permissionlist1
    {
        public string type { get; set; }
        public Struct46 _struct { get; set; }
    }

    public class Struct46
    {
        public Id29 id { get; set; }
        public Permission3 permission { get; set; }
        public Desc5 desc { get; set; }
    }

    public class Id29
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permission3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodstateenum
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodimageentitylist
    {
        public string type { get; set; }
        public Struct47 _struct { get; set; }
    }

    public class Struct47
    {
        public Id30 id { get; set; }
        public Imageurl1 imageURL { get; set; }
        public Productid1 productId { get; set; }
    }

    public class Id30
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Imageurl1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Productid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Content3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Companyentity1
    {
        public string type { get; set; }
        public Struct48 _struct { get; set; }
    }

    public class Struct48
    {
        public Id31 id { get; set; }
        public Username9 username { get; set; }
        public Password9 password { get; set; }
        public Phone9 phone { get; set; }
        public Mail7 mail { get; set; }
        public Licencepic4 licencePic { get; set; }
        public Registertime2 registerTime { get; set; }
        public Usertypeenum2 userTypeEnum { get; set; }
        public Userstateenum2 userStateEnum { get; set; }
        public Roleentity2 roleEntity { get; set; }
    }

    public class Id31
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Username9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Phone9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mail7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Licencepic4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Registertime2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usertypeenum2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userstateenum2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Roleentity2
    {
        public string type { get; set; }
        public Struct49 _struct { get; set; }
    }

    public class Struct49
    {
        public Id32 id { get; set; }
        public Name2 name { get; set; }
        public Desc6 desc { get; set; }
        public Menulist3 menuList { get; set; }
        public Permissionlist2 permissionList { get; set; }
    }

    public class Id32
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menulist3
    {
        public string type { get; set; }
        public Struct50 _struct { get; set; }
    }

    public class Struct50
    {
        public Id33 id { get; set; }
        public Menuname4 menuName { get; set; }
        public Url4 url { get; set; }
        public Parentid10 parentId { get; set; }
    }

    public class Id33
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menuname4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permissionlist2
    {
        public string type { get; set; }
        public Struct51 _struct { get; set; }
    }

    public class Struct51
    {
        public Id34 id { get; set; }
        public Permission4 permission { get; set; }
        public Desc7 desc { get; set; }
    }

    public class Id34
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permission4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Issuccess1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Errorcode1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Message1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Data1
    {
        public string type { get; set; }
        public Struct52 _struct { get; set; }
        public string name { get; set; }
    }

    public class Struct52
    {
        public Id35 id { get; set; }
        public Category4 category { get; set; }
        public Parentid11 parentId { get; set; }
        public Sort6 sort { get; set; }
        public Brand4 brand { get; set; }
        public Brandlogourl2 brandLogoUrl { get; set; }
        public Companyentity2 companyEntity { get; set; }
        public Buyer buyer { get; set; }
        public Company company { get; set; }
        public Productorderlist productOrderList { get; set; }
        public Orderstateenum orderStateEnum { get; set; }
        public Orderstatetimelist orderStateTimeList { get; set; }
        public Paymodeenum payModeEnum { get; set; }
        public Totalprice totalPrice { get; set; }
        public Receiptentity receiptEntity { get; set; }
        public Locationentity locationEntity { get; set; }
        public Remark1 remark { get; set; }
        public Expressno2 expressNo { get; set; }
    }

    public class Id35
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Category4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brand4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brandlogourl2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Companyentity2
    {
        public string type { get; set; }
        public Struct53 _struct { get; set; }
    }

    public class Struct53
    {
        public Id36 id { get; set; }
        public Username10 username { get; set; }
        public Password10 password { get; set; }
        public Phone10 phone { get; set; }
        public Mail8 mail { get; set; }
        public Licencepic5 licencePic { get; set; }
        public Registertime3 registerTime { get; set; }
        public Usertypeenum3 userTypeEnum { get; set; }
        public Userstateenum3 userStateEnum { get; set; }
        public Roleentity3 roleEntity { get; set; }
    }

    public class Id36
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Username10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Phone10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mail8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Licencepic5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Registertime3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usertypeenum3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userstateenum3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Roleentity3
    {
        public string type { get; set; }
        public Struct54 _struct { get; set; }
    }

    public class Struct54
    {
        public Id37 id { get; set; }
        public Name3 name { get; set; }
        public Desc8 desc { get; set; }
        public Menulist4 menuList { get; set; }
        public Permissionlist3 permissionList { get; set; }
    }

    public class Id37
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menulist4
    {
        public string type { get; set; }
        public Struct55 _struct { get; set; }
    }

    public class Struct55
    {
        public Id38 id { get; set; }
        public Menuname5 menuName { get; set; }
        public Url5 url { get; set; }
        public Parentid12 parentId { get; set; }
    }

    public class Id38
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menuname5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permissionlist3
    {
        public string type { get; set; }
        public Struct56 _struct { get; set; }
    }

    public class Struct56
    {
        public Id39 id { get; set; }
        public Permission5 permission { get; set; }
        public Desc9 desc { get; set; }
    }

    public class Id39
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permission5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Buyer
    {
        public string type { get; set; }
        public Struct57 _struct { get; set; }
    }

    public class Struct57
    {
        public Id40 id { get; set; }
        public Username11 username { get; set; }
        public Password11 password { get; set; }
        public Phone11 phone { get; set; }
        public Mail9 mail { get; set; }
        public Licencepic11 licencePic1 { get; set; }
        public Licencepic21 licencePic2 { get; set; }
    }

    public class Id40
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Username11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Phone11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mail9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Licencepic11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Licencepic21
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Company
    {
        public string type { get; set; }
        public Struct58 _struct { get; set; }
    }

    public class Struct58
    {
        public Id41 id { get; set; }
        public Username12 username { get; set; }
        public Password12 password { get; set; }
        public Phone12 phone { get; set; }
        public Mail10 mail { get; set; }
        public Licencepic12 licencePic1 { get; set; }
        public Licencepic22 licencePic2 { get; set; }
    }

    public class Id41
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Username12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Phone12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mail10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Licencepic12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Licencepic22
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Productorderlist
    {
        public string type { get; set; }
        public Struct59 _struct { get; set; }
    }

    public class Struct59
    {
        public Orderid1 orderId { get; set; }
        public Productentity productEntity { get; set; }
        public Count count { get; set; }
    }

    public class Orderid1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Productentity
    {
        public Struct60 _struct { get; set; }
    }

    public class Struct60
    {
        public Id42 id { get; set; }
        public Prodname6 prodName { get; set; }
        public Marketprice4 marketPrice { get; set; }
        public Shopprice2 shopPrice { get; set; }
        public Stock4 stock { get; set; }
        public Sales4 sales { get; set; }
        public Weight4 weight { get; set; }
        public Topcateentity1 topCateEntity { get; set; }
        public Subcategentity1 subCategEntity { get; set; }
        public Brandentity1 brandEntity { get; set; }
        public Prodstateenum1 prodStateEnum { get; set; }
        public Prodimageentitylist1 prodImageEntityList { get; set; }
        public Content4 content { get; set; }
        public Companyentity4 companyEntity { get; set; }
    }

    public class Id42
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodname6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Marketprice4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Shopprice2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Stock4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sales4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Weight4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Topcateentity1
    {
        public string type { get; set; }
        public Struct61 _struct { get; set; }
    }

    public class Struct61
    {
        public Id43 id { get; set; }
        public Category5 category { get; set; }
        public Parentid13 parentId { get; set; }
        public Sort7 sort { get; set; }
    }

    public class Id43
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Category5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid13
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Subcategentity1
    {
        public string type { get; set; }
        public Struct62 _struct { get; set; }
    }

    public class Struct62
    {
        public Id44 id { get; set; }
        public Category6 category { get; set; }
        public Parentid14 parentId { get; set; }
        public Sort8 sort { get; set; }
    }

    public class Id44
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Category6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid14
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brandentity1
    {
        public Id45 id { get; set; }
        public Brand5 brand { get; set; }
        public Brandlogourl3 brandLogoUrl { get; set; }
        public Companyentity3 companyEntity { get; set; }
        public Sort9 sort { get; set; }
    }

    public class Id45
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brand5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brandlogourl3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Companyentity3
    {
        public string type { get; set; }
        public Struct63 _struct { get; set; }
    }

    public class Struct63
    {
        public Id46 id { get; set; }
        public Username13 username { get; set; }
        public Password13 password { get; set; }
        public Phone13 phone { get; set; }
        public Mail11 mail { get; set; }
        public Licencepic6 licencePic { get; set; }
        public Registertime4 registerTime { get; set; }
        public Usertypeenum4 userTypeEnum { get; set; }
        public Userstateenum4 userStateEnum { get; set; }
        public Roleentity4 roleEntity { get; set; }
    }

    public class Id46
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Username13
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password13
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Phone13
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mail11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Licencepic6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Registertime4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usertypeenum4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userstateenum4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Roleentity4
    {
        public string type { get; set; }
        public Struct64 _struct { get; set; }
    }

    public class Struct64
    {
        public Id47 id { get; set; }
        public Name4 name { get; set; }
        public Desc10 desc { get; set; }
        public Menulist5 menuList { get; set; }
        public Permissionlist4 permissionList { get; set; }
    }

    public class Id47
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menulist5
    {
        public string type { get; set; }
        public Struct65 _struct { get; set; }
    }

    public class Struct65
    {
        public Id48 id { get; set; }
        public Menuname6 menuName { get; set; }
        public Url6 url { get; set; }
        public Parentid15 parentId { get; set; }
    }

    public class Id48
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menuname6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid15
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permissionlist4
    {
        public Struct66 _struct { get; set; }
    }

    public class Struct66
    {
        public Id49 id { get; set; }
        public Permission6 permission { get; set; }
        public Desc11 desc { get; set; }
    }

    public class Id49
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permission6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodstateenum1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodimageentitylist1
    {
        public string type { get; set; }
        public Struct67 _struct { get; set; }
    }

    public class Struct67
    {
        public Id50 id { get; set; }
        public Imageurl2 imageURL { get; set; }
        public Productid2 productId { get; set; }
    }

    public class Id50
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Imageurl2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Productid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Content4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Companyentity4
    {
        public string type { get; set; }
        public Struct68 _struct { get; set; }
    }

    public class Struct68
    {
        public Id51 id { get; set; }
        public Username14 username { get; set; }
        public Phone14 phone { get; set; }
        public Mail12 mail { get; set; }
        public Licencepic7 licencePic { get; set; }
        public Registertime5 registerTime { get; set; }
        public Usertypeenum5 userTypeEnum { get; set; }
        public Userstateenum5 userStateEnum { get; set; }
        public Roleentity5 roleEntity { get; set; }
    }

    public class Id51
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Username14
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Phone14
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mail12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Licencepic7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Registertime5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usertypeenum5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userstateenum5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Roleentity5
    {
        public string type { get; set; }
        public Struct69 _struct { get; set; }
    }

    public class Struct69
    {
        public Id52 id { get; set; }
        public Name5 name { get; set; }
        public Desc12 desc { get; set; }
        public Menulist6 menuList { get; set; }
        public Permissionlist5 permissionList { get; set; }
    }

    public class Id52
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menulist6
    {
        public string type { get; set; }
        public Struct70 _struct { get; set; }
    }

    public class Struct70
    {
        public Id53 id { get; set; }
        public Menuname7 menuName { get; set; }
        public Url7 url { get; set; }
        public Parentid16 parentId { get; set; }
    }

    public class Id53
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menuname7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid16
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permissionlist5
    {
        public string type { get; set; }
        public Struct71 _struct { get; set; }
    }

    public class Struct71
    {
        public Id54 id { get; set; }
        public Permission7 permission { get; set; }
        public Desc13 desc { get; set; }
    }

    public class Id54
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permission7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc13
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Count
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderstateenum
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderstatetimelist
    {
        public string type { get; set; }
        public Struct72 _struct { get; set; }
    }

    public class Struct72
    {
        public Orderid2 orderId { get; set; }
        public Orderstateenum1 orderStateEnum { get; set; }
        public Time time { get; set; }
    }

    public class Orderid2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderstateenum1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Time
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Paymodeenum
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Totalprice
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Receiptentity
    {
        public string type { get; set; }
        public Struct73 _struct { get; set; }
    }

    public class Struct73
    {
        public Id55 id { get; set; }
        public Receipttypeenum receiptTypeEnum { get; set; }
        public Title title { get; set; }
        public Taxpayerno taxpayerNo { get; set; }
        public Content5 content { get; set; }
    }

    public class Id55
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Receipttypeenum
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Title
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Taxpayerno
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Content5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Locationentity
    {
        public string type { get; set; }
        public Struct74 _struct { get; set; }
    }

    public class Struct74
    {
        public Id56 id { get; set; }
        public Location location { get; set; }
        public Name6 name { get; set; }
        public Phone15 phone { get; set; }
        public Postcode postCode { get; set; }
    }

    public class Id56
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Location
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Phone15
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Postcode
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Remark1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Expressno2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Struct75
    {
        public Id57 id { get; set; }
        public Buyer1 buyer { get; set; }
        public Company2 company { get; set; }
        public Productorderlist1 productOrderList { get; set; }
        public Orderstateenum2 orderStateEnum { get; set; }
        public Orderstatetimelist1 orderStateTimeList { get; set; }
        public Paymodeenum1 payModeEnum { get; set; }
        public Totalprice1 totalPrice { get; set; }
        public Receiptentity1 receiptEntity { get; set; }
        public Locationentity1 locationEntity { get; set; }
        public Remark2 remark { get; set; }
        public Expressno3 expressNo { get; set; }
        public Issuccess2 isSuccess { get; set; }
        public Errorcode2 errorCode { get; set; }
        public Message2 message { get; set; }
        public Data2 data { get; set; }
        public Name11 name { get; set; }
        public Desc20 desc { get; set; }
        public Menulist10 menuList { get; set; }
        public Permissionlist9 permissionList { get; set; }
        public Permission12 permission { get; set; }
        public Menuname11 menuName { get; set; }
        public Url12 url { get; set; }
        public Parentid23 parentId { get; set; }
    }

    public class Id57
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Buyer1
    {
        public string type { get; set; }
        public Struct76 _struct { get; set; }
    }

    public class Struct76
    {
        public Id58 id { get; set; }
        public Username15 username { get; set; }
        public Password14 password { get; set; }
        public Phone16 phone { get; set; }
        public Mail13 mail { get; set; }
        public Licencepic8 licencePic { get; set; }
        public Registertime6 registerTime { get; set; }
        public Usertypeenum6 userTypeEnum { get; set; }
        public Userstateenum6 userStateEnum { get; set; }
        public Roleentity6 roleEntity { get; set; }
    }

    public class Id58
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Username15
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password14
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Phone16
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mail13
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Licencepic8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Registertime6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usertypeenum6
    {
        public string type { get; set; }
        public Set set { get; set; }
    }

    public class Set
    {
        public Person Person { get; set; }
        public Company1 Company { get; set; }
        public ADMIN ADMIN { get; set; }
    }

    public class Person
    {
        public string type { get; set; }
        public Struct77 _struct { get; set; }
    }

    public class Struct77
    {
        public Code code { get; set; }
        public Msg msg { get; set; }
    }

    public class Code
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Company1
    {
        public string type { get; set; }
        public Struct78 _struct { get; set; }
    }

    public class Struct78
    {
        public Code1 code { get; set; }
        public Msg1 msg { get; set; }
    }

    public class Code1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class ADMIN
    {
        public string type { get; set; }
        public Struct79 _struct { get; set; }
    }

    public class Struct79
    {
        public Code2 code { get; set; }
        public Msg2 msg { get; set; }
    }

    public class Code2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userstateenum6
    {
        public string type { get; set; }
        public Set1 set { get; set; }
    }

    public class Set1
    {
        public ON ON { get; set; }
        public OFF OFF { get; set; }
    }

    public class ON
    {
        public string type { get; set; }
        public Struct80 _struct { get; set; }
    }

    public class Struct80
    {
        public Code3 code { get; set; }
        public Msg3 msg { get; set; }
    }

    public class Code3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class OFF
    {
        public string type { get; set; }
        public Struct81 _struct { get; set; }
    }

    public class Struct81
    {
        public Code4 code { get; set; }
        public Msg4 msg { get; set; }
    }

    public class Code4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Roleentity6
    {
        public string type { get; set; }
        public Struct82 _struct { get; set; }
    }

    public class Struct82
    {
        public Id59 id { get; set; }
        public Name7 name { get; set; }
        public Desc14 desc { get; set; }
        public Menulist7 menuList { get; set; }
        public Permissionlist6 permissionList { get; set; }
    }

    public class Id59
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc14
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menulist7
    {
        public string type { get; set; }
        public Struct83 _struct { get; set; }
    }

    public class Struct83
    {
        public Id60 id { get; set; }
        public Menuname8 menuName { get; set; }
        public Url8 url { get; set; }
        public Parentid17 parentId { get; set; }
    }

    public class Id60
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menuname8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid17
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permissionlist6
    {
        public string type { get; set; }
        public Struct84 _struct { get; set; }
    }

    public class Struct84
    {
        public Id61 id { get; set; }
        public Permission8 permission { get; set; }
        public Desc15 desc { get; set; }
    }

    public class Id61
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permission8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc15
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Company2
    {
        public string type { get; set; }
        public Struct85 _struct { get; set; }
    }

    public class Struct85
    {
        public Id62 id { get; set; }
        public Username16 username { get; set; }
        public Password15 password { get; set; }
        public Phone17 phone { get; set; }
        public Mail14 mail { get; set; }
        public Licencepic9 licencePic { get; set; }
        public Registertime7 registerTime { get; set; }
        public Usertypeenum7 userTypeEnum { get; set; }
        public Userstateenum7 userStateEnum { get; set; }
        public Roleentity7 roleEntity { get; set; }
    }

    public class Id62
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Username16
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password15
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Phone17
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mail14
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Licencepic9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Registertime7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usertypeenum7
    {
        public string type { get; set; }
        public Set2 set { get; set; }
    }

    public class Set2
    {
        public Person1 Person { get; set; }
        public Company3 Company { get; set; }
        public ADMIN1 ADMIN { get; set; }
    }

    public class Person1
    {
        public string type { get; set; }
        public Struct86 _struct { get; set; }
    }

    public class Struct86
    {
        public Code5 code { get; set; }
        public Msg5 msg { get; set; }
    }

    public class Code5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Company3
    {
        public string type { get; set; }
        public Struct87 _struct { get; set; }
    }

    public class Struct87
    {
        public Code6 code { get; set; }
        public Msg6 msg { get; set; }
    }

    public class Code6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class ADMIN1
    {
        public string type { get; set; }
        public Struct88 _struct { get; set; }
    }

    public class Struct88
    {
        public Code7 code { get; set; }
        public Msg7 msg { get; set; }
    }

    public class Code7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userstateenum7
    {
        public string type { get; set; }
        public Set3 set { get; set; }
    }

    public class Set3
    {
        public ON1 ON { get; set; }
        public OFF1 OFF { get; set; }
    }

    public class ON1
    {
        public string type { get; set; }
        public Struct89 _struct { get; set; }
    }

    public class Struct89
    {
        public Code8 code { get; set; }
        public Msg8 msg { get; set; }
    }

    public class Code8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class OFF1
    {
        public string type { get; set; }
        public Struct90 _struct { get; set; }
    }

    public class Struct90
    {
        public Code9 code { get; set; }
        public Msg9 msg { get; set; }
    }

    public class Code9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Roleentity7
    {
        public string type { get; set; }
        public Struct91 _struct { get; set; }
    }

    public class Struct91
    {
        public Id63 id { get; set; }
        public Name8 name { get; set; }
        public Desc16 desc { get; set; }
        public Menulist8 menuList { get; set; }
        public Permissionlist7 permissionList { get; set; }
    }

    public class Id63
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc16
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menulist8
    {
        public string type { get; set; }
        public Struct92 _struct { get; set; }
    }

    public class Struct92
    {
        public Id64 id { get; set; }
        public Menuname9 menuName { get; set; }
        public Url9 url { get; set; }
        public Parentid18 parentId { get; set; }
    }

    public class Id64
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menuname9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid18
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permissionlist7
    {
        public string type { get; set; }
        public Struct93 _struct { get; set; }
    }

    public class Struct93
    {
        public Id65 id { get; set; }
        public Permission9 permission { get; set; }
        public Desc17 desc { get; set; }
    }

    public class Id65
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permission9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc17
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Productorderlist1
    {
        public string type { get; set; }
        public Struct94 _struct { get; set; }
    }

    public class Struct94
    {
        public Orderid3 orderId { get; set; }
        public Productentity1 productEntity { get; set; }
        public Count1 count { get; set; }
    }

    public class Orderid3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Productentity1
    {
        public string type { get; set; }
        public Struct95 _struct { get; set; }
    }

    public class Struct95
    {
        public Id66 id { get; set; }
        public Prodname7 prodName { get; set; }
        public Marketprice5 marketPrice { get; set; }
        public Shopprice3 shopPrice { get; set; }
        public Stock5 stock { get; set; }
        public Sales5 sales { get; set; }
        public Weight5 weight { get; set; }
        public Topcateentity2 topCateEntity { get; set; }
        public Subcategentity2 subCategEntity { get; set; }
        public Brandentity2 brandEntity { get; set; }
        public Prodstateenum2 prodStateEnum { get; set; }
        public Prodimageentitylist2 prodImageEntityList { get; set; }
        public Content6 content { get; set; }
        public Company4 company { get; set; }
        public Companyentity6 companyEntity { get; set; }
    }

    public class Id66
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodname7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Marketprice5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Shopprice3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Stock5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sales5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Weight5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Topcateentity2
    {
        public string type { get; set; }
        public Struct96 _struct { get; set; }
    }

    public class Struct96
    {
        public Id67 id { get; set; }
        public Category7 category { get; set; }
        public Parentid19 parentId { get; set; }
        public Sort10 sort { get; set; }
    }

    public class Id67
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Category7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid19
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Subcategentity2
    {
        public string type { get; set; }
        public Struct97 _struct { get; set; }
    }

    public class Struct97
    {
        public Id68 id { get; set; }
        public Category8 category { get; set; }
        public Parentid20 parentId { get; set; }
        public Sort11 sort { get; set; }
    }

    public class Id68
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Category8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid20
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brandentity2
    {
        public string type { get; set; }
        public Struct98 _struct { get; set; }
    }

    public class Struct98
    {
        public Id69 id { get; set; }
        public Brand6 brand { get; set; }
        public Brandlogourl4 brandLogoUrl { get; set; }
        public Companyentity5 companyEntity { get; set; }
        public Sort12 sort { get; set; }
    }

    public class Id69
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brand6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Brandlogourl4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Companyentity5
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Sort12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodstateenum2
    {
        public string type { get; set; }
        public Set4 set { get; set; }
    }

    public class Set4
    {
        public OPEN OPEN { get; set; }
        public CLOSE CLOSE { get; set; }
    }

    public class OPEN
    {
        public string type { get; set; }
        public Struct99 _struct { get; set; }
    }

    public class Struct99
    {
        public Code10 code { get; set; }
        public Msg10 msg { get; set; }
    }

    public class Code10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class CLOSE
    {
        public string type { get; set; }
        public Struct100 _struct { get; set; }
    }

    public class Struct100
    {
        public Code11 code { get; set; }
        public Msg11 msg { get; set; }
    }

    public class Code11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Prodimageentitylist2
    {
        public string type { get; set; }
        public Struct101 _struct { get; set; }
    }

    public class Struct101
    {
        public Id70 id { get; set; }
        public Imageurl3 imageURL { get; set; }
        public Productid3 productId { get; set; }
    }

    public class Id70
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Imageurl3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Productid3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Content6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Company4
    {
        public string type { get; set; }
        public Struct102 _struct { get; set; }
    }

    public class Struct102
    {
        public Id71 id { get; set; }
        public Username17 username { get; set; }
        public Password16 password { get; set; }
        public Phone18 phone { get; set; }
        public Mail15 mail { get; set; }
        public Licencepic10 licencePic { get; set; }
        public Registertime8 registerTime { get; set; }
        public Usertypeenum8 userTypeEnum { get; set; }
        public Userstateenum8 userStateEnum { get; set; }
        public Roleentity8 roleEntity { get; set; }
    }

    public class Id71
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Username17
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password16
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Phone18
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mail15
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Licencepic10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Registertime8
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usertypeenum8
    {
        public string type { get; set; }
        public Set5 set { get; set; }
    }

    public class Set5
    {
        public Person2 Person { get; set; }
        public Company5 Company { get; set; }
        public ADMIN2 ADMIN { get; set; }
    }

    public class Person2
    {
        public string type { get; set; }
        public Struct103 _struct { get; set; }
    }

    public class Struct103
    {
        public Code12 code { get; set; }
        public Msg12 msg { get; set; }
    }

    public class Code12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Company5
    {
        public string type { get; set; }
        public Struct104 _struct { get; set; }
    }

    public class Struct104
    {
        public Code13 code { get; set; }
        public Msg13 msg { get; set; }
    }

    public class Code13
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg13
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class ADMIN2
    {
        public string type { get; set; }
        public Struct105 _struct { get; set; }
    }

    public class Struct105
    {
        public Code14 code { get; set; }
        public Msg14 msg { get; set; }
    }

    public class Code14
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg14
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userstateenum8
    {
        public string type { get; set; }
        public Set6 set { get; set; }
    }

    public class Set6
    {
        public ON2 ON { get; set; }
        public OFF2 OFF { get; set; }
    }

    public class ON2
    {
        public string type { get; set; }
        public Struct106 _struct { get; set; }
    }

    public class Struct106
    {
        public Code15 code { get; set; }
        public Msg15 msg { get; set; }
    }

    public class Code15
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg15
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class OFF2
    {
        public string type { get; set; }
        public Struct107 _struct { get; set; }
    }

    public class Struct107
    {
        public Code16 code { get; set; }
        public Msg16 msg { get; set; }
    }

    public class Code16
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg16
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Roleentity8
    {
        public string type { get; set; }
        public Struct108 _struct { get; set; }
    }

    public class Struct108
    {
        public Id72 id { get; set; }
        public Name9 name { get; set; }
        public Desc18 desc { get; set; }
        public Menulist9 menuList { get; set; }
        public Permissionlist8 permissionList { get; set; }
    }

    public class Id72
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc18
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menulist9
    {
        public string type { get; set; }
        public Struct109 _struct { get; set; }
    }

    public class Struct109
    {
        public Id73 id { get; set; }
        public Menuname10 menuName { get; set; }
        public Url10 url { get; set; }
        public Parentid21 parentId { get; set; }
    }

    public class Id73
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menuname10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid21
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permissionlist8
    {
        public string type { get; set; }
        public Struct110 _struct { get; set; }
    }

    public class Struct110
    {
        public Id74 id { get; set; }
        public Permission10 permission { get; set; }
        public Desc19 desc { get; set; }
    }

    public class Id74
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permission10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc19
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Companyentity6
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Count1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderstateenum2
    {
        public string type { get; set; }
        public Set7 set { get; set; }
    }

    public class Set7
    {
        public INIT INIT { get; set; }
        public BUYER_UNPAID BUYER_UNPAID { get; set; }
        public BUYER_PAID BUYER_PAID { get; set; }
        public BUYER_RECEIVING BUYER_RECEIVING { get; set; }
        public BUYER_SIGNED_UNCONFIRMED BUYER_SIGNED_UNCONFIRMED { get; set; }
        public FINISHED FINISHED { get; set; }
        public BUYER_APPLYRETURN BUYER_APPLYRETURN { get; set; }
        public SELLER_ACCEPTRETURN SELLER_ACCEPTRETURN { get; set; }
        public SELLER_REJECTRETURN_APPLICABLE SELLER_REJECTRETURN_APPLICABLE { get; set; }
        public BUYERER_APPEALING BUYERER_APPEALING { get; set; }
        public SELLER_APPEALING SELLER_APPEALING { get; set; }
        public FINISHED_APPEAL FINISHED_APPEAL { get; set; }
        public SELLER_RECEIVING SELLER_RECEIVING { get; set; }
        public SELLER_SIGNED_UNCONFIRMED SELLER_SIGNED_UNCONFIRMED { get; set; }
        public REFUNDING REFUNDING { get; set; }
        public REFUND_SUCCESS REFUND_SUCCESS { get; set; }
        public REFUND_FAIL REFUND_FAIL { get; set; }
        public FINISHED_RETURN FINISHED_RETURN { get; set; }
        public CANCEL CANCEL { get; set; }
    }

    public class INIT
    {
        public string type { get; set; }
        public Struct111 _struct { get; set; }
    }

    public class Struct111
    {
        public Code17 code { get; set; }
        public Msg17 msg { get; set; }
    }

    public class Code17
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg17
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class BUYER_UNPAID
    {
        public string type { get; set; }
        public Struct112 _struct { get; set; }
    }

    public class Struct112
    {
        public Code18 code { get; set; }
        public Msg18 msg { get; set; }
    }

    public class Code18
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg18
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class BUYER_PAID
    {
        public string type { get; set; }
        public Struct113 _struct { get; set; }
    }

    public class Struct113
    {
        public Code19 code { get; set; }
        public Msg19 msg { get; set; }
    }

    public class Code19
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg19
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class BUYER_RECEIVING
    {
        public string type { get; set; }
        public Struct114 _struct { get; set; }
    }

    public class Struct114
    {
        public Code20 code { get; set; }
        public Msg20 msg { get; set; }
    }

    public class Code20
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg20
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class BUYER_SIGNED_UNCONFIRMED
    {
        public string type { get; set; }
        public Struct115 _struct { get; set; }
    }

    public class Struct115
    {
        public Code21 code { get; set; }
        public Msg21 msg { get; set; }
    }

    public class Code21
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg21
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class FINISHED
    {
        public string type { get; set; }
        public Struct116 _struct { get; set; }
    }

    public class Struct116
    {
        public Code22 code { get; set; }
        public Msg22 msg { get; set; }
    }

    public class Code22
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg22
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class BUYER_APPLYRETURN
    {
        public string type { get; set; }
        public Struct117 _struct { get; set; }
    }

    public class Struct117
    {
        public Code23 code { get; set; }
        public Msg23 msg { get; set; }
    }

    public class Code23
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg23
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class SELLER_ACCEPTRETURN
    {
        public string type { get; set; }
        public Struct118 _struct { get; set; }
    }

    public class Struct118
    {
        public Code24 code { get; set; }
        public Msg24 msg { get; set; }
    }

    public class Code24
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg24
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class SELLER_REJECTRETURN_APPLICABLE
    {
        public string type { get; set; }
        public Struct119 _struct { get; set; }
    }

    public class Struct119
    {
        public Code25 code { get; set; }
        public Msg25 msg { get; set; }
    }

    public class Code25
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg25
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class BUYERER_APPEALING
    {
        public string type { get; set; }
        public Struct120 _struct { get; set; }
    }

    public class Struct120
    {
        public Code26 code { get; set; }
        public Msg26 msg { get; set; }
    }

    public class Code26
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg26
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class SELLER_APPEALING
    {
        public string type { get; set; }
        public Struct121 _struct { get; set; }
    }

    public class Struct121
    {
        public Code27 code { get; set; }
        public Msg27 msg { get; set; }
    }

    public class Code27
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg27
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class FINISHED_APPEAL
    {
        public string type { get; set; }
        public Struct122 _struct { get; set; }
    }

    public class Struct122
    {
        public Code28 code { get; set; }
        public Msg28 msg { get; set; }
    }

    public class Code28
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg28
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class SELLER_RECEIVING
    {
        public string type { get; set; }
        public Struct123 _struct { get; set; }
    }

    public class Struct123
    {
        public Code29 code { get; set; }
        public Msg29 msg { get; set; }
    }

    public class Code29
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg29
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class SELLER_SIGNED_UNCONFIRMED
    {
        public string type { get; set; }
        public Struct124 _struct { get; set; }
    }

    public class Struct124
    {
        public Code30 code { get; set; }
        public Msg30 msg { get; set; }
    }

    public class Code30
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg30
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class REFUNDING
    {
        public string type { get; set; }
        public Struct125 _struct { get; set; }
    }

    public class Struct125
    {
        public Code31 code { get; set; }
        public Msg31 msg { get; set; }
    }

    public class Code31
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg31
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class REFUND_SUCCESS
    {
        public string type { get; set; }
        public Struct126 _struct { get; set; }
    }

    public class Struct126
    {
        public Code32 code { get; set; }
        public Msg32 msg { get; set; }
    }

    public class Code32
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg32
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class REFUND_FAIL
    {
        public string type { get; set; }
        public Struct127 _struct { get; set; }
    }

    public class Struct127
    {
        public Code33 code { get; set; }
        public Msg33 msg { get; set; }
    }

    public class Code33
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg33
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class FINISHED_RETURN
    {
        public string type { get; set; }
        public Struct128 _struct { get; set; }
    }

    public class Struct128
    {
        public Code34 code { get; set; }
        public Msg34 msg { get; set; }
    }

    public class Code34
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg34
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class CANCEL
    {
        public string type { get; set; }
        public Struct129 _struct { get; set; }
    }

    public class Struct129
    {
        public Code35 code { get; set; }
        public Msg35 msg { get; set; }
    }

    public class Code35
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg35
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderstatetimelist1
    {
        public string type { get; set; }
        public Struct130 _struct { get; set; }
    }

    public class Struct130
    {
        public Orderid4 orderId { get; set; }
        public Orderstateenum3 orderStateEnum { get; set; }
        public Time1 time { get; set; }
    }

    public class Orderid4
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Orderstateenum3
    {
        public string type { get; set; }
        public Set8 set { get; set; }
    }

    public class Set8
    {
        public INIT1 INIT { get; set; }
        public BUYER_UNPAID1 BUYER_UNPAID { get; set; }
        public BUYER_PAID1 BUYER_PAID { get; set; }
        public BUYER_RECEIVING1 BUYER_RECEIVING { get; set; }
        public BUYER_SIGNED_UNCONFIRMED1 BUYER_SIGNED_UNCONFIRMED { get; set; }
        public FINISHED1 FINISHED { get; set; }
        public BUYER_APPLYRETURN1 BUYER_APPLYRETURN { get; set; }
        public SELLER_ACCEPTRETURN1 SELLER_ACCEPTRETURN { get; set; }
        public SELLER_REJECTRETURN_APPLICABLE1 SELLER_REJECTRETURN_APPLICABLE { get; set; }
        public BUYERER_APPEALING1 BUYERER_APPEALING { get; set; }
        public SELLER_APPEALING1 SELLER_APPEALING { get; set; }
        public FINISHED_APPEAL1 FINISHED_APPEAL { get; set; }
        public SELLER_RECEIVING1 SELLER_RECEIVING { get; set; }
        public SELLER_SIGNED_UNCONFIRMED1 SELLER_SIGNED_UNCONFIRMED { get; set; }
        public REFUNDING1 REFUNDING { get; set; }
        public REFUND_SUCCESS1 REFUND_SUCCESS { get; set; }
        public REFUND_FAIL1 REFUND_FAIL { get; set; }
        public FINISHED_RETURN1 FINISHED_RETURN { get; set; }
        public CANCEL1 CANCEL { get; set; }
    }

    public class INIT1
    {
        public string type { get; set; }
        public Struct131 _struct { get; set; }
    }

    public class Struct131
    {
        public Code36 code { get; set; }
    }

    public class Code36
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class BUYER_UNPAID1
    {
        public string type { get; set; }
        public Struct132 _struct { get; set; }
    }

    public class Struct132
    {
        public Code37 code { get; set; }
    }

    public class Code37
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class BUYER_PAID1
    {
        public string type { get; set; }
        public Struct133 _struct { get; set; }
    }

    public class Struct133
    {
        public Code38 code { get; set; }
    }

    public class Code38
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class BUYER_RECEIVING1
    {
        public string type { get; set; }
        public Struct134 _struct { get; set; }
    }

    public class Struct134
    {
        public Code39 code { get; set; }
    }

    public class Code39
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class BUYER_SIGNED_UNCONFIRMED1
    {
        public string type { get; set; }
        public Struct135 _struct { get; set; }
    }

    public class Struct135
    {
        public Code40 code { get; set; }
    }

    public class Code40
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class FINISHED1
    {
        public string type { get; set; }
        public Struct136 _struct { get; set; }
    }

    public class Struct136
    {
        public Code41 code { get; set; }
    }

    public class Code41
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class BUYER_APPLYRETURN1
    {
        public string type { get; set; }
        public Struct137 _struct { get; set; }
    }

    public class Struct137
    {
        public Code42 code { get; set; }
    }

    public class Code42
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class SELLER_ACCEPTRETURN1
    {
        public string type { get; set; }
        public Struct138 _struct { get; set; }
    }

    public class Struct138
    {
        public Code43 code { get; set; }
    }

    public class Code43
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class SELLER_REJECTRETURN_APPLICABLE1
    {
        public string type { get; set; }
        public Struct139 _struct { get; set; }
    }

    public class Struct139
    {
        public Code44 code { get; set; }
    }

    public class Code44
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class BUYERER_APPEALING1
    {
        public string type { get; set; }
        public Struct140 _struct { get; set; }
    }

    public class Struct140
    {
        public Code45 code { get; set; }
    }

    public class Code45
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class SELLER_APPEALING1
    {
        public string type { get; set; }
        public Struct141 _struct { get; set; }
    }

    public class Struct141
    {
        public Code46 code { get; set; }
    }

    public class Code46
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class FINISHED_APPEAL1
    {
        public string type { get; set; }
        public Struct142 _struct { get; set; }
    }

    public class Struct142
    {
        public Code47 code { get; set; }
    }

    public class Code47
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class SELLER_RECEIVING1
    {
        public string type { get; set; }
        public Struct143 _struct { get; set; }
    }

    public class Struct143
    {
        public Code48 code { get; set; }
    }

    public class Code48
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class SELLER_SIGNED_UNCONFIRMED1
    {
        public string type { get; set; }
        public Struct144 _struct { get; set; }
    }

    public class Struct144
    {
        public Code49 code { get; set; }
    }

    public class Code49
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class REFUNDING1
    {
        public string type { get; set; }
        public Struct145 _struct { get; set; }
    }

    public class Struct145
    {
        public Code50 code { get; set; }
    }

    public class Code50
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class REFUND_SUCCESS1
    {
        public string type { get; set; }
        public Struct146 _struct { get; set; }
    }

    public class Struct146
    {
        public Code51 code { get; set; }
    }

    public class Code51
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class REFUND_FAIL1
    {
        public string type { get; set; }
        public Struct147 _struct { get; set; }
    }

    public class Struct147
    {
        public Code52 code { get; set; }
    }

    public class Code52
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class FINISHED_RETURN1
    {
        public string type { get; set; }
        public Struct148 _struct { get; set; }
    }

    public class Struct148
    {
        public Code53 code { get; set; }
    }

    public class Code53
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class CANCEL1
    {
        public string type { get; set; }
        public Struct149 _struct { get; set; }
    }

    public class Struct149
    {
        public Code54 code { get; set; }
    }

    public class Code54
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Time1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Paymodeenum1
    {
        public string type { get; set; }
        public Set9 set { get; set; }
    }

    public class Set9
    {
        public ALPAY ALPAY { get; set; }
        public WECHAT WECHAT { get; set; }
        public UNIONPAY UNIONPAY { get; set; }
    }

    public class ALPAY
    {
        public string type { get; set; }
        public Struct150 _struct { get; set; }
    }

    public class Struct150
    {
        public Code55 code { get; set; }
        public Msg36 msg { get; set; }
    }

    public class Code55
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg36
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class WECHAT
    {
        public string type { get; set; }
        public Struct151 _struct { get; set; }
    }

    public class Struct151
    {
        public Code56 code { get; set; }
        public Msg37 msg { get; set; }
    }

    public class Code56
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg37
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class UNIONPAY
    {
        public string type { get; set; }
        public Struct152 _struct { get; set; }
    }

    public class Struct152
    {
        public Code57 code { get; set; }
        public Msg38 msg { get; set; }
    }

    public class Code57
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg38
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Totalprice1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Receiptentity1
    {
        public string type { get; set; }
        public Struct153 _struct { get; set; }
    }

    public class Struct153
    {
        public Id75 id { get; set; }
        public Receipttypeenum1 receiptTypeEnum { get; set; }
        public Tittle tittle { get; set; }
        public Taxpayerno1 taxPayerNo { get; set; }
        public Content7 content { get; set; }
    }

    public class Id75
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Receipttypeenum1
    {
        public string type { get; set; }
        public Set10 set { get; set; }
    }

    public class Set10
    {
        public COMMON COMMON { get; set; }
        public ONLINE ONLINE { get; set; }
        public ADDTAX ADDTAX { get; set; }
    }

    public class COMMON
    {
        public string type { get; set; }
        public Struct154 _struct { get; set; }
    }

    public class Struct154
    {
        public Code58 code { get; set; }
        public Msg39 msg { get; set; }
    }

    public class Code58
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg39
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class ONLINE
    {
        public string type { get; set; }
        public Struct155 _struct { get; set; }
    }

    public class Struct155
    {
        public Code59 code { get; set; }
        public Msg40 msg { get; set; }
    }

    public class Code59
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg40
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class ADDTAX
    {
        public string type { get; set; }
        public Struct156 _struct { get; set; }
    }

    public class Struct156
    {
        public Code60 code { get; set; }
        public Msg41 msg { get; set; }
    }

    public class Code60
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg41
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Tittle
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Taxpayerno1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Content7
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Locationentity1
    {
        public string type { get; set; }
        public Struct157 _struct { get; set; }
    }

    public class Struct157
    {
        public Id76 id { get; set; }
        public Location1 location { get; set; }
        public Name10 name { get; set; }
        public Phone19 phone { get; set; }
        public Postcode1 postCode { get; set; }
    }

    public class Id76
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Location1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name10
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Phone19
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Postcode1
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Remark2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Expressno3
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Issuccess2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Errorcode2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Message2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Data2
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc20
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menulist10
    {
        public string type { get; set; }
        public Struct158 _struct { get; set; }
    }

    public class Struct158
    {
        public Id77 id { get; set; }
        public Msg42 msg { get; set; }
        public Url11 url { get; set; }
        public Parentid22 parentId { get; set; }
    }

    public class Id77
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg42
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid22
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permissionlist9
    {
        public string type { get; set; }
        public Struct159 _struct { get; set; }
    }

    public class Struct159
    {
        public Id78 id { get; set; }
        public Permission11 permission { get; set; }
        public Desc21 desc { get; set; }
    }

    public class Id78
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permission11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc21
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permission12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menuname11
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid23
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userentity
    {
        public string type { get; set; }
        public Struct160 _struct { get; set; }
    }

    public class Struct160
    {
        public Id79 id { get; set; }
        public Username18 username { get; set; }
        public Password17 password { get; set; }
        public Phone20 phone { get; set; }
        public Mail16 mail { get; set; }
        public Licencepic13 licencePic { get; set; }
        public Registertime9 registerTime { get; set; }
        public Usertypeenum9 userTypeEnum { get; set; }
        public Userstateenum9 userStateEnum { get; set; }
        public Roleentity9 roleEntity { get; set; }
    }

    public class Id79
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Username18
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Password17
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Phone20
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Mail16
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Licencepic13
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Registertime9
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Usertypeenum9
    {
        public string type { get; set; }
        public Struct161 _struct { get; set; }
    }

    public class Struct161
    {
        public Code61 code { get; set; }
        public Msg43 msg { get; set; }
    }

    public class Code61
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg43
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Userstateenum9
    {
        public string type { get; set; }
        public Struct162 _struct { get; set; }
    }

    public class Struct162
    {
        public Code62 code { get; set; }
        public Msg44 msg { get; set; }
    }

    public class Code62
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg44
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Roleentity9
    {
        public string type { get; set; }
        public Struct163 _struct { get; set; }
    }

    public class Struct163
    {
        public Id80 id { get; set; }
        public Name12 name { get; set; }
        public Desc22 desc { get; set; }
        public Menulist11 menuList { get; set; }
        public Permissionlist10 permissionList { get; set; }
    }

    public class Id80
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Name12
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc22
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Menulist11
    {
        public string type { get; set; }
        public Struct164 _struct { get; set; }
    }

    public class Struct164
    {
        public Id81 id { get; set; }
        public Msg45 msg { get; set; }
        public Url13 url { get; set; }
        public Parentid24 parentId { get; set; }
    }

    public class Id81
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Msg45
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Url13
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Parentid24
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permissionlist10
    {
        public string type { get; set; }
        public Struct165 _struct { get; set; }
    }

    public class Struct165
    {
        public Id82 id { get; set; }
        public Permission13 permission { get; set; }
        public Desc23 desc { get; set; }
    }

    public class Id82
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Permission13
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Desc23
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

}
